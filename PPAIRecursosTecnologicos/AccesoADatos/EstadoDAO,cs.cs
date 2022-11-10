using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class EstadoDAO
    {
        private string nombre;
        private string ambito;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ambito { get => ambito; set => ambito = value; }

        Acceso_base_dato _BD = new Acceso_base_dato();

        //Usar para reportes
        public DataTable getEstado()
        {
            string sql = "SELECT * FROM Estado";
            return _BD.EjecutarSelect(sql);
        }
    }
}
