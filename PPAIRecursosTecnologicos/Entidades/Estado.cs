using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class Estado
    {
        private string nombre;
        private string ambito;
        private int id;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ambito { get => ambito; set => ambito = value; }
        public int Id { get => id; set => id = value; }

        public List<Estado> getEstado()
        {
            EstadoDAO estadobd = new EstadoDAO();
            DataTable tablaEstados = estadobd.getEstado();

            Utils util = new Utils();
            List<Estado> listaEstados = util.ObtenerTablaEstado(tablaEstados);
            return listaEstados;
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

        public int esAmbitoTurno()
        {
            List<Estado> listaEstados = getEstado();
            int estadoReservado = -1;

            foreach (Estado estado in listaEstados)
            {
                if (estado.ambito == "turno")
                {
                    if (estado.nombre == "reservado")
                    {
                        estadoReservado = estado.id;
                        return estadoReservado;
                    }
                }
            }
            return estadoReservado;
        }

        public DataTable getEstadoTurno(string idEstadoTurno)
        {
            TurnoDAO turnobd = new TurnoDAO();
            DataTable estadoTurnosActuales = turnobd.BuscarEstadoPorCambioEstado(idEstadoTurno);
            return estadoTurnosActuales;
        }
    }
}
