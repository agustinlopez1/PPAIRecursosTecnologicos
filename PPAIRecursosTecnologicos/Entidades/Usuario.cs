using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private int clave;
        private bool habilitado;
        private PersonalCientifico cientifico;

        public Usuario(){}

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Clave { get => clave; set => clave = value; }
        public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }

        //public PersonalCientifico getPersonalCientifico()
        //{
        //    return cientifico.generarPersonalCientifico() ;
        //}

        //public Usuario generarUsuario()
        //{
        //    Usuario usuario1 = new Usuario();

        //    usuario1.idUsuario = 1;
        //    usuario1.nombre = "joseflores";
        //    usuario1.clave = 1234;
        //    usuario1.cientifico = getPersonalCientifico();

        //    return usuario1;
        //}

        //public PersonalCientifico getCientifico()
        //{
        //    PersonalCientifico personalCientifico = new PersonalCientifico();
        //    personalCientifico.get
        //}
    }
}
