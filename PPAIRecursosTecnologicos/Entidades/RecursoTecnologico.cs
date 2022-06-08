using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class RecursoTecnologico
    {
        private string nombre;
        private string imagen;
        private string caracteristica;
        private DateTime fechaAlta;
        private int numeroInventario;
        private bool disponibilidad; // VERRR
        private Modelo modelo; 
        private Marca marca;  
        private TipoRecurso tipoRecurso;
        private Estado estado;
        private Cientifico cientifico; // VERRR

        public RecursoTecnologico()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public string Caracteristica { get => caracteristica; set => caracteristica = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public int NumeroInventario { get => numeroInventario; set => numeroInventario = value; }
        public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public Marca Marca { get => marca; set => marca = value; }
        public TipoRecurso TipoRecurso { get => tipoRecurso; set => tipoRecurso = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public Cientifico Cientifico { get => cientifico; set => cientifico = value; }

    }
}
