using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Usuario
    {

        private string nombre;
        private int clave;
        private int idUsuario;
        //private bool habilitado;
        //private PersonalCientifico cientifico;

        public Usuario() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Clave { get => clave; set => clave = value; }

        public DataTable getUsuario(int id)
        {
            UsuarioDAO usuariobd = new UsuarioDAO();
            DataTable tablaUsuarios = usuariobd.getUsuarioPorId(id);
            return tablaUsuarios;
        }
    }
}
