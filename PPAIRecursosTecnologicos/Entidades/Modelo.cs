using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Modelo
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }


        public List<Modelo> getModelo()
        {
            List<Modelo> listaModelo = new List<Modelo>();

            Modelo modelo1 = new Modelo();
            modelo1.nombre = "modelo 1";
            listaModelo.Add(modelo1);

            Modelo modelo2 = new Modelo();
            modelo2.nombre = "modelo 2";
            listaModelo.Add(modelo2);

            Modelo modelo3 = new Modelo();
            modelo3.nombre = "modelo 3";
            listaModelo.Add(modelo3);


            return listaModelo;
        }

        public (string,string) getMarcaModelo(RecursoTecnologico rt)
        {
            Marca marca = new Marca();

            string nombreModelo = " ";
            string nombreMarca = " ";

            nombreMarca = marca.getNombre(rt);
            nombreModelo = rt.Modelo.nombre;

            return (nombreMarca, nombreModelo);
        }

    }

}
