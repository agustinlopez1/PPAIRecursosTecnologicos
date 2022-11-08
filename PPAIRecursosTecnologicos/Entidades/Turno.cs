using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Turno
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private DateTime fechaGeneracion;
        private List<CambioEstadoTurno> cambioEstadoTurno;
        private List<CambioEstadoTurno> cambioEstadoTurnoActual;

        public DateTime FechaGeneracion { get => fechaGeneracion; set => fechaGeneracion = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public List<CambioEstadoTurno> CambioEstadoTurno { get => cambioEstadoTurno; set => cambioEstadoTurno = value; }

        CambioEstadoTurno cambioEstadoT = new CambioEstadoTurno();

        public List<Turno> getTurnos()
        {
            List<Turno> listaTurno = new List<Turno>();

            (List<CambioEstadoTurno> listaCambioEstadoTurno1, List<CambioEstadoTurno> listaCambioEstadoTurno2) = cambioEstadoT.getCambioEstadoTurno();


            Turno Turno1 = new Turno();
            Turno1.fechaGeneracion = DateTime.Now.AddDays(-10);
            Turno1.fechaHoraInicio = DateTime.Now.AddDays(1);
            Turno1.fechaHoraFin = DateTime.Now.AddDays(2);
            Turno1.cambioEstadoTurno = listaCambioEstadoTurno1;
            listaTurno.Add(Turno1);

            Turno Turno2 = new Turno();
            Turno2.fechaGeneracion = DateTime.Now.AddDays(-20);
            Turno2.fechaHoraInicio = DateTime.Now.AddHours(10);
            Turno2.fechaHoraFin = DateTime.Now.AddDays(2);
            Turno2.cambioEstadoTurno = listaCambioEstadoTurno2;
            listaTurno.Add(Turno2);

            return listaTurno;

        }

        public bool esPosteriorFechaHoraActual(Turno turno)
        {
            if (turno.fechaHoraInicio > DateTime.Now)
                return true;
            else
                return false;

        }

        public List<String> getDatos(List<Turno> turnos)
        {
            List<String> listaEstados = new List<String>();
            List<CambioEstadoTurno> cambioEstadoActual = new List<CambioEstadoTurno>();
            Boolean esActual;

            foreach (Turno turno in turnos)
            {
                (esActual, listaEstados, cambioEstadoActual) = cambioEstadoT.EsActual(turno, listaEstados, cambioEstadoActual);
            }
            this.cambioEstadoTurnoActual = cambioEstadoActual;
            return listaEstados;
        }

        public String reservar(Estado estadoReservado, Turno turnoSeleccionado)
        {
            List<CambioEstadoTurno> listaCambioEstadoTurno2;
            String nombreEstadoActual = "";

            foreach (CambioEstadoTurno cambioEstado in this.cambioEstadoTurnoActual)
            {
                foreach (CambioEstadoTurno cambioEstadoTurno in turnoSeleccionado.cambioEstadoTurno)
                {
                    if (cambioEstadoTurno == cambioEstado)
                    {
                        cambioEstadoTurno.setFechaHoraFin();
                        listaCambioEstadoTurno2 = cambioEstadoTurno.New();
                        turnoSeleccionado.cambioEstadoTurno = listaCambioEstadoTurno2;
                        cambioEstadoTurno.Estado = estadoReservado;
                        nombreEstadoActual = cambioEstadoTurno.Estado.Nombre;
                    }
                }
            }

            return nombreEstadoActual;
        }
    }
}
