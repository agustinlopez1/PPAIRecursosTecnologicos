﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Usuario
    {

        private string nombre;
        private int clave;
        //private int idUsuario;
        //private bool habilitado;
        //private PersonalCientifico cientifico;

        public Usuario(){}

        public string Nombre { get => nombre; set => nombre = value; }
        public int Clave { get => clave; set => clave = value; }
        //public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }
        //public int IdUsuario { get => idUsuario; set => idUsuario = value; }


        //public PersonalCientifico getPersonalCientifico()
        //{
        //    return cientifico.generarPersonalCientifico() ;
        //}

        public List<Usuario> ListaUsuario()
        {
            List<Usuario> listaUsuario = new List<Usuario>();

            Usuario usuario1 = new Usuario();
            usuario1.nombre = "joseflores";
            usuario1.clave = 1234;
            listaUsuario.Add(usuario1);

            Usuario usuario2 = new Usuario();
            usuario2.nombre = "matias";
            usuario2.clave = 0000;
            listaUsuario.Add(usuario2);

            Usuario usuario3 = new Usuario();
            usuario3.nombre = "lucas";
            usuario3.clave = 1111;
            listaUsuario.Add(usuario3);

            return listaUsuario;
        }

        //public PersonalCientifico getCientifico()
        //{
        //    PersonalCientifico personalCientifico = new PersonalCientifico();
        //    personalCientifico.get
        //}
    }
}
