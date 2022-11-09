using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class TipoRecursoTecnologicoDAO
    {
        private int idTipoRecurso;
        private string nombre;
        private string descripcion;

        public int IdTipoRecurso { get => idTipoRecurso; set => idTipoRecurso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        Acceso_base_dato _BD = new Acceso_base_dato();

        //Usar para reportes
        public DataTable BuscarNombreTipoRecursos()
        {
            string sql = "SELECT nombre FROM TipoRecurso";
            return _BD.EjecutarSelect(sql);
        }
    }
}
