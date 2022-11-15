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

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ambito { get => ambito; set => ambito = value; }

        public DataTable getEstado()
        {
            EstadoDAO estadobd = new EstadoDAO();
            DataTable tablaEstados = estadobd.getEstado();
            return tablaEstados;
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
            DataTable listaEstados = getEstado();
            Estado estadoReservado;

            //foreach (Estado estado in listaEstados)
            //{
            //    if (estado.ambito == "turno")
            //    {
            //        if (estado.nombre == "reservado")
            //        {
            //            estadoReservado = estado;
            //            return estadoReservado;
            //        }
            //    }
            //}
            return null;
        }

        public DataTable getEstadoTurno(string idEstadoTurno)
        {
            TurnoDAO turnobd = new TurnoDAO();
            DataTable estadoTurnosActuales = turnobd.BuscarEstadoPorCambioEstado(idEstadoTurno);
            return estadoTurnosActuales;
        }
    }
}
