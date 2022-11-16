using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class TipoRecurso
    {
        private int idTipoRecurso;
        private string nombre;
        private string descripcion;

        public int IdTipoRecurso { get => idTipoRecurso; set => idTipoRecurso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        public TipoRecurso() { }

        public DataTable getNombre()
        {
            DataTable tabla = new DataTable();
            TipoRecursoTecnologicoDAO tipoRecursoTeconologico = new TipoRecursoTecnologicoDAO();
            
            tabla = tipoRecursoTeconologico.BuscarNombreTipoRecursos();

            return tabla;
        }
    }

}
