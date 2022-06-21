using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Estado
    {
        private string nombre;

        public string Nombre { get => nombre; set => nombre = value; }

        public List<Estado> getEstado()
        {
            List<Estado> listaEstado = new List<Estado>();

            Estado estado1 = new Estado();
            estado1.nombre = "esReservable";
            listaEstado.Add(estado1);

            Estado estado2 = new Estado();
            estado2.nombre = "estado 2";
            listaEstado.Add(estado2);

            Estado estado3 = new Estado();
            estado3.nombre = "estado 3";
            listaEstado.Add(estado3);

            Estado estado4 = new Estado();
            estado4.nombre = "estado 4";
            listaEstado.Add(estado4);

            Estado estado5 = new Estado();
            estado5.nombre = "estado 5";
            listaEstado.Add(estado5);

            Estado estado6 = new Estado();
            estado6.nombre = "estado 6";
            listaEstado.Add(estado6);

            return listaEstado;
        }

        public Boolean esReservable(string estadoActual)
        {
            if (estadoActual == "esReservable")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string getNombre(CambioEstadoRT rt)
        {
            return rt.Estado.Nombre;
        }
    }
}
