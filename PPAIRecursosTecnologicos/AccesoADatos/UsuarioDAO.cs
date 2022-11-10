using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class UsuarioDAO
    {
        private string nombre;
        private int clave;
        private int idUsuario;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Clave { get => clave; set => clave = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        
        Acceso_base_dato _BD = new Acceso_base_dato();

        public DataTable getUsuarioPorId(int id)
        {
            string sql = "SELECT * FROM usuario where id = " + id;
            return _BD.EjecutarSelect(sql);
        }


    }
}