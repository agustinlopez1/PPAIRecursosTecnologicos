using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Marca
    {
        private string nombre;
        private Modelo modelo;

        public Marca(){}

        public string Nombre { get => nombre; set => nombre = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }

        public List<Marca> getMarca()
        {
            Modelo modelo = new Modelo();
            List<Modelo> listaModelo = modelo.getModelo();    

            List<Marca> listaMarca = new List<Marca>();

            Marca marca1 = new Marca();
            marca1.nombre = "marca 1";
            marca1.modelo = listaModelo[0];
            listaMarca.Add(marca1);

            Marca marca2 = new Marca();
            marca2.nombre = "marca 2";
            marca2.modelo = listaModelo[1];
            listaMarca.Add(marca2);

            Marca marca3 = new Marca();
            marca3.nombre = "marca 3";
            marca3.modelo = listaModelo[2];
            listaMarca.Add(marca3);

            return listaMarca;
        }

        public string getNombre(RecursoTecnologico rt)
        {
            string nombreMarca = " ";
            List<Marca> listaMarca = getMarca();

            foreach (Marca marca in listaMarca)
            {
                if (rt.Modelo.Nombre == marca.Modelo.Nombre)
                {
                    nombreMarca = marca.nombre;
                }
            }
            return nombreMarca;
        }
    }
}
