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

        public DataTable getTurnos(DataTable asignacionPersonalLogueado)
        {
            DataTable tablaTurnosDisponibles = esPosteriorFechaHoraActual(asignacionPersonalLogueado);
            DataTable estadoTurnosActuales = BuscarTurnoReservable(tablaTurnosDisponibles);
            return estadoTurnosActuales;
        }

        public DataTable esPosteriorFechaHoraActual(DataTable asignacionPersonalLogueado)
        {
            TurnoDAO turnobd = new TurnoDAO();
            DataTable tablaTurnosDisponibles = turnobd.esPosteriorFechaHoraActual(asignacionPersonalLogueado);
            return tablaTurnosDisponibles;
        }

        //public DataTable BuscarTurnoReservable(DataTable tablaTurnosDisponibles)
        //{
        //    List<String> listaEstados = new List<String>();
        //    List<CambioEstadoTurno> cambioEstadoActual = new List<CambioEstadoTurno>();
        //    Boolean esActual;

        //    foreach (Turno turno in turnos)
        //    {
        //        (esActual, listaEstados, cambioEstadoActual) = cambioEstadoT.EsActual(turno, listaEstados, cambioEstadoActual);
        //    }
        //    this.cambioEstadoTurnoActual = cambioEstadoActual;
        //    return listaEstados;
        //}

        public DataTable BuscarTurnoReservable(DataTable tablaTurnosDisponibles)
        {
            CambioEstadoTurno cambioEstadoT = new CambioEstadoTurno();
            DataTable estadoTurnosActuales = cambioEstadoT.EsActual(tablaTurnosDisponibles);
            return estadoTurnosActuales;
        }

        //public String reservar(Estado estadoReservado, Turno turnoSeleccionado)
        //{
        //    List<CambioEstadoTurno> listaCambioEstadoTurno2;
        //    String nombreEstadoActual = "";

        //    foreach (CambioEstadoTurno cambioEstado in this.cambioEstadoTurnoActual)
        //    {
        //        foreach (CambioEstadoTurno cambioEstadoTurno in turnoSeleccionado.cambioEstadoTurno)
        //        {
        //            if (cambioEstadoTurno == cambioEstado)
        //            {
        //                cambioEstadoTurno.setFechaHoraFin();
        //                listaCambioEstadoTurno2 = cambioEstadoTurno.New();
        //                turnoSeleccionado.cambioEstadoTurno = listaCambioEstadoTurno2;
        //                cambioEstadoTurno.Estado = estadoReservado;
        //                nombreEstadoActual = cambioEstadoTurno.Estado.Nombre;
        //            }
        //        }
        //    }

        //    return nombreEstadoActual;
        //}

        public DataTable BuscarTurnoPorFecha(DateTime fechaTurno)
        {
            TurnoDAO turnodb = new TurnoDAO();
            DataTable turnoSeleccionado = turnodb.BuscarTurnoPorFecha(fechaTurno);
            return turnoSeleccionado;
        }
    }
}
