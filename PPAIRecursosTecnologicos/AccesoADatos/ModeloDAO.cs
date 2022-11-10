using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    public class ModeloDAO
    {
        public string pp_nombre { get; set; }

        Acceso_base_dato _BD = new Acceso_base_dato();

        //Usar para reportes
        public DataTable BuscarNombreModeloPorMarca()
        {
            string sql = "SELECT * FROM Modelo JOIN Marca ON Modelo.id = Marca.id";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarNombreModeloPorRt()
        {
            string sql = "SELECT * FROM Modelo JOIN RecursoTecnologico ON Modelo.id = RecursoTecnologico.id";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarNombreModeloPorRt()
        {
            string sql = "SELECT * FROM Modelo JOIN RecursoTecnologico ON Modelo.id = RecursoTecnologico.id";
            return _BD.EjecutarSelect(sql);
        }


        public DataTable BuscarModelos()
        {
            string sql = "SELECT * FROM Modelo";
            return _BD.EjecutarSelect(sql);
        }
    }
}