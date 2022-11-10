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
