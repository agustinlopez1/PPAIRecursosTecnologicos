using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class AsignacionCientificoDeCentroInvestigacion
    {
        private PersonalCientifico personal;

        public bool esTuCientifico(Usuario usuario)
        {
            if (personal.Nombre + personal.Apellido == usuario.Nombre)
                return true;
            else
                return false;
        }
    }
}
