using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class AsignacionCientificoDeCentroInvestigacion
    {
        private PersonalCientifico personalCientifico;
        private Turno turno;

        public PersonalCientifico PersonalCientifico { get => PersonalCientifico; set => PersonalCientifico = value; }
        public Turno Turno { get => Turno; set => Turno = value; }

        public AsignacionCientificoDeCentroInvestigacion getAsignacionCientificoDeCentroInvestigacion()
        {

            PersonalCientifico personalCientifico = new PersonalCientifico();
            PersonalCientifico personal = personalCientifico.generarPersonalCientifico();

            Turno turno = new Turno();
            List<Turno> listaTurno = new List<Turno>();
            listaTurno = turno.getTurnos();


            AsignacionCientificoDeCentroInvestigacion aginacionCientifico = new AsignacionCientificoDeCentroInvestigacion();
            aginacionCientifico.personalCientifico = personal;
            aginacionCientifico.turno = listaTurno[0];

            return aginacionCientifico;
        }

        public (bool, PersonalCientifico) esTuCientifico(Usuario usuario)
        {
            AsignacionCientificoDeCentroInvestigacion asignacion = getAsignacionCientificoDeCentroInvestigacion();
            PersonalCientifico logeadoCientifico;

            if (asignacion.personalCientifico.Nombre + asignacion.personalCientifico.Apellido == usuario.Nombre)
            {
                logeadoCientifico = asignacion.personalCientifico;
                return (true, logeadoCientifico);
            }
            else
            {
                return (false, null);
            }
        }

        public void setTurno(Turno turnoSeleccionado, PersonalCientifico personalCientificoLogueado)
        {
            AsignacionCientificoDeCentroInvestigacion aginacionCientificoNueva = getAsignacionCientificoDeCentroInvestigacion();
            aginacionCientificoNueva.personalCientifico = personalCientificoLogueado;
            aginacionCientificoNueva.turno = turnoSeleccionado;

        }
    }
}
