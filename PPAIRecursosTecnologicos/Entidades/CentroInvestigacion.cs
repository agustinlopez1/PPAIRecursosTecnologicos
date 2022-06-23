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
        private AsignacionCientificoDeCentroInvestigacion asignacionCientificoDeCentroInvestigacion;
        public CentroInvestigacion() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public AsignacionCientificoDeCentroInvestigacion AsignacionCientificoDeCentroInvestigacion { get => asignacionCientificoDeCentroInvestigacion; set => asignacionCientificoDeCentroInvestigacion = value; }

        public List<CentroInvestigacion> getCentroInvestigacion()
        {

            List<CentroInvestigacion> listaCentroInvestigacion = new List<CentroInvestigacion>();

            AsignacionCientificoDeCentroInvestigacion asignacionCientificoDeCentroInvestigacion = new AsignacionCientificoDeCentroInvestigacion();
            AsignacionCientificoDeCentroInvestigacion asignacionCientifico = asignacionCientificoDeCentroInvestigacion.getAsignacionCientificoDeCentroInvestigacion();

            CentroInvestigacion CentroInvestigacion1 = new CentroInvestigacion();
            CentroInvestigacion1.nombre = "Centro Investigacion uno";
            CentroInvestigacion1.asignacionCientificoDeCentroInvestigacion = asignacionCientifico;
            listaCentroInvestigacion.Add(CentroInvestigacion1);


            CentroInvestigacion CentroInvestigacion2 = new CentroInvestigacion();
            CentroInvestigacion2.nombre = "Centro Investigacion dos";
            CentroInvestigacion2.asignacionCientificoDeCentroInvestigacion = asignacionCientifico;
            listaCentroInvestigacion.Add(CentroInvestigacion2);

            CentroInvestigacion CentroInvestigacion3 = new CentroInvestigacion();
            CentroInvestigacion3.nombre = "Centro Investigacion tres";
            CentroInvestigacion3.asignacionCientificoDeCentroInvestigacion = asignacionCientifico;
            listaCentroInvestigacion.Add(CentroInvestigacion3);

            return listaCentroInvestigacion;

        }

        public string getNombre(RecursoTecnologico rt)
        {
            string nombreCentroInvestigacion = rt.CentroInvestigacion.nombre;

            return nombreCentroInvestigacion;
        }


        public bool esAsignado(Usuario usuario)
        {
            AsignacionCientificoDeCentroInvestigacion asignacionCientificoDeCentroInvestigacion = new AsignacionCientificoDeCentroInvestigacion();
            return asignacionCientificoDeCentroInvestigacion.esTuCientifico(usuario);
        }
    }
}
