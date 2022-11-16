using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class AsignacionCientificoDeCentroInvestigacion
    {
        private int idAsignacionCientificoCI;
        private int idPersonalCientifico;
        private int idTurno;

        public int IdPersonalCientifico { get => idPersonalCientifico; set => idPersonalCientifico = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }
        public int IdAsignacionCientificoCI { get => idAsignacionCientificoCI; set => idAsignacionCientificoCI = value; }

        public (DataTable, Boolean) esTuCientifico(DataTable usuarioLogeado, int idCentro)
        {
            Boolean bandera;
            PersonalCientifico personalCientifico = new PersonalCientifico();
            string legajoPc = personalCientifico.generarPersonalCientifico(usuarioLogeado);

            AsignacionCientificaCAO ACbd = new AsignacionCientificaCAO();
            DataTable tablaAsignacion = ACbd.BuscarAsignacionPorLegajo(legajoPc, idCentro);

            if (tablaAsignacion.Columns.Count == 0)
            {
                bandera = false;
            }
            else
                bandera = true;

            return (tablaAsignacion, bandera);
        }

        public int setTurno(string idTurnoSeleccionado, string idUsuario)
        {
            AsignacionCientificaCAO acbd = new AsignacionCientificaCAO();
            DataTable idAC = acbd.getAC();

            Utils util = new Utils();
            int ultimoId = util.BuscarUltimoId(idAC);

            int nuevoId = ultimoId + 1;

            acbd.setTurno(idTurnoSeleccionado, idUsuario, nuevoId);

            return nuevoId;
        }

        public int Reservar(DataTable turnoSeleccionado, int idEstadoReservado)
        {
            Utils util = new Utils();
            string idCambioEstadoTurnoSelec = util.ObtenerIdCambioEstado(turnoSeleccionado);

            CambioEstadoTurnoDAO cmt = new CambioEstadoTurnoDAO();
            DateTime fechaActual = DateTime.Now;
            cmt.SetFechaHoraHasta(idCambioEstadoTurnoSelec, fechaActual, idEstadoReservado);

            DataTable idCambioEstados = cmt.getCambioEstadoTurno();
            int ultimoidCmt = util.BuscarUltimoId(idCambioEstados);
            int nuevoIdcmt = ultimoidCmt + 1;

            AsignacionCientificaCAO asbd = new AsignacionCientificaCAO();
            asbd.New(idEstadoReservado, fechaActual, nuevoIdcmt);

            return nuevoIdcmt;
        }
    }
}
