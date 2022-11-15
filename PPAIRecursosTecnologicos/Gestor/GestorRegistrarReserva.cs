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
        DataTable turnoSeleccionado;
        DataTable usuarioLogeado;

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

        public (DataTable , DataTable) verificarUsuarioLogueado(DataTable tablaRTseleccionado, int idCentro)
        {
            Sesion sesion = new Sesion();
            usuarioLogeado = sesion.getCientificoLogueado(1);
            RecursoTecnologico rt = new RecursoTecnologico();

            DataTable centroInvestigacionRtSeleccioando = rt.esCientificoDelCentroDeInvestigacion(usuarioLogeado, idCentro);

            (DataTable estadoTurnosActuales, DataTable tablaTurnos) = getTurnosRecursoTecnologicoSeleccionado(centroInvestigacionRtSeleccioando);
 
            return ( estadoTurnosActuales, tablaTurnos);
        }

        //recibe el rt seleccionado desde la pantalla
        public (List<string>, List<Turno>) tomarSeleccionRecursoTecnologico(string nombreRecursoSeleccionado)
        {
            RecursoTecnologico rt = new RecursoTecnologico();
            (DataTable tablaRTseleccionado, int idCentro) = rt.getRecursosTecnologicos(nombreRecursoSeleccionado);

            (DataTable estadoTurnosActuales, DataTable tablaTurnos) = verificarUsuarioLogueado(tablaRTseleccionado, idCentro);

            Utils util = new Utils();
            List<string> listaestado = util.ObtenerEstado(estadoTurnosActuales);
            List<Turno> listaTurno = util.ObtenerTurno(tablaTurnos);

            return (listaestado, listaTurno);
        }


        public (DataTable, DataTable) getTurnosRecursoTecnologicoSeleccionado(DataTable asignacionPersonalLogueado)
        {
            RecursoTecnologico rt = new RecursoTecnologico();
            (DataTable estadoTurnosActuales, DataTable tablaTurnos) = rt.getTurnos(asignacionPersonalLogueado);
            return (estadoTurnosActuales, tablaTurnos);
        }

        //recibe la seleccion desde la pantalla
        public DataTable tomarSeleccionTurno(DateTime fechaTurno)
        {
            Turno turno = new Turno();
            turnoSeleccionado = turno.BuscarTurnoPorFecha(fechaTurno);
            return turnoSeleccionado;
        }

        public (List<Turno>, List<string>) tomarConfirmacionReserva()
        {
            int idEstadoReservado = generarReservaRecursoTecnologico();

            reservar(idEstadoReservado);

            Utils util = new Utils();
            List<Turno> ListaTurnoSeleccionado = util.ObtenerTablaTurnoSeleccionado(turnoSeleccionado);

            EstadoDAO estadobd = new EstadoDAO();
            DataTable nombreEstadoReservado = estadobd.getEstadoPorId(idEstadoReservado);
            List<string> listaestado = util.ObtenerEstado(nombreEstadoReservado);

            return (ListaTurnoSeleccionado, listaestado);
        }

        public int generarReservaRecursoTecnologico()
        {
            Estado estado = new Estado();
            int idEstadoReservado = estado.esAmbitoTurno();
            return idEstadoReservado;
        }

        public void reservar(int idEstadoReservado)
        {
            RecursoTecnologico rt = new RecursoTecnologico();
            rt.reservar(idEstadoReservado, turnoSeleccionado, usuarioLogeado);
        }
    }
}
