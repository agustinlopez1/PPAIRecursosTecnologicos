﻿using System;
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

        public DataTable EsActual(string idTurno)
        {
            string sql = "select cet.* from turno t join CambioEstadoTurno cet on cet.id = t.idCambioEstadoTurno where t.id = " + idTurno;
            return _BD.EjecutarSelect(sql);
        }

        public DataTable getCambioEstadoTurno()
        {
            string sql = "select id from CambioEstadoTurno";
            return _BD.EjecutarSelect(sql);
        }

        public void SetFechaHoraHasta(string idCambioEstadoTurnoSelec, DateTime fechaActual, int idEstadoReservado)
        {
            string sql = "UPDATE CambioEstadoTurno SET fechaHoraHasta = '" + fechaActual + "'  where id = " + idCambioEstadoTurnoSelec;
            _BD.EjecutarInsert(sql);
        }
    }
}