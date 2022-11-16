using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Marca
    {
        private int idMarca;
        private string nombre;
        private Modelo modelo;

        public Marca(){}
        public string Nombre { get => nombre; set => nombre = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public int IdMarca { get => idMarca; set => idMarca = value; }


    }
}
