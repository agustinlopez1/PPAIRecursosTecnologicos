using PPAIRecursosTecnologicos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAIRecursosTecnologicos.Pantalla;
using System.Windows.Forms;
using System.Data;
using PPAIRecursosTecnologicos.AccesoADatos;

namespace PPAIRecursosTecnologicos.Gestor
{
    public class GestorRegistrarReserva
    {

        private DataTable tiposRecursos;
        private Sesion sesion;
        private string tipoRecursoSeleccionado;
        private string tipoRecurso;
        private RecursoTecnologico recursoTecnologicoSeleccionado;
        private DateTime fechaHoraActual = DateTime.UtcNow;
        private Turno turnoSeleccionado;
        PersonalCientifico pesrsonalCientificoLogeado;

        // GET Y SET de atributos
        // public List<RecursoTecnologico> RecursosTecnologicos { get => recursosTecnologicos; set => recursosTecnologicos = value; }
        //  public List<string> TiposRecursos { get => tiposRecursos; set => tiposRecursos = value; }
        public Sesion Sesion { get => sesion; set => sesion = value; }

        public DataTable buscarTipoRecursoTecnologico()
        {
            TipoRecurso tipoRecurso = new TipoRecurso();
            this.tiposRecursos = tipoRecurso.getNombre();
            return tiposRecursos;
        }


        // Gestor recibe el tipo de recurso desde la pantalla y lo guarda 
        public (string, string, string, string, List<RecursoTecnologico>) tomarSeleccionTipoRecursoTecnologico(string tipoRecurso)
        {
            tipoRecursoSeleccionado = tipoRecurso;
            string nombreEstadoRT = "";
            string nombreCentroIvestigacion = "";
            string nombreModelo = "";
            string nombreMarca = "";
            List<RecursoTecnologico> listaRTdeTipoRT = new List<RecursoTecnologico>();

            (nombreEstadoRT, nombreCentroIvestigacion, nombreModelo, nombreMarca, listaRTdeTipoRT) = obtenerRecursoTecnologicoActivo(tipoRecursoSeleccionado);

            return (nombreEstadoRT, nombreCentroIvestigacion, nombreModelo, nombreMarca, listaRTdeTipoRT);
        }


        //gestor busca el rt del tipo seleccionado
        public (string, string, string, string, List<RecursoTecnologico>) obtenerRecursoTecnologicoActivo(string tipoRecursoSeleccionado)
        {
            string nombreEstadoRT = "";
            string nombreCentroIvestigacion = "";
            string nombreModelo = "";
            string nombreMarca = "";

            RecursoTecnologico recursoTecnologico = new RecursoTecnologico();
            DataTable tablaRTdeTipoRT = recursoTecnologico.esDeTipoRtSeleccionado(tipoRecursoSeleccionado);

            Utils util = new Utils();
            List< RecursoTecnologico>  listaRTdeTipoRT = util.ObtenerListaRtTipoSeleccionado(tablaRTdeTipoRT);

            if (recursoTecnologico.esReservable(listaRTdeTipoRT))
            {
                (nombreEstadoRT, nombreCentroIvestigacion, nombreModelo, nombreMarca) = getDatosRT(listaRTdeTipoRT);
            }

            return (nombreEstadoRT, nombreCentroIvestigacion, nombreModelo, nombreMarca, listaRTdeTipoRT);
        }

        //busca los datos del rt
        public (string, string, string, string) getDatosRT(List<RecursoTecnologico> listaRTdeTipoRT)
        {
            //buscar estado
            CambioEstadoDAO cambioEstadoRT = new CambioEstadoDAO();
            DataTable estadoRT = cambioEstadoRT.BuscarCambioEstadoActual(listaRTdeTipoRT);

            Utils util = new Utils();
            string nombreEstadoRT = util.ObtenerListaEstado(estadoRT);

            //busacr centro de investigacion
            CentroInvestigacionDAO centroInvestigacion = new CentroInvestigacionDAO();
            DataTable tablaCentroInvestigacion = centroInvestigacion.BuscarCentroInvestigacion(listaRTdeTipoRT);

            string nombreCentroIvestigacion = util.ObtenerListaCentroInvestigacion(tablaCentroInvestigacion);

            //buscar modelo
            ModeloDAO modelo = new ModeloDAO();
            (DataTable tablaModelo, string idModelo) = modelo.BuscarModelo(listaRTdeTipoRT);
            string nombreModelo = util.ObtenerListaModelo(tablaModelo);

            //buscar marca
            DataTable tablaMarca = modelo.BuscarMarca(idModelo);
            string nombreMarca = util.ObtenerListaMarca(tablaMarca);

            return (nombreEstadoRT, nombreCentroIvestigacion, nombreModelo, nombreMarca);
        }

