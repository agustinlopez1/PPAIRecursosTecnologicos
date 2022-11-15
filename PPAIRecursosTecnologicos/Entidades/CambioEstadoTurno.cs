using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPAIRecursosTecnologicos.Entidades
{
    public class CambioEstadoTurno
    {
        private int idEstado;
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }


        public DataTable EsActual(string idTurno)
        {
            CambioEstadoTurnoDAO cambioEstadoBD = new CambioEstadoTurnoDAO();
            DataTable tablaCambioETurno = cambioEstadoBD.EsActual(idTurno);

            DataTable estadoTurnosActuales = new DataTable();

            Estado estado = new Estado();
            Utils util = new Utils();
            string idEstadoTurno = util.ObtenerIdEstado(tablaCambioETurno);
            bool fechaCambioEstadoTurno = util.ObtenerFechaCambioEstadoTurno(tablaCambioETurno);

            if (fechaCambioEstadoTurno == true)
            {
                estadoTurnosActuales = estado.getEstadoTurno(idEstadoTurno);
            }
            return estadoTurnosActuales;
        }
    }
}
