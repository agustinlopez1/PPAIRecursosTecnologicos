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
        private string imagen;
        private DateTime fechaAlta;
        private Modelo modelo; 
        private Marca marca;  
        private Estado estado;
        private TipoRecurso tipoRecurso;
       // private PersonalCientifico cientifico; // Ver
          //    private int numeroInventario;
    //    private int idTipoRecurso;
    //    private bool disponibilidad; // Ver
         //   private string caracteristica;
                // private string nombre;

        public RecursoTecnologico()
        {
        }

        public string Imagen { get => imagen; set => imagen = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public Marca Marca { get => marca; set => marca = value; }
        public Estado Estado { get => estado; set => estado = value; }
        public TipoRecurso TipoRecurso { get => TipoRecurso; set => TipoRecurso = value; }
//        public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }
//        public string Nombre { get => nombre; set => nombre = value; }
//        public string Caracteristica { get => caracteristica; set => caracteristica = value; }
//        public int NumeroInventario { get => numeroInventario; set => numeroInventario = value; }
//        public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
//        public int IdTipoRecurso { get => idTipoRecurso; set => idTipoRecurso = value; }

        public List<RecursoTecnologico> getRecursosTecnologicos()
        {
            List<RecursoTecnologico> listaRecursosTecnologicos = new List<RecursoTecnologico>();
            RecursoTecnologico recursoTecnologico1 = new RecursoTecnologico();

            TipoRecurso tipoRt = new TipoRecurso();
            List<TipoRecurso> listaTiposRt = tipoRt.getNombre();
            
            recursoTecnologico1.nroRT = 1;
            recursoTecnologico1.imagen = "imagen1";
            recursoTecnologico1.fechaAlta = DateTime.Now;
            recursoTecnologico1.tipoRecurso = listaTiposRt[0];
            //recursoTecnologico1.idTipoRecurso = 1;
            //recursoTecnologico1.estado = "";
            //recursoTecnologico1.cientifico = "";
            //recursoTecnologico1.numeroInventario = "";
            //recursoTecnologico1.disponibilidad = true;
            //recursoTecnologico1.marca = "";
            //recursoTecnologico1.nombre = "";
            //recursoTecnologico1.caracteristica = "caracteristica1";
            //recursoTecnologico1.nombre = "Balanza de precision ";

           listaRecursosTecnologicos.Add(recursoTecnologico1);


            return listaRecursosTecnologicos;

        }

        public List<RecursoTecnologico> esDeTipoRtSeleccionado(string tipoRtSeleccionado)
        {
            List<RecursoTecnologico> listaRecursosTecnologicos = getRecursosTecnologicos();

            foreach (RecursoTecnologico rt in listaRecursosTecnologicos)
            {
                if (rt.tipoRecurso.Nombre == tipoRtSeleccionado)
                {
                    List<RecursoTecnologico> listaRtTipoSelecc = new List<RecursoTecnologico>();
                    listaRtTipoSelecc.Add(rt);
                    
                }
            }

            return listaRecursosTecnologicos;

        }


    }
}
