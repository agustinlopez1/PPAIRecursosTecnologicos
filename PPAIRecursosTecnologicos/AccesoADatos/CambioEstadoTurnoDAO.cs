using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class CambioEstadoTurnoDAO
    {
        private int idEstado;
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;

        public int IdEstado { get => idEstado; set => idEstado = value; }
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }

        Acceso_base_dato _BD = new Acceso_base_dato();

        public DataTable EsActual(DataTable tablaTurnosDisponibles)
        {
            string sql = "buscar cambio de estado actual";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable getCambioEstadoTurno()
        {
            string sql = "buscar cambio de estado actual";
            return _BD.EjecutarSelect(sql);
        }
    }
}