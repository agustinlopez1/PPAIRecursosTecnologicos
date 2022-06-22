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
            estado1.nombre = "dado de baja";
            listaEstado.Add(estado1);

            Estado estado2 = new Estado();
            estado2.nombre = "baja definitiva";
            listaEstado.Add(estado2);

            Estado estado3 = new Estado();
            estado3.nombre = "disponible";
            listaEstado.Add(estado3);

            Estado estado4 = new Estado();
            estado4.nombre = "en mantenimiento";
            listaEstado.Add(estado4);

            Estado estado5 = new Estado();
            estado5.nombre = "en inicio de mantenimiento correctivo";
            listaEstado.Add(estado5);

            return listaEstado;
        }

        public Boolean esReservable(string estadoActual)
        {
            if (estadoActual != "dado de baja" && estadoActual != "baja definitiva")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
