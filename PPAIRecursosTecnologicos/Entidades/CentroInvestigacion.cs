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
       // private List<RecursoTecnologico> recursosTecnologicos;

        public CentroInvestigacion() { }

        public string Nombre { get => nombre; set => nombre = value; }
        //public List<RecursoTecnologico> RecursosTecnologicos { get => recursosTecnologicos; set => recursosTecnologicos = value; }

        public List<CentroInvestigacion> getCentroInvestigacion()
        {
  
            List<CentroInvestigacion> listaCentroInvestigacion = new List<CentroInvestigacion>();

            CentroInvestigacion CentroInvestigacion1 = new CentroInvestigacion();
            CentroInvestigacion1.nombre = "Centro Investigacion uno";

            listaCentroInvestigacion.Add(CentroInvestigacion1);

            CentroInvestigacion CentroInvestigacion2 = new CentroInvestigacion();
            CentroInvestigacion2.nombre = "Centro Investigacion dos";

            listaCentroInvestigacion.Add(CentroInvestigacion2);

            CentroInvestigacion CentroInvestigacion3 = new CentroInvestigacion();
            CentroInvestigacion3.nombre = "Centro Investigacion tres";

            listaCentroInvestigacion.Add(CentroInvestigacion3);

            return listaCentroInvestigacion;

        }

    }
}