        //verificar que el centro de investigacion pertenece al usuario logeado
        //public (PersonalCientifico, List<Turno>, List<String>) verificarUsuarioLogueado()
        //{
        //    List<String> listaEstados = new List<String>();
        //    List<Turno> turnosPosteriorFecha = new List<Turno>();

        //    Sesion sesion = new Sesion();
        //    Usuario cientificoLogeado = sesion.getCientificoLogueado(1).Usuario;

        //    Boolean bandera;
        //    PersonalCientifico logeadoCientifico;
        //    (bandera, logeadoCientifico) = recursoTecnologicoSeleccionado.esCientificoDelCentroDeInvestigacion(cientificoLogeado);

        //    if (bandera == true)
        //        (turnosPosteriorFecha, listaEstados)  = getTurnosRecursoTecnologicoSeleccionado();
        //    else
        //        MessageBox.Show("No puede seleccionar el recurso tecnologico seleccionado");

        //    return (logeadoCientifico, turnosPosteriorFecha, listaEstados);
        //}

        public DataTable verificarUsuarioLogueado(DataTable tablaRTseleccionado, int idCentro)
        {
            Sesion sesion = new Sesion();
            DataTable usuarioLogeado = sesion.getCientificoLogueado(1);
            RecursoTecnologico rt = new RecursoTecnologico();

            DataTable centroInvestigacionRtSeleccioando = rt.esCientificoDelCentroDeInvestigacion(usuarioLogeado, idCentro);
            
            DataTable estadoTurnosActuales = getTurnosRecursoTecnologicoSeleccionado(centroInvestigacionRtSeleccioando);
 
            return estadoTurnosActuales;
        }


        //recibe el rt seleccionado desde la pantalla
        //public (List<Turno>, List<String>) tomarSeleccionRecursoTecnologico(RecursoTecnologico recursoTecnologicoSeleccionado)
        //{
        //    List<String> listaEstados = new List<String>();
        //    List<Turno> turnosPosteriorFecha = new List<Turno>();
        //    PersonalCientifico cientificoLogeado;

        //    this.recursoTecnologicoSeleccionado = recursoTecnologicoSeleccionado;
        //    (cientificoLogeado, turnosPosteriorFecha, listaEstados) = verificarUsuarioLogueado();

        //    this.pesrsonalCientificoLogeado = cientificoLogeado;

        //    return (turnosPosteriorFecha, listaEstados);
        //}

        public DataTable tomarSeleccionRecursoTecnologico(string nombreRecursoSeleccionado)
        {
            RecursoTecnologico rt = new RecursoTecnologico();
           (DataTable tablaRTseleccionado, int idCentro) = rt.getRecursosTecnologicos(nombreRecursoSeleccionado);

            DataTable estadoTurnosActuales = verificarUsuarioLogueado(tablaRTseleccionado, idCentro);
            return estadoTurnosActuales;
        }


        public DataTable getTurnosRecursoTecnologicoSeleccionado(DataTable asignacionPersonalLogueado)
        {
            DataTable estadoTurnosActuales = recursoTecnologicoSeleccionado.getTurnos(asignacionPersonalLogueado);
            return estadoTurnosActuales;
        }

        //recibe la seleccion desde la pantalla
        public DataTable tomarSeleccionTurno(DateTime fechaTurno)
        {
            Turno turno = new Turno();
            DataTable turnoSeleccionado = turno.BuscarTurnoPorFecha(fechaTurno);
            return turnoSeleccionado;
        }

        public (Turno, string) tomarConfirmacionReserva()
        {
            Estado estadoReservado = generarReservaRecursoTecnologico();
            Turno turnoActualizado;
            string nombreEstadoActual;

            (turnoActualizado, nombreEstadoActual) = reservar(estadoReservado);

            return (turnoActualizado, nombreEstadoActual);
        }

        public Estado generarReservaRecursoTecnologico()
        {
            Estado estado = new Estado();
            Estado estadoReservado = estado.esAmbitoTurno();
            return estadoReservado;
        }

        public (Turno, string) reservar(Estado estadoReservado)
        {
            Turno turnoActualizado;
            string nombreEstadoActual;
            (turnoActualizado, nombreEstadoActual) = recursoTecnologicoSeleccionado.reservar(estadoReservado, turnoSeleccionado, pesrsonalCientificoLogeado);
           
            return (turnoActualizado, nombreEstadoActual);
        }
    }
}
