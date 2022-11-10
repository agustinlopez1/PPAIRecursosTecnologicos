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


        public DataTable getCentroInvestigacion()
        {
            CentroInvestigacionDAO centroInvestigacionbd = new CentroInvestigacionDAO();
            DataTable tablaCentroInvestigacion = centroInvestigacionbd.getCentroInvestigacion();
            return tablaCentroInvestigacion;
        }

        //public string getNombre(RecursoTecnologico rt)
        //{
        //    string nombreCentroInvestigacion = rt.CentroInvestigacion.nombre;

        //    return nombreCentroInvestigacion;
        //}

        public DataTable esAsignado(DataTable usuarioLogeado, DataTable tablaRTseleccionado)
        {
            AsignacionCientificoDeCentroInvestigacion asignacionCientificoDeCentroInvestigacion = new AsignacionCientificoDeCentroInvestigacion();
            CentroInvestigacionDAO centroInvestigacionbd = new CentroInvestigacionDAO();

            DataTable asignacionPersonalLogueado = asignacionCientificoDeCentroInvestigacion.esTuCientifico(usuarioLogeado);

            DataTable centroInvestigacionRtSeleccioando = centroInvestigacionbd.BuscarCentroInvestigacionRtSeleccionado(tablaRTseleccionado, asignacionPersonalLogueado);

            return centroInvestigacionRtSeleccioando;
        }

        //public void asignarTurno(Turno turnoSeleccionado, PersonalCientifico pesrsonalCientificoLogeado)
        //{
        //    asignacionCientificoDeCentroInvestigacion.setTurno(turnoSeleccionado, pesrsonalCientificoLogeado);
        //}
    }
}
