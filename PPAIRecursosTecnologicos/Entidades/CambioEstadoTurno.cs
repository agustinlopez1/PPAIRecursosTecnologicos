using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPAIRecursosTecnologicos.Entidades
{
    public class CambioEstadoTurno
    {
        private Estado estado;
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;

        public Estado Estado { get => estado; set => estado = value; }
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }

        public (List<CambioEstadoTurno>, List<CambioEstadoTurno>) getCambioEstadoTurno()
        {
            Estado estado = new Estado();
            List<Estado> listaEstado = estado.getEstado();

            //PRIMERA LISTA DE CAMBIO DE ESTADOS
            List<CambioEstadoTurno> listaCambioEstadoTurno1 = new List<CambioEstadoTurno>();

            //NO ES RESERVABLE YA QUE TIENE HORA HASTA > HORA ACTUAL
            CambioEstadoTurno cambioEstadoRT1 = new CambioEstadoTurno();
            cambioEstadoRT1.estado = listaEstado[0];
            cambioEstadoRT1.fechaHoraDesde = DateTime.Now;
            cambioEstadoRT1.fechaHoraHasta = new DateTime(2022, 9, 1, 8, 30, 52);
            listaCambioEstadoTurno1.Add(cambioEstadoRT1);

            //NO ES RESERVABLE XQ TIENE EL ESTADO "BAJA DEFINITIVA" y TIENE HORA HASTA > HORA ACTUAL
            CambioEstadoTurno cambioEstadoRT2 = new CambioEstadoTurno();
            cambioEstadoRT2.estado = listaEstado[1];
            cambioEstadoRT2.fechaHoraDesde = new DateTime(2022, 5, 1, 8, 30, 52);
            cambioEstadoRT2.fechaHoraHasta = new DateTime(2022, 10, 1, 8, 30, 52);
            listaCambioEstadoTurno1.Add(cambioEstadoRT2);

            //ES RESERVABLE PORQUE CUMPLE CON FECHA Y HORARIO
            CambioEstadoTurno cambioEstadoRT3 = new CambioEstadoTurno();
            cambioEstadoRT3.estado = listaEstado[2];
            cambioEstadoRT3.fechaHoraDesde = new DateTime(2022, 3, 1, 8, 30, 52);
            cambioEstadoRT3.fechaHoraHasta = new DateTime(2022, 4, 1, 8, 30, 52);
            listaCambioEstadoTurno1.Add(cambioEstadoRT3);

            //SEGUNDA LISTA DE CAMBIO DE ESTADOS
            List<CambioEstadoTurno> listaCambioEstadoTurno2 = new List<CambioEstadoTurno>();

            //NO ES RESERVABLE YA QUE TIENE HORA HASTA > HORA ACTUAL
            CambioEstadoTurno cambioEstadoRT4 = new CambioEstadoTurno();
            cambioEstadoRT4.estado = listaEstado[0];
            cambioEstadoRT4.fechaHoraDesde = DateTime.Now;
            cambioEstadoRT4.fechaHoraHasta = new DateTime(2022, 9, 1, 8, 30, 52);
            listaCambioEstadoTurno2.Add(cambioEstadoRT4);

            //ES RESERVABLE PORQUE CUMPLE CON FECHA Y HORARIO
            CambioEstadoTurno cambioEstadoRT6 = new CambioEstadoTurno();
            cambioEstadoRT6.estado = listaEstado[3];
            cambioEstadoRT6.fechaHoraDesde = new DateTime(2022, 3, 1, 8, 30, 52);
            cambioEstadoRT6.fechaHoraHasta = new DateTime(2022, 4, 1, 8, 30, 52);
            listaCambioEstadoTurno2.Add(cambioEstadoRT6);

            return (listaCambioEstadoTurno1, listaCambioEstadoTurno2);

        }

        //public (Boolean, Boolean, List<String>) EsActual(RecursoTecnologico rt, List<String> listaEstados)
        //{
        //    Boolean esActual = false;
        //    Boolean reservable = false;
        //    DateTime fechaActual = DateTime.Now;


        //    foreach (CambioEstadoTurno cambioEstado in rt.CambioEstadoTurno)
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

        public Boolean esReservable(CambioEstadoTurno cambioEstado)
        {
            Estado estado = new Estado();
            Boolean esReservable = estado.esReservable(cambioEstado.estado.Nombre);
            return esReservable;
        }

    }
}
