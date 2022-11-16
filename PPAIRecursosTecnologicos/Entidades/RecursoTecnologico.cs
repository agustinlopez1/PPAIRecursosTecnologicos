using PPAIRecursosTecnologicos.AccesoADatos;
using PPAIRecursosTecnologicos.Estrategia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class RecursoTecnologico
    {
        private string nombre;
        private int numeroRT;
        private DateTime fechaAlta;
        private int idModelo;
        private int idCambioEstadoRT;
        private int idTipoRecurso;
        private int idCentroInvestigacion;
        private string periodicidadMantenimientoPrev;
        private string duracionMantenimientoPrev;
        private string fraccionHorarioTurnos;
        private int idTurnos;
        private EstrategiaRT estrategiaSeleccionada;


        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public int IdCambioEstadoRT { get => idCambioEstadoRT; set => idCambioEstadoRT = value; }
        public int IdTipoRecurso { get => idTipoRecurso; set => idTipoRecurso = value; }
        public int IdCentroInvestigacion { get => idCentroInvestigacion; set => idCentroInvestigacion = value; }
        public int NumeroRT { get => numeroRT; set => numeroRT = value; }
        public string PeriodicidadMantenimientoPrev { get => periodicidadMantenimientoPrev; set => periodicidadMantenimientoPrev = value; }
        public string DuracionMantenimientoPrev { get => duracionMantenimientoPrev; set => duracionMantenimientoPrev = value; }
        public string FraccionHorarioTurnos { get => fraccionHorarioTurnos; set => fraccionHorarioTurnos = value; }
        public int IdTurnos { get => idTurnos; set => idTurnos = value; }

        Turno turno = new Turno();

        public (DataTable, int) getRecursosTecnologicos(string nombreRecursoSeleccionado)
        {
            RecursoTecnologicoDAO rtbd = new RecursoTecnologicoDAO();
            DataTable tablaRTseleccionado = rtbd.getRecursosTecnologicos(nombreRecursoSeleccionado);
            Utils util = new Utils();
            int idCentro = util.ObtenerIdCentroInvestigacionRTSeleccionado(tablaRTseleccionado);


            return (tablaRTseleccionado, idCentro);
        }

        public void crearEstrategia(Boolean bandera)
        // Método del STRATEGY para calcular la duracion estimada      
        {
            EstrategiaRT estrategia;

            if (bandera == true)
            {
                estrategia = new EstrategiaCientificoMismoCI();

            }
            else
            {
                estrategia = new EstrategiaCientificoDistintoCI();

            }
            agregarEstrategia(estrategia);
        }

        //public (DataTable, DataTable) getTurnos(DataTable asignacionPersonalLogueado)
        //{
        //    Turno turno = new Turno();
        //    (DataTable estadoTurnosActuales, DataTable tablaTurnos) = turno.getTurnos(asignacionPersonalLogueado);
        //    return (estadoTurnosActuales, tablaTurnos);
        //}

        public (DataTable, DataTable) getTurnos(DataTable asignacionPersonalLogueado, Boolean bandera)
        {
            crearEstrategia(bandera);
            (DataTable estadoTurnosActuales, DataTable tablaTurnos) = estrategiaSeleccionada.getTurnos(asignacionPersonalLogueado);
            return (estadoTurnosActuales, tablaTurnos);
        }

        public void agregarEstrategia(EstrategiaRT estrategia)
        {
            estrategiaSeleccionada = estrategia;
        }

        public DataTable esDeTipoRtSeleccionado(string tipoRtSeleccionado)
        {
            RecursoTecnologicoDAO rtBaseDatos = new RecursoTecnologicoDAO();
            DataTable tablaTipoRt = rtBaseDatos.BuscarRtPorTipo(tipoRtSeleccionado);
            return tablaTipoRt;
        }

        public Boolean esReservable(List<RecursoTecnologico> listaRTdeTipoRT)
        {
            Boolean bandera = false;
            foreach(RecursoTecnologico rt in listaRTdeTipoRT)
            {
                if (rt.idCambioEstadoRT == 1)
                    bandera = true;
                else
                    bandera = false;
            }
            return bandera;
        }


        public (DataTable, Boolean) esCientificoDelCentroDeInvestigacion(DataTable usuarioLogeado, int idCentro)
        {
            CentroInvestigacion centroInvestigacion = new CentroInvestigacion();
            (DataTable centroInvestigacionRtSeleccioando, Boolean bandera) = centroInvestigacion.esAsignado(usuarioLogeado, idCentro);
            return (centroInvestigacionRtSeleccioando, bandera);
        }

        public void reservar(int idEstadoReservado, DataTable turnoSeleccionado, DataTable usuarioLogeado)
        {
            AsignacionCientificoDeCentroInvestigacion ac = new AsignacionCientificoDeCentroInvestigacion();
            
            Utils util = new Utils();
            string idTurnoSeleccionado = util.ObtenerIdTurnoSelec(turnoSeleccionado);
            string idUsuario = util.ObtenerIdUsuario(usuarioLogeado);

            int nuevoIdcmt = ac.Reservar(turnoSeleccionado, idEstadoReservado);

            CentroInvestigacion ci = new CentroInvestigacion();
            ci.asignarTurno(idTurnoSeleccionado, idUsuario, nuevoIdcmt);
        }

    }
}
