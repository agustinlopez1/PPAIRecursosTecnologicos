using PPAIRecursosTecnologicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class CambioEstadoDAO
    {
        private Estado estado;
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;

        public Estado Estado { get => estado; set => estado = value; }
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }


        Acceso_base_dato _BD = new Acceso_base_dato();

        //Usar para reportes
        public DataTable BuscarCambioEstadoRTActual(DataTable listaRTdeTipoRT)
        {
            string sql = "SELECT * FROM cambioEstado WHERE FechaHoraHasta = null and UNIR TABLA DE RT CON TABLA DE CAMBIO ESTADO Y BUSCAR CUAL ES ACTUAL Y RESERVABLE";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarCambioEstadoRTActualReservable(DataTable tablaRtActuales)
        {
            string sql = "SELECT * FROM cambioEstado WHERE FechaHoraHasta = null and UNIR TABLA DE RT CON TABLA DE CAMBIO ESTADO Y BUSCAR CUAL ES ACTUAL Y RESERVABLE";
            return _BD.EjecutarSelect(sql);
        }
    }
}
