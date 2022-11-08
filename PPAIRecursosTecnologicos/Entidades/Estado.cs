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
        private string ambito;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ambito { get => ambito; set => ambito = value; }

        public List<Estado> getEstado()
        {
            List<Estado> listaEstado = new List<Estado>();

            Estado estado1 = new Estado();
            estado1.nombre = "dado de baja";
            estado1.ambito = "recurso tecnologico";
            listaEstado.Add(estado1);

            Estado estado2 = new Estado();
            estado2.nombre = "baja definitiva";
            estado2.ambito = "recurso tecnologico";
            listaEstado.Add(estado2);

            Estado estado3 = new Estado();
            estado3.nombre = "disponible";
            estado3.ambito = "turno";
            listaEstado.Add(estado3);

            Estado estado4 = new Estado();
            estado4.nombre = "en mantenimiento";
            estado4.ambito = "recurso tecnologico";
            listaEstado.Add(estado4);

            Estado estado5 = new Estado();
            estado5.nombre = "en inicio de mantenimiento correctivo";
            estado5.ambito = "recurso tecnologico";
            listaEstado.Add(estado5);

            Estado estado6 = new Estado();
            estado6.nombre = "con reserva pendiente de confirmacion";
            estado6.ambito = "turno";
            listaEstado.Add(estado6);

            Estado estado7 = new Estado();
            estado7.nombre = "reservado";
            estado7.ambito = "turno";
            listaEstado.Add(estado7);

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

        public Estado esAmbitoTurno()
        {
            List<Estado> listaEstados = getEstado();
            Estado estadoReservado;

            foreach(Estado estado in listaEstados)
            {
                if(estado.ambito == "turno")
                {
                    if(estado.nombre == "reservado")
                    {
                        estadoReservado = estado;
                        return estadoReservado;
                    }
                }
            }
            return null;
        }
    }
}
