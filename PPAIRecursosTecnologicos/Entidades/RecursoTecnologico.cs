using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class RecursoTecnologico
    {
        private int nroRT;
        private string nombre;
        private string imagen;
        private string caracteristica;
        private DateTime fechaAlta;
        private int numeroInventario;
        private int idTipoRecurso;
        private bool disponibilidad; // Ver
        private Modelo modelo; 
        private Marca marca;  
        private Estado estado;
        private PersonalCientifico cientifico; // Ver

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
        public int IdTipoRecurso { get => idTipoRecurso; set => idTipoRecurso = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }

        public List<RecursoTecnologico> getRecursosTecnologicos()
        {
            List<RecursoTecnologico> listaRecursosTecnologicos = new List<RecursoTecnologico>();

            // Recurso Tecnologico 1 - Balanza de precisión
            //RecursoTecnologico recursoTecnologico1 = new RecursoTecnologico();
            //recursoTecnologico1.nroRT = 1;
            //recursoTecnologico1.nombre = " ";
            //recursoTecnologico1.imagen = " ";
            //recursoTecnologico1.caracteristica = " ";
            //recursoTecnologico1.fechaAlta = "";
            //recursoTecnologico1.numeroInventario = "";
            //recursoTecnologico1.disponibilidad = "";
            //recursoTecnologico1.marca = "";
            //recursoTecnologico1.idTipoRecurso = 1;
            //recursoTecnologico1.estado = "";
            //recursoTecnologico1.cientifico = "";
            //recursoTecnologico1.nombre = "";












            return listaRecursosTecnologicos;

        }




    }
}
