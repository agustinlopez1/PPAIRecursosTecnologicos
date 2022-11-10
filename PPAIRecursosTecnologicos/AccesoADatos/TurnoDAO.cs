using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class TurnoDAO
    {
        private int idTurno;
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private DateTime fechaGeneracion;
        private int idCambioEstadoTurno;

        public DateTime FechaGeneracion { get => fechaGeneracion; set => fechaGeneracion = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public int IdCambioEstadoTurno { get => idCambioEstadoTurno; set => idCambioEstadoTurno = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }

        Acceso_base_dato _BD = new Acceso_base_dato();

        public DataTable esPosteriorFechaHoraActual(DataTable asignacionPersonalLogueado)
        {
            string sql = "buscar turno con fecha inicio mayor a la fecha actual de la asignacion del usuario logueado";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarEstadoPorCambioEstado(DataTable tablaTurnosDisponibles)
        {
            string sql = "buscar turno de cambio de estado actual";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarEstadoPorCambioEstado(DateTime fechaTurno)
        {
            string sql = "buscar turno por fehca";
            return _BD.EjecutarSelect(sql);
        }
    }
}