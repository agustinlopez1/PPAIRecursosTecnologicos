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

        public (List<CambioEstadoRT>, List<CambioEstadoRT>) getCambioEstadoRT()
        {
            Estado estado = new Estado();
            List<Estado> listaEstado = estado.getEstado();

        //PRIMERA LISTA DE CAMBIO DE ESTADOS
            List<CambioEstadoRT> listaCambioEstadoRT1 = new List<CambioEstadoRT>();

            //NO ES RESERVABLE YA QUE TIENE HORA HASTA > HORA ACTUAL
            CambioEstadoRT cambioEstadoRT1 = new CambioEstadoRT();
            cambioEstadoRT1.estado = listaEstado[0];
            cambioEstadoRT1.fechaHoraDesde = DateTime.Now;
            cambioEstadoRT1.fechaHoraHasta = new DateTime(2022, 9, 1, 8, 30, 52);
            listaCambioEstadoRT1.Add(cambioEstadoRT1);

            //NO ES RESERVABLE XQ TIENE EL ESTADO "BAJA DEFINITIVA" y TIENE HORA HASTA > HORA ACTUAL
            CambioEstadoRT cambioEstadoRT2 = new CambioEstadoRT();
            cambioEstadoRT2.estado = listaEstado[1];
            cambioEstadoRT2.fechaHoraDesde = new DateTime(2022, 5, 1, 8, 30, 52);
            cambioEstadoRT2.fechaHoraHasta = new DateTime(2022, 10, 1, 8, 30, 52);
            listaCambioEstadoRT1.Add(cambioEstadoRT2);

            //ES RESERVABLE PORQUE CUMPLE CON FECHA Y HORARIO
            CambioEstadoRT cambioEstadoRT3 = new CambioEstadoRT();
            cambioEstadoRT3.estado = listaEstado[2];
            cambioEstadoRT3.fechaHoraDesde = new DateTime(2022, 3, 1, 8, 30, 52);
            cambioEstadoRT3.fechaHoraHasta = new DateTime(2022, 4, 1, 8, 30, 52);
            listaCambioEstadoRT1.Add(cambioEstadoRT3);

         //SEGUNDA LISTA DE CAMBIO DE ESTADOS
            List<CambioEstadoRT> listaCambioEstadoRT2 = new List<CambioEstadoRT>();

            //NO ES RESERVABLE YA QUE TIENE HORA HASTA > HORA ACTUAL
            CambioEstadoRT cambioEstadoRT4 = new CambioEstadoRT();
            cambioEstadoRT4.estado = listaEstado[0];
            cambioEstadoRT4.fechaHoraDesde = DateTime.Now;
            cambioEstadoRT4.fechaHoraHasta = new DateTime(2022, 9, 1, 8, 30, 52);
            listaCambioEstadoRT2.Add(cambioEstadoRT4);

            //ES RESERVABLE PORQUE CUMPLE CON FECHA Y HORARIO
            CambioEstadoRT cambioEstadoRT6 = new CambioEstadoRT();
            cambioEstadoRT6.estado = listaEstado[3];
            cambioEstadoRT6.fechaHoraDesde = new DateTime(2022, 3, 1, 8, 30, 52);
            cambioEstadoRT6.fechaHoraHasta = new DateTime(2022, 4, 1, 8, 30, 52);
            listaCambioEstadoRT2.Add(cambioEstadoRT6);

            return (listaCambioEstadoRT1, listaCambioEstadoRT2);

        }

        //public (Boolean, Boolean, List<String>) EsActual(RecursoTecnologico rt, List<String> listaEstados)
        //{
        //    Boolean esActual = false;
        //    Boolean reservable = false;
        //    DateTime fechaActual = DateTime.Now;


        //    foreach (CambioEstadoRT cambioEstado in rt.CambioEstadoRT)
        //    {
        //        if (cambioEstado.fechaHoraHasta < fechaActual)
        //        {
        //            reservable = esReservable(cambioEstado);
        //            esActual = true;
        //            listaEstados.Add(cambioEstado.Estado.Nombre);

        //        }
        //        else
        //        {
        //            esActual = false;
        //        }
        //    }
        //    return (esActual, reservable, listaEstados);
        //}

        public DataTable EsActual(DataTable listaRTdeTipoRT)
        {
            CambioEstadoDAO cambioEstadoBD = new CambioEstadoDAO();
            DataTable tablaRtActuales = cambioEstadoBD.BuscarCambioEstadoRTActual(listaRTdeTipoRT);
            DataTable tablaRtActualesReservable = esReservable(tablaRtActuales);
            return tablaRtActualesReservable;
        }

        //public DataTable esReservable(DataTable tablaRtActuales)
        //{
        //    Estado estado = new Estado();
        //    Boolean esReservable = estado.esReservable(cambioEstado.estado.Nombre);
        //    return esReservable;
        //}

        public DataTable esReservable(DataTable tablaRtActuales)
        {
            CambioEstadoDAO cambioEstadoBD = new CambioEstadoDAO();
            DataTable tablaRtActualesReservable = cambioEstadoBD.BuscarCambioEstadoRTActualReservable(tablaRtActuales);
            return tablaRtActualesReservable;
        }

    }
}
