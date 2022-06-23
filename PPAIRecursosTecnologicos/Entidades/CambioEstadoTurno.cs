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

            //TURNO CON ESTADO DISPONIBLE --ES EL SE SE USA
            CambioEstadoTurno cambioEstadoTurno1 = new CambioEstadoTurno();
            cambioEstadoTurno1.estado = listaEstado[2];
            cambioEstadoTurno1.fechaHoraDesde = DateTime.Now;
            cambioEstadoTurno1.fechaHoraHasta = DateTime.Now.AddHours(10);
            listaCambioEstadoTurno1.Add(cambioEstadoTurno1);

            //TURNO CON ESTADO DISPONIBLE 
            CambioEstadoTurno cambioEstadoTurno2 = new CambioEstadoTurno();
            cambioEstadoTurno2.estado = listaEstado[2];
            cambioEstadoTurno2.fechaHoraDesde = DateTime.Now;
            cambioEstadoTurno2.fechaHoraHasta = DateTime.Now.AddHours(-10);
            listaCambioEstadoTurno1.Add(cambioEstadoTurno2);

            //TURNO CON ESTADO EN INICIO DE MANTENIMIENTO CORRECTIVO
            CambioEstadoTurno cambioEstadoTurno3 = new CambioEstadoTurno();
            cambioEstadoTurno3.estado = listaEstado[5];
            cambioEstadoTurno3.fechaHoraDesde = new DateTime(2022, 3, 1, 8, 30, 52);
            cambioEstadoTurno3.fechaHoraHasta = new DateTime(2022, 4, 1, 8, 30, 52);
            listaCambioEstadoTurno1.Add(cambioEstadoTurno3);

            //SEGUNDA LISTA DE CAMBIO DE ESTADOS
            List<CambioEstadoTurno> listaCambioEstadoTurno2 = new List<CambioEstadoTurno>();

            //TURNO CON ESTADO DISPONIBLE
            CambioEstadoTurno cambioEstadoTurno4 = new CambioEstadoTurno();
            cambioEstadoTurno4.estado = listaEstado[2];
            cambioEstadoTurno4.fechaHoraDesde = DateTime.Now;
            cambioEstadoTurno4.fechaHoraHasta = DateTime.Now.AddHours(-10);
            listaCambioEstadoTurno2.Add(cambioEstadoTurno4);

            //TURNO CON ESTADO RESERVADO -- ES EL QUE SE USA
            CambioEstadoTurno cambioEstadoTurno6 = new CambioEstadoTurno();
            cambioEstadoTurno6.estado = listaEstado[2];
            cambioEstadoTurno6.fechaHoraDesde = new DateTime(2022, 3, 1, 8, 30, 52);
            cambioEstadoTurno6.fechaHoraHasta = DateTime.Now.AddHours(10);
            listaCambioEstadoTurno2.Add(cambioEstadoTurno6);

            return (listaCambioEstadoTurno1, listaCambioEstadoTurno2);

        }

        public (Boolean, List<String>, List<CambioEstadoTurno>) EsActual(Turno turno, List<String> listaEstados, List<CambioEstadoTurno> cambioEstadoActual)
        {
            Boolean esActual = false;
            DateTime fechaActual = DateTime.Now;

            foreach (CambioEstadoTurno cambioEstado in turno.CambioEstadoTurno)
            {
                if (cambioEstado.fechaHoraHasta > fechaActual)
                {
                    esActual = true;
                    listaEstados.Add(cambioEstado.Estado.Nombre);
                    cambioEstadoActual.Add(cambioEstado);
                }

            }
            return (esActual, listaEstados, cambioEstadoActual);
        }

        public void setFechaHoraFin()
        {
            return;
        }
    }
}
