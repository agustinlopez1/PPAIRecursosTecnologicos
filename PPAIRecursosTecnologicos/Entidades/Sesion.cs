using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Sesion
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private Usuario usuario;

        public Sesion() { }

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public Usuario Usuario { get => usuario; set => usuario = value; }


        public Sesion getCientificoLogueado(int id)
        {

            Usuario usuario = new Usuario();

            Sesion sesion = new Sesion();
            sesion.fechaHoraInicio = DateTime.Now;
            sesion.usuario = usuario.getUsuario(id);

            //Sesion ListaSesion2 = new Sesion();
            //ListaSesion2.fechaHoraInicio = new DateTime(2022, 6, 1, 8, 30, 52);
            //ListaSesion2.usuario = listaUsuario[1];
            //listaSesion.Add(ListaSesion2);

            //Sesion ListaSesion3 = new Sesion();
            //ListaSesion3.fechaHoraInicio = new DateTime(2022, 5, 1, 8, 30, 52);
            //ListaSesion3.usuario = listaUsuario[2];
            //listaSesion.Add(ListaSesion3);

            return sesion;

        }
    }
}
