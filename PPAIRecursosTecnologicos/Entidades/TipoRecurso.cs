using System;
using System.Collections.Generic;
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

        public TipoRecurso(){}

        public int IdTipoRecurso { get => idTipoRecurso; set => idTipoRecurso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

    }
}
