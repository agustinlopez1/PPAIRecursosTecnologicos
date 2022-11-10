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
            string sql = "Select * from CambioEstadoRT crt JOIN " + listaRTdeTipoRT + " rt on rt.idCambioEstadoRT = crt.id";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarCambioEstadoRTActualReservable(DataTable tablaRtActuales)
        {
            string sql = "select * from Estado e join " + tablaRtActuales + " rt where e.id = rt.idEstado";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarCambioEstadoActual(List<RecursoTecnologico> listaRTdeTipoRT)
        {
            string idCambioEstado = " ";

            foreach (RecursoTecnologico crt in listaRTdeTipoRT)
            {
                 idCambioEstado = crt.IdCambioEstadoRT.ToString();
            }

            string sql = "Select e.nombre from CambioEstadoRT crt join Estado e on crt.idEstado = e.id where crt.id =" + idCambioEstado;
            return _BD.EjecutarSelect(sql);
        }
    }
}
