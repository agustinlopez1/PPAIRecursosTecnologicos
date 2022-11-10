using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class CentroInvestigacion
    {
        private int idCentroInvestigacion;
        private string nombre;
        private int idAsignacionCientificoCI;
        public CentroInvestigacion() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdAsignacionCientificoCI { get => idAsignacionCientificoCI; set => idAsignacionCientificoCI = value; }
        public int IdCentroInvestigacion { get => idCentroInvestigacion; set => idCentroInvestigacion = value; }


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


        //public (bool, PersonalCientifico) esAsignado(Usuario usuario)
        //{
        //    Boolean bandera;
        //    PersonalCientifico logeadoCientifico;

        //    AsignacionCientificoDeCentroInvestigacion asignacionCientificoDeCentroInvestigacion = new AsignacionCientificoDeCentroInvestigacion();
        //    (bandera, logeadoCientifico) = asignacionCientificoDeCentroInvestigacion.esTuCientifico(usuario);

        //    return (bandera, logeadoCientifico);
        //}

        public DataTable esAsignado(DataTable usuarioLogeado, DataTable tablaRTseleccionado)
        {
            AsignacionCientificoDeCentroInvestigacion asignacionCientificoDeCentroInvestigacion = new AsignacionCientificoDeCentroInvestigacion();
            CentroInvestigacionDAO centroInvestigacionbd = new CentroInvestigacionDAO();

            DataTable asignacionPersonalLogueado = asignacionCientificoDeCentroInvestigacion.esTuCientifico(usuarioLogeado);

            DataTable centroInvestigacionRtSeleccioando = centroInvestigacionbd.BuscarCentroInvestigacionRtSeleccionado(tablaRTseleccionado, asignacionPersonalLogueado);

            return centroInvestigacionRtSeleccioando;
        }

        public void asignarTurno(Turno turnoSeleccionado, PersonalCientifico pesrsonalCientificoLogeado)
        {
            asignacionCientificoDeCentroInvestigacion.setTurno(turnoSeleccionado, pesrsonalCientificoLogeado);
        }
    }
}
