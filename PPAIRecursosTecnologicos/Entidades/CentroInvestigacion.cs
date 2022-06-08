using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class CentroInvestigacion
    {
        private string nombre;
        private List<RecursoTecnologico> recursosTecnologicos;

        public CentroInvestigacion() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public List<RecursoTecnologico> RecursosTecnologicos { get => recursosTecnologicos; set => recursosTecnologicos = value; }

    }
}
