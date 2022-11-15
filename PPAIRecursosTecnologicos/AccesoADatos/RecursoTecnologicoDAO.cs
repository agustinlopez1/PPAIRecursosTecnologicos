using PPAIRecursosTecnologicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    public class RecursoTecnologicoDAO
    {
        private string nombre;
        private int numeroRT;
        private TipoRecurso tipoRecurso;

        public string Nombre { get => nombre; set => nombre = value; }
        public TipoRecurso TipoRecurso { get => TipoRecurso; set => TipoRecurso = value; }
        public int NumeroRT { get => numeroRT; set => numeroRT = value; }


        Acceso_base_dato _BD = new Acceso_base_dato();

        //Usar para reportes
        public DataTable BuscarNombre(object nombre)
        {
            string sql = "SELECT * FROM PersonalCientifico WHERE nombre = '" + nombre + "'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarRtPorTipo(string nombreRecursoSeleccionado)
        {
            string sql = "select rt.* FROM RecursoTecnologico rt JOIN tipoRecurso trt ON rt.idTipoRecurso = trt.id where trt.nombre = '" + nombreRecursoSeleccionado + "'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable getRecursosTecnologicosPorNumero(DataTable tablaRtActualesReservable)
        {
            string sql = "buscar tabla completa de rt haciendo un join con la tabla rt acutales y reservables";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable getRecursosTecnologicos(string nombreRecursoSeleccionado)
        {
            string sql = "select * from RecursoTecnologico where nombre = '" + nombreRecursoSeleccionado + "'";
            return _BD.EjecutarSelect(sql);
        }
    }
}
