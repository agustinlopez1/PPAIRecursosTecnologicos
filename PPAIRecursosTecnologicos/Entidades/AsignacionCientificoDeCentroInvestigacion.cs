using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class AsignacionCientificoDeCentroInvestigacion
    {
        private int idAsignacionCientificoCI;
        private int idPersonalCientifico;
        private int idTurno;

        public int IdPersonalCientifico { get => idPersonalCientifico; set => idPersonalCientifico = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }
        public int IdAsignacionCientificoCI { get => idAsignacionCientificoCI; set => idAsignacionCientificoCI = value; }


        public DataTable getAsignacionCientificoDeCentroInvestigacion(DataTable usuarioLogeado)
        {
            PersonalCientifico personalCientifico = new PersonalCientifico();
            DataTable personalCientificoLogueado = personalCientifico.generarPersonalCientifico(usuarioLogeado);

            AsignacionCientificaCAO asignacionbd = new AsignacionCientificaCAO();
            DataTable asignacionPersonal = asignacionbd.BuscarAsignacionPersonal(personalCientificoLogueado);
            return asignacionPersonal;
        }

        public DataTable esTuCientifico(DataTable usuarioLogeado)
        {
            PersonalCientifico personalCientifico = new PersonalCientifico();
            DataTable asignacionPersonalLogueado = personalCientifico.generarPersonalCientifico(usuarioLogeado);

            return asignacionPersonalLogueado;
        }

        //public void setTurno(Turno turnoSeleccionado, PersonalCientifico personalCientificoLogueado)
        //{
        //    AsignacionCientificoDeCentroInvestigacion aginacionCientificoNueva = getAsignacionCientificoDeCentroInvestigacion();
        //    aginacionCientificoNueva.personalCientifico = personalCientificoLogueado;
        //    aginacionCientificoNueva.turno = turnoSeleccionado;

        //}
    }
}
