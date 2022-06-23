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

        public PersonalCientifico PersonalCientifico { get => PersonalCientifico; set => PersonalCientifico = value; }

        public AsignacionCientificoDeCentroInvestigacion getAsignacionCientificoDeCentroInvestigacion()
        {

            PersonalCientifico personalCientifico = new PersonalCientifico();
            PersonalCientifico personal = personalCientifico.generarPersonalCientifico();

            AsignacionCientificoDeCentroInvestigacion aginacionCientifico = new AsignacionCientificoDeCentroInvestigacion();
            aginacionCientifico.personalCientifico = personal;

            return aginacionCientifico;
        }

        public bool esTuCientifico(Usuario usuario)
        {
            AsignacionCientificoDeCentroInvestigacion asignacion = getAsignacionCientificoDeCentroInvestigacion();
            if(asignacion.personalCientifico.Nombre + asignacion.personalCientifico.Apellido == usuario.Nombre)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
