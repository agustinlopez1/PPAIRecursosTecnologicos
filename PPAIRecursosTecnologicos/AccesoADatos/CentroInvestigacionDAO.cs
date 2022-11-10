using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class CentroInvestigacionDAO
    {
        private string nombre;
        private int idAsignacionCientifico;
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdAsignacionCientifico { get => idAsignacionCientifico; set => idAsignacionCientifico = value; }

        Acceso_base_dato _BD = new Acceso_base_dato();

        //Usar para reportes
        public DataTable BuscarCentroInvestigacionRtSeleccionado(DataTable tablaRTseleccionado, DataTable asignacionPersonalLogueado)
        {
            string sql = "SELECT * FROM centroInvestigacion where idrt = "+ tablaRTseleccionado+  "y tiene la asigancion encontrada";
            return _BD.EjecutarSelect(sql);
        }

    }
}
