using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Turno
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

        CambioEstadoTurno cambioEstadoT = new CambioEstadoTurno();

        public DataTable getTurnos()
        {
            TurnoDAO turnodb = new TurnoDAO();
            DataTable tablaTurnos = turnodb.getTurnos();
            return tablaTurnos;
        }

        public (DataTable, DataTable) getTurnos(DataTable asignacionPersonalLogueado)
        {
            Utils util = new Utils();
            string idTurno = util.ObtenerIdTurno(asignacionPersonalLogueado);
            DataTable estadoTurnosActuales = new DataTable();

            (Boolean bandera, DataTable tablaTurnos) = esPosteriorFechaHoraActual(idTurno);

            if(bandera)
            {
                estadoTurnosActuales = BuscarTurnoReservable(idTurno);
            }

            return (estadoTurnosActuales, tablaTurnos);
        }

        public (Boolean, DataTable) esPosteriorFechaHoraActual(string idTurno)
        {
            bool bandera;
            TurnoDAO turnobd = new TurnoDAO();
            DataTable tablaTurnos = turnobd.getTurnoPorId(idTurno);

            Utils util = new Utils();
            DateTime fechaTurno = util.ObtenerFechaTurno(tablaTurnos);

            DateTime fechaActual = DateTime.Now;
            if (fechaTurno > fechaActual)
            {
                bandera = true;
            }
            else
                bandera = false;

            return (bandera, tablaTurnos);
        }


        public DataTable BuscarTurnoReservable(string idTurno)
        {
            CambioEstadoTurno cambioEstadoT = new CambioEstadoTurno();
            DataTable estadoTurnosActuales = cambioEstadoT.EsActual(idTurno);
            return estadoTurnosActuales;
        }

        public DataTable BuscarTurnoPorFecha(DateTime fechaTurno)
        {
            TurnoDAO turnodb = new TurnoDAO();
            DataTable turnoSeleccionado = turnodb.BuscarTurnoPorFecha(fechaTurno);
            return turnoSeleccionado;
        }
    }
}
