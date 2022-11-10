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

        public DataTable getCambioEstadoTurno()
        {
            CambioEstadoTurnoDAO cambiosEstadoTurnobd = new CambioEstadoTurnoDAO();
            DataTable tablaCambioEstadoTurno =  cambiosEstadoTurnobd.getCambioEstadoTurno();
            return tablaCambioEstadoTurno;
        }

        public DataTable EsActual(DataTable tablaTurnosDisponibles)
        {
            CambioEstadoTurnoDAO cambioEstadoBD = new CambioEstadoTurnoDAO();
            DataTable tablaCambioEstadoActual = cambioEstadoBD.EsActual(tablaTurnosDisponibles);

            Estado estado = new Estado();
            DataTable estadoTurnosActuales = estado.getEstadoTurno(tablaTurnosDisponibles);
            return estadoTurnosActuales;
        }

        public void setFechaHoraFin()
        {
            fechaHoraHasta = DateTime.Now;
        }

      //  public List<CambioEstadoTurno> New()
      //  {
      //      CambioEstadoTurno cambioEstadoTurno7 = new CambioEstadoTurno();

      //      List<CambioEstadoTurno> listaCambioEstadoTurno1 = new List<CambioEstadoTurno>();
      //      List<CambioEstadoTurno> listaCambioEstadoTurno2 = new List<CambioEstadoTurno>();
      //      (listaCambioEstadoTurno1, listaCambioEstadoTurno2) = getCambioEstadoTurno();

      //      Estado estado = new Estado();
      //      List<Estado> listaEstado = estado.getEstado();

      ////      cambioEstadoTurno7.estado = listaEstado[6];
      //      cambioEstadoTurno7.fechaHoraDesde = DateTime.Now;
      //      listaCambioEstadoTurno2.Add(cambioEstadoTurno7);

      //      return listaCambioEstadoTurno2;
      //  }

    }
}
