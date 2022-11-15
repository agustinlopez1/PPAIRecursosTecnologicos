using PPAIRecursosTecnologicos.Entidades;
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

        public DataTable getCentroInvestigacion()
        {
            string sql = "select * from CentroInvestigacion";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarCentroInvestigacion(List<RecursoTecnologico> listaRTdeTipoRT)
        {
            string idCentroInvestigacion = " ";

            foreach (RecursoTecnologico cinv in listaRTdeTipoRT)
            {
                idCentroInvestigacion = cinv.IdCentroInvestigacion.ToString();
            }

            string sql = "Select nombre from CentroInvestigacion where id = " + idCentroInvestigacion;
            return _BD.EjecutarSelect(sql);
        }

        public void asignarTurno(int nuevoIdAc)
        {
            string sql = "INSERT INTO CentroInvestigacion Values ('centro investigacion uno', "+ nuevoIdAc + ")";
            _BD.EjecutarInsert(sql);
        }
    }
}
