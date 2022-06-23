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
        private Estado estado;
        public List<Turno> getTurnos()
        {
            List<Turno> listaTurno = new List<Turno>();

            Turno Turno1 = new Turno();
            Turno1.fechaGeneracion = DateTime.Now.AddDays(-10);
            Turno1.fechaHoraInicio = DateTime.Now.AddHours(15);
            Turno1.fechaHoraFin = DateTime.Now.AddDays(1);
            listaTurno.Add(Turno1);

            Turno Turno2 = new Turno();
            Turno2.fechaGeneracion = DateTime.Now.AddDays(-20);
            Turno2.fechaHoraInicio = DateTime.Now.AddHours(10);
            Turno2.fechaHoraFin = DateTime.Now.AddDays(2);
            listaTurno.Add(Turno2);

            return listaTurno;

        }

        public bool esPosteriorFechaHoraActual(Turno turno)
        {
            if (turno.fechaHoraInicio < DateTime.Now)
                return true;
            else
                return false;

        }

        public static void getDatos(List<Turno> turnos)
        {
            foreach (Turno turno in turnos)
            {

            }
        }
    }
}
