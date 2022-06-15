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
        private List<TipoRecurso> listaTipoRecursos;

        public TipoRecurso(){}

        public int IdTipoRecurso { get => idTipoRecurso; set => idTipoRecurso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public List<TipoRecurso> ListaTipoRecursos { get => listaTipoRecursos; set => listaTipoRecursos = value; }


        // Creo objetos "Tipo de Recurso Tecnologico", los agrego a una lista y la retorno.
        public List<TipoRecurso> generarTipoRecursos()
        {
            this.listaTipoRecursos = new List<TipoRecurso>();

            //Tipo Recurso 1 - Balanza de precisión
            TipoRecurso tipoRecurso1 = new TipoRecurso();
            tipoRecurso1.idTipoRecurso = 1;
            tipoRecurso1.nombre = "Balanza de precisión";
            tipoRecurso1.descripcion = " Capacidad: 620 g " + "Indicación mínima: 0.01 g" + "Repetitividad: menor o igual a 0.01 g" + "Linealidad: 0.02 g" + "Linealidad: 0.02 g" + "Linealidad: 0.02 g" + "Tiempo de respuesta: 2.0 segundos." + "Monitor: LCD con luz negra." + "Dimensiones del plato de la balanza: 110 mm de diámetro." + "Peso del equipo: 1.55 kg";

            //Agrego tipo de recurso a la lista
            listaTipoRecursos.Add(tipoRecurso1);

            //Tipo Recurso 2 - Microscopio de medición
            TipoRecurso tipoRecurso2 = new TipoRecurso();
            tipoRecurso2.idTipoRecurso = 2;
            tipoRecurso2.nombre = "Microscopio de medición";
            tipoRecurso2.descripcion = "Contador con lectura: 0.1μm " + " Pantalla LCD: 320x240 píxeles " + "Velocidad de enfoque: 0.5 segundos" + "Repetibilidad de enfoque: hasta 0.5 μm" + "Velocidad de movimiento vertical: 10 mm / seg." + "Platina: 12 X 6";

            listaTipoRecursos.Add(tipoRecurso2);

            //Tipo Recurso 3 - Resonador Magnético
            TipoRecurso tipoRecurso3 = new TipoRecurso();
            tipoRecurso3.idTipoRecurso = 3;
            tipoRecurso3.nombre = "Resonador Magnetico";
            tipoRecurso3.descripcion = " ";

            listaTipoRecursos.Add(tipoRecurso3);

            return listaTipoRecursos;

        }

    }
}
