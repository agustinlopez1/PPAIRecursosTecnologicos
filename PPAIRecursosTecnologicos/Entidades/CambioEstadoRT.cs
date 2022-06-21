using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PPAIRecursosTecnologicos.Entidades
{
    public class CambioEstadoRT
    {
        private Estado estado;
        private DateTime fechaHoraDesde;
        private DateTime fechaHoraHasta;

        public Estado Estado { get => estado; set => estado = value; }
        public DateTime FechaHoraDesde { get => fechaHoraDesde; set => fechaHoraDesde = value; }
        public DateTime FechaHoraHasta { get => fechaHoraHasta; set => fechaHoraHasta = value; }

        public (List<CambioEstadoRT>, List<CambioEstadoRT>) getCambioEstadoRT()
        {
            Estado estado = new Estado();
            List<Estado> listaEstado = estado.getEstado();

            List<CambioEstadoRT> listaCambioEstadoRT1 = new List<CambioEstadoRT>();

            CambioEstadoRT cambioEstadoRT1 = new CambioEstadoRT();
            cambioEstadoRT1.estado = listaEstado[0];
            cambioEstadoRT1.fechaHoraDesde = DateTime.Now;
            cambioEstadoRT1.fechaHoraHasta = new DateTime(2022, 9, 1, 8, 30, 52);
            listaCambioEstadoRT1.Add(cambioEstadoRT1);

            CambioEstadoRT cambioEstadoRT2 = new CambioEstadoRT();
            cambioEstadoRT2.estado = listaEstado[1];
            cambioEstadoRT2.fechaHoraDesde = new DateTime(2022, 5, 1, 8, 30, 52);
            cambioEstadoRT2.fechaHoraHasta = new DateTime(2022, 6, 1, 8, 30, 52);
            listaCambioEstadoRT1.Add(cambioEstadoRT2);

            CambioEstadoRT cambioEstadoRT3 = new CambioEstadoRT();
            cambioEstadoRT3.estado = listaEstado[0];
            cambioEstadoRT3.fechaHoraDesde = new DateTime(2022, 3, 1, 8, 30, 52);
            cambioEstadoRT3.fechaHoraHasta = new DateTime(2022, 4, 1, 8, 30, 52);
            listaCambioEstadoRT1.Add(cambioEstadoRT3);

            List<CambioEstadoRT> listaCambioEstadoRT2 = new List<CambioEstadoRT>();

            CambioEstadoRT cambioEstadoRT4 = new CambioEstadoRT();
            cambioEstadoRT4.estado = listaEstado[0];
            cambioEstadoRT4.fechaHoraDesde = DateTime.Now;
            cambioEstadoRT4.fechaHoraHasta = new DateTime(2022, 9, 1, 8, 30, 52);
            listaCambioEstadoRT2.Add(cambioEstadoRT4);

            CambioEstadoRT cambioEstadoRT5 = new CambioEstadoRT();
            cambioEstadoRT5.estado = listaEstado[1];
            cambioEstadoRT5.fechaHoraDesde = new DateTime(2022, 5, 1, 8, 30, 52);
            cambioEstadoRT5.fechaHoraHasta = new DateTime(2022, 6, 1, 8, 30, 52);
            listaCambioEstadoRT2.Add(cambioEstadoRT5);

            CambioEstadoRT cambioEstadoRT6 = new CambioEstadoRT();
            cambioEstadoRT6.estado = listaEstado[1];
            cambioEstadoRT6.fechaHoraDesde = new DateTime(2022, 3, 1, 8, 30, 52);
            cambioEstadoRT6.fechaHoraHasta = new DateTime(2022, 4, 1, 8, 30, 52);
            listaCambioEstadoRT2.Add(cambioEstadoRT6);

            return (listaCambioEstadoRT1, listaCambioEstadoRT2);

        }

        public (Boolean, Boolean/*, String*/) esActual(RecursoTecnologico rt)
        {
            Boolean esActual = false;
            //String nombreEstado = " ";
            Boolean reservable = false;
            DateTime fechaActual = DateTime.Now;

            foreach (CambioEstadoRT cambioEstado in rt.CambioEstadoRT)
            {
                if (cambioEstado.fechaHoraHasta < fechaActual)
                {
                    //(reservable, nombreEstado) =  esReservable(cambioEstado);
                    reservable = esReservable(cambioEstado);
                    esActual = true;

                }
                else
                {
                    esActual = false;
                }
            }
            //return (esActual, reservable, nombreEstado);
            return (esActual, reservable);
        }

        //public (Boolean, String) esReservable(CambioEstadoRT cambioEstado)
        public Boolean esReservable(CambioEstadoRT cambioEstado)
        {
            Estado estado = new Estado();
            Boolean esReservable = estado.esReservable(cambioEstado.estado.Nombre);
            //String nombreEstado = cambioEstado.estado.Nombre;
            //return (esReservable, nombreEstado);
            return esReservable;
        }

        public string getEstado(RecursoTecnologico rt)
        {
            Estado estado = new Estado();
            string nombreEstado = "";

            foreach (CambioEstadoRT estadort in rt.CambioEstadoRT)
            {
                nombreEstado = estado.getNombre(estadort);
            }

            return nombreEstado;
        }
    }
}
