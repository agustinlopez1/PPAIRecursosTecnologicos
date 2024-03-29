﻿using PPAIRecursosTecnologicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    public class Utils
    {
        public List<string> ObtenerListaTipoRecursoTec(DataTable tabla)
        {
            List<TipoRecurso> listaTipoRecurso = new List<TipoRecurso>();

            foreach (DataRow tipoRecurso in tabla.Rows)
            {
                TipoRecurso tipoRt = new TipoRecurso();
                tipoRt.Nombre = Convert.ToString(tipoRecurso["nombre"]);
                listaTipoRecurso.Add(tipoRt);
            }

            List<string> listaNombreTipo = new List<string>();
            foreach (TipoRecurso tipo in listaTipoRecurso)
            {
                listaNombreTipo.Add(tipo.Nombre);
            }

            return listaNombreTipo;
        }

        public List<RecursoTecnologico> ObtenerListaRtTipoSeleccionado(DataTable tabla)
        {
            List<RecursoTecnologico> listaRtTipoSelec = new List<RecursoTecnologico>();

            foreach (DataRow rtTipoSelec in tabla.Rows)
            {
                RecursoTecnologico Rt = new RecursoTecnologico();
                Rt.NumeroRT = Convert.ToInt32(rtTipoSelec["numeroRT"]);
                Rt.Nombre = Convert.ToString(rtTipoSelec["nombre"]);
                Rt.FechaAlta = Convert.ToDateTime(rtTipoSelec["fechaAlta"]);
                Rt.IdModelo = Convert.ToInt32(rtTipoSelec["idModelo"]);
                Rt.IdCambioEstadoRT = Convert.ToInt32(rtTipoSelec["idCambioEstadoRT"]);
                Rt.IdTipoRecurso = Convert.ToInt32(rtTipoSelec["idTipoRecurso"]);
                Rt.IdCentroInvestigacion = Convert.ToInt32(rtTipoSelec["idCentroInvestigacion"]);
                Rt.PeriodicidadMantenimientoPrev = Convert.ToString(rtTipoSelec["periodicidad"]);
                Rt.DuracionMantenimientoPrev = Convert.ToString(rtTipoSelec["duracion"]);
                Rt.FraccionHorarioTurnos = Convert.ToString(rtTipoSelec["fraccionHorario"]);
                Rt.IdTurnos = Convert.ToInt32(rtTipoSelec["idTurno"]);
                listaRtTipoSelec.Add(Rt);
            }

            return listaRtTipoSelec;
        }

        public string ObtenerListaEstado(DataTable tabla)
        {
            string nombreEstadoRT = " ";

            foreach (DataRow estadoRT in tabla.Rows)
            {
                return nombreEstadoRT = Convert.ToString(estadoRT["nombre"]);
            }

            return nombreEstadoRT;
        }

        public string ObtenerListaCentroInvestigacion(DataTable tabla)
        {
            string nombreCentroIvestigacion = " ";

            foreach (DataRow centroInvestigacion in tabla.Rows)
            {
                return nombreCentroIvestigacion = Convert.ToString(centroInvestigacion["nombre"]);
            }

            return nombreCentroIvestigacion;
        }

        public string ObtenerListaModelo(DataTable tabla)
        {
            string nombreModelo = " ";

            foreach (DataRow modelo in tabla.Rows)
            {
                return nombreModelo = Convert.ToString(modelo["nombre"]);
            }

            return nombreModelo;
        }

        public string ObtenerListaMarca(DataTable tabla)
        {
            string nombreMarca = " ";

            foreach (DataRow marca in tabla.Rows)
            {
                return nombreMarca = Convert.ToString(marca["nombre"]);
            }
            return nombreMarca;
        }

        public int ObtenerIdCentroInvestigacionRTSeleccionado(DataTable tabla)
        {
            int idCentro = -1;

            foreach (DataRow rtTipoSelec in tabla.Rows)
            {
                idCentro = Convert.ToInt32(rtTipoSelec["idCentroInvestigacion"]);
            }

            return idCentro;
        }

        public string ObtenerNombreUsuarioLogueado(DataTable tabla)
        {
            string nombreUsuario = "";

            foreach (DataRow usuario in tabla.Rows)
            {
                nombreUsuario = Convert.ToString(usuario["usuario"]);
            }

            return nombreUsuario;
        }

        public string ObtenerLegajoPersonalCientifico(DataTable tabla)
        {
            string legajoPc = "";

            foreach (DataRow personal in tabla.Rows)
            {
                legajoPc = Convert.ToString(personal["legajo"]);
            }

            return legajoPc;
        }

        public string ObtenerIdTurno(DataTable tabla)
        {
            string idTurno = "";

            foreach (DataRow asignacion in tabla.Rows)
            {
                idTurno = Convert.ToString(asignacion["IdTurno"]);
            }

            return idTurno;
        }

        public DateTime ObtenerFechaTurno(DataTable tabla)
        {
            DateTime fechaTurno = DateTime.Now;

            foreach (DataRow asignacion in tabla.Rows)
            {
                fechaTurno = Convert.ToDateTime(asignacion["fechaHoraInicio"]);
            }

            return fechaTurno;
        }

        public bool ObtenerFechaCambioEstadoTurno(DataTable tabla)
        {
            bool fechaCambioEstadoTurno = true;

            foreach (DataRow asignacion in tabla.Rows)
            {
                fechaCambioEstadoTurno = Convert.IsDBNull(asignacion["fechaHoraHasta"]);
            }

            return fechaCambioEstadoTurno;
        }

        public string ObtenerIdEstado(DataTable tabla)
        {
            string idCambioEstado = " ";

            foreach (DataRow asignacion in tabla.Rows)
            {
                idCambioEstado = Convert.ToString(asignacion["idEstado"]);
            }

            return idCambioEstado;
        }

        public List<string> ObtenerEstado(DataTable tabla)
        {
            List<string> listaestado = new List<string>();

            foreach (DataRow rtTipoSelec in tabla.Rows)
            {
                Estado e = new Estado();
                e.Nombre = Convert.ToString(rtTipoSelec["nombre"]);
                listaestado.Add(e.Nombre);
            }

            return listaestado;
        }

        public List<Turno> ObtenerTurno(DataTable tabla)
        {
            List<Turno> listaTurno = new List<Turno>();

            foreach (DataRow turno in tabla.Rows)
            {
                Turno e = new Turno();
                e.FechaHoraInicio = Convert.ToDateTime(turno["fechaHoraInicio"]);
                e.FechaHoraFin = Convert.ToDateTime(turno["fechaHoraFin"]);

                listaTurno.Add(e);
            }

            return listaTurno;
        }

        public List<Turno> ObtenerTablaTurnoSeleccionado(DataTable tabla)
        {
            List<Turno> listaTurno = new List<Turno>();

            foreach (DataRow turno in tabla.Rows)
            {
                Turno e = new Turno();
                e.FechaHoraInicio = Convert.ToDateTime(turno["fechaHoraInicio"]);
                e.FechaHoraFin = Convert.ToDateTime(turno["fechaHoraFin"]);

                listaTurno.Add(e);
            }

            return listaTurno;
        }

        public List<Estado> ObtenerTablaEstado(DataTable tabla)
        {
            List<Estado> listaestado = new List<Estado>();

            foreach (DataRow estado in tabla.Rows)
            {
                Estado e = new Estado();
                e.Nombre = Convert.ToString(estado["nombre"]);
                e.Ambito = Convert.ToString(estado["ambito"]);
                e.Id = Convert.ToInt32(estado["id"]);

                listaestado.Add(e);
            }

            return listaestado;
        }

        public string ObtenerIdCambioEstado(DataTable tabla)
        {
            string idCambioEstadoTurnoSelec = " ";

            foreach (DataRow asignacion in tabla.Rows)
            {
                idCambioEstadoTurnoSelec = Convert.ToString(asignacion["idCambioEstadoTurno"]);
            }

            return idCambioEstadoTurnoSelec;
        }

        public string ObtenerIdUsuario(DataTable tabla)
        {
            string idUsuario = "";

            foreach (DataRow usuario in tabla.Rows)
            {
                idUsuario = Convert.ToString(usuario["idUsuario"]);
            }

            return idUsuario;
        }

        public int BuscarUltimoId(DataTable tabla)
        {
            int ultimoId = 0;

            foreach (DataRow usuario in tabla.Rows)
            {
                ultimoId = Convert.ToInt32(usuario["id"]);
            }

            return ultimoId;
        }

        public string ObtenerIdTurnoSelec(DataTable tabla)
        {
            string idTurno = "";

            foreach (DataRow asignacion in tabla.Rows)
            {
                idTurno = Convert.ToString(asignacion["id"]);
            }

            return idTurno;
        }
    }
}
