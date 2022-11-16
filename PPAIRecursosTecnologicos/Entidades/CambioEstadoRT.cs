using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPAIRecursosTecnologicos.Entidades
{
    public class CambioEstadoRT
    {
        private int idEstado;
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }

        public DataTable EsActual(DataTable listaRTdeTipoRT)
        {
            CambioEstadoDAO cambioEstadoBD = new CambioEstadoDAO();
            DataTable tablaRtActuales = cambioEstadoBD.BuscarCambioEstadoRTActual(listaRTdeTipoRT);
            DataTable tablaRtActualesReservable = esReservable(tablaRtActuales);
            return tablaRtActualesReservable;
        }


        public DataTable esReservable(DataTable tablaRtActuales)
        {
            CambioEstadoDAO cambioEstadoBD = new CambioEstadoDAO();
            DataTable tablaRtActualesReservable = cambioEstadoBD.BuscarCambioEstadoRTActualReservable(tablaRtActuales);
            return tablaRtActualesReservable;
        }

    }
}
