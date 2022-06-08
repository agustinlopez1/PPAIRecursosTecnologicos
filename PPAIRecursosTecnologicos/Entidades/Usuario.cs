using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private Cientifico cientifico;

        public Usuario(){}

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Cientifico Cientifico { get => cientifico; set => cientifico = value; }
    }
}
