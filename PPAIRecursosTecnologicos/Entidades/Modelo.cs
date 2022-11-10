using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Modelo
    {
        private int idModelo;
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }


        //public List<Modelo> getModelo()
        //{
        //    List<Modelo> listaModelo = new List<Modelo>();

        //    Modelo modelo1 = new Modelo();
        //    modelo1.nombre = "modelo 1";
        //    listaModelo.Add(modelo1);

        //    Modelo modelo2 = new Modelo();
        //    modelo2.nombre = "modelo 2";
        //    listaModelo.Add(modelo2);

        //    Modelo modelo3 = new Modelo();
        //    modelo3.nombre = "modelo 3";
        //    listaModelo.Add(modelo3);


        //    return listaModelo;
        //}

        //public (string,string) getMarcaModelo(RecursoTecnologico rt)
        //{
        //    Marca marca = new Marca();

        //    string nombreModelo = " ";
        //    string nombreMarca = " ";

        // nombreMarca = marca.getNombre(rt);
        //    nombreModelo = rt.Modelo.nombre;

        //    return (nombreMarca, nombreModelo);
        //}


        public DataTable getMarcaModelo(RecursoTecnologico rt)
        {
            ModeloDAO modelo = new ModeloDAO();
            DataTable tabla = modelo.BuscarNombreModeloPorMarca();
            return tabla;
        }

        public DataTable getModelo()
        {
            ModeloDAO modelo = new ModeloDAO();
            DataTable tabla = modelo.BuscarModelos();
            return tabla;
        }
    }

}
