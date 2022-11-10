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

        public TipoRecurso() { }

        // Creo objetos "Tipo de Recurso Tecnologico", los agrego a una lista y la retorno.
        //public List<TipoRecurso> ListaTipoRecursos()
        //{
        //    List<TipoRecurso> listaTipoRecursos = new List<TipoRecurso>();

        //    //Tipo Recurso 1 - Balanza de precisión
        //    TipoRecurso tipoRecurso1 = new TipoRecurso();
        //    tipoRecurso1.idTipoRecurso = 1;
        //    tipoRecurso1.nombre = "Balanza de precisión";
        //    tipoRecurso1.descripcion = " Capacidad: 620 g " + "Indicación mínima: 0.01 g" + "Repetitividad: menor o igual a 0.01 g" + "Linealidad: 0.02 g" + "Linealidad: 0.02 g" + "Linealidad: 0.02 g" + "Tiempo de respuesta: 2.0 segundos." + "Monitor: LCD con luz negra." + "Dimensiones del plato de la balanza: 110 mm de diámetro." + "Peso del equipo: 1.55 kg";

        //    //Agrego tipo de recurso a la lista
        //    listaTipoRecursos.Add(tipoRecurso1);

        //    //Tipo Recurso 2 - Microscopio de medición
        //    TipoRecurso tipoRecurso2 = new TipoRecurso();
        //    tipoRecurso2.idTipoRecurso = 2;
        //    tipoRecurso2.nombre = "Microscopio de medición";
        //    tipoRecurso2.descripcion = "Contador con lectura: 0.1μm " + " Pantalla LCD: 320x240 píxeles " + "Velocidad de enfoque: 0.5 segundos" + "Repetibilidad de enfoque: hasta 0.5 μm" + "Velocidad de movimiento vertical: 10 mm / seg." + "Platina: 12 X 6";

        //    listaTipoRecursos.Add(tipoRecurso2);

        //    //Tipo Recurso 3 - Resonador Magnético
        //    TipoRecurso tipoRecurso3 = new TipoRecurso();
        //    tipoRecurso3.idTipoRecurso = 3;
        //    tipoRecurso3.nombre = "Resonador Magnetico";
        //    tipoRecurso3.descripcion = "Contador con lectura: 0.1μm";

        //    listaTipoRecursos.Add(tipoRecurso3);

        //    return listaTipoRecursos;

        //}

        //public List<string> getNombre()
        //{
        //    List<string> listaNombresTipoRecurso = new List<string>();
        //    List<TipoRecurso> listaTR = ListaTipoRecursos();


        //    foreach (TipoRecurso tipo in listaTR)
        //    {
        //        listaNombresTipoRecurso.Add(tipo.Nombre);
        //    }
           
        //    return listaNombresTipoRecurso;
        //}

        public DataTable getNombre()
        {
            DataTable tabla = new DataTable();
            TipoRecursoTecnologicoDAO tipoRecursoTeconologico = new TipoRecursoTecnologicoDAO();
            
            tabla = tipoRecursoTeconologico.BuscarNombreTipoRecursos();

            return tabla;
        }

        public DataTable getTipoRecurso()
        {
            DataTable tabla = new DataTable();
            TipoRecursoTecnologicoDAO tipoRecursoTeconologico = new TipoRecursoTecnologicoDAO();

            tabla = tipoRecursoTeconologico.BuscarTipoRecursos();

            return tabla;
        }

    }

}
