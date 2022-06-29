using PPAIRecursosTecnologicos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAIRecursosTecnologicos.Pantalla;
using System.Windows.Forms;

namespace PPAIRecursosTecnologicos.Gestor
{
    public class GestorRegistrarReserva
    {

        private List<string> tiposRecursos;
        private Sesion sesion;
        private string tipoRecursoSeleccionado;
        private static RecursoTecnologico rtSeleccionado;
        private string tipoRecurso;
        private RecursoTecnologico recursoTecnologicoSeleccionado;
        private DateTime fechaHoraActual = DateTime.UtcNow;
        private static Turno turnoSeleccionado;


        // GET Y SET de atributos
        // public List<RecursoTecnologico> RecursosTecnologicos { get => recursosTecnologicos; set => recursosTecnologicos = value; }
        //  public List<string> TiposRecursos { get => tiposRecursos; set => tiposRecursos = value; }
        public Sesion Sesion { get => sesion; set => sesion = value; }


        // Le solicito a "Tipo de Recursos Tecnologicos" que me devuelva una lista de todos.
        public List<string> buscarTipoRecursoTecnologico()
        {
            TipoRecurso tipoRecurso = new TipoRecurso();
            this.tiposRecursos = tipoRecurso.getNombre();

            return tiposRecursos;
        }


        // Gestor recibe el tipo de recurso desde la pantalla y lo guarda 
        public (List<RecursoTecnologico>, List<String>, List<String>, List<String>, List<String>) tomarSeleccionTipoRecursoTecnologico(string tipoRecurso)
        {
            tipoRecursoSeleccionado = tipoRecurso;
            (List<RecursoTecnologico> listaRTdeTipoRT, List<string> listaEstados, List<String> listaMarca, List<String> listaModelo, List<string> listaCentroInvestigacion) = obtenerRecursoTecnologicoActivo(tipoRecursoSeleccionado);

            return (listaRTdeTipoRT, listaEstados, listaMarca, listaModelo, listaCentroInvestigacion);
        }


        //gestor busca el rt del tipo seleccionado
        public (List<RecursoTecnologico>, List<String>, List<String>, List<String>, List<String>) obtenerRecursoTecnologicoActivo(string tipoRecursoSeleccionado)
        {
            RecursoTecnologico recursoTecnologico = new RecursoTecnologico();
            List<RecursoTecnologico> listaRTdeTipoRT = recursoTecnologico.esDeTipoRtSeleccionado(tipoRecursoSeleccionado);
            (List<RecursoTecnologico> listaRTReservable, List<string> listaEstados) = recursoTecnologico.esReservable(listaRTdeTipoRT);
            (List<string> listaMarca, List<string> listaModelos, List<string> listaCentroInvestigacion) = getDatosRT(listaRTReservable);

            return (listaRTReservable, listaEstados, listaMarca, listaModelos, listaCentroInvestigacion);
        }

        //busca los datos del rt
        public (List<string>, List<string>, List<string>) getDatosRT(List<RecursoTecnologico> listaRTReservable)
        {
            RecursoTecnologico recursoTecnologico = new RecursoTecnologico();

            (List<string> listaMarca, List<string> listaModelos) = recursoTecnologico.getMarcaModelo(listaRTReservable);
            List<string> listaCentroInvestigacion = recursoTecnologico.getCentroInvestigacion(listaRTReservable);

            return (listaMarca, listaModelos, listaCentroInvestigacion);

        }

        //verificar que el centro de investigacion pertenece al usuario logeado
        public string verificarUsuarioLogueado()
        {
            Sesion sesion = new Sesion();
            Usuario cientificoLogeado = sesion.getCientificoLogueado(1).Usuario;

            if (recursoTecnologicoSeleccionado.esCientificoDelCentroDeInvestigacion(cientificoLogeado))
                getTurnosRecursoTecnologicoSeleccionado();
            else
                MessageBox.Show("No puede seleccionar el recurso tecnologico seleccionado");

            return cientificoLogeado.Nombre;
        }


        //recibe el rt seleccionado desde la pantalla
        public void tomarSeleccionRecursoTecnologico(RecursoTecnologico recursoTecnologicoSeleccionado)
        {
            this.recursoTecnologicoSeleccionado = recursoTecnologicoSeleccionado;
            rtSeleccionado = recursoTecnologicoSeleccionado;
            verificarUsuarioLogueado();
        }

        public void getTurnosRecursoTecnologicoSeleccionado()
        {
            List<String> listaEstados = new List<String>();
            List<Turno> turnosPosteriorFecha = new List<Turno>();

            (turnosPosteriorFecha, listaEstados) = recursoTecnologicoSeleccionado.getTurnos();

            PantallaRegistrarTurno pantallaRegistrarTurno = new PantallaRegistrarTurno();
            pantallaRegistrarTurno.pedirSeleccionTurno(turnosPosteriorFecha, listaEstados);
            pantallaRegistrarTurno.Show();

        }

        //recibe la seleccion desde la pantalla
        public void tomarSeleccionTurno(Turno turnoSelec)
        {
            turnoSeleccionado = turnoSelec;
            PantallaRegistrarTurno.mostrarDatosTurno(turnoSeleccionado);
        }

        public void tomarConfirmacionReserva()
        {
            Estado estadoReservado = generarReservaRecursoTecnologico();
            reservar(estadoReservado);
        }

        public Estado generarReservaRecursoTecnologico()
        {
            Estado estado = new Estado();
            Estado estadoReservado = estado.esAmbitoTurno();
            return estadoReservado;
        }

        public void reservar(Estado estadoReservado)
        {
            rtSeleccionado.reservar(estadoReservado, turnoSeleccionado);
        }
    }
}
