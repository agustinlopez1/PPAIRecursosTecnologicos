using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class AsignacionCientificaCAO
    {
        private int idAsignacionCientificoCI;
        private int idPersonalCientifico;
        private int idTurno;

        public int IdPersonalCientifico { get => idPersonalCientifico; set => idPersonalCientifico = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }
        public int IdAsignacionCientificoCI { get => idAsignacionCientificoCI; set => idAsignacionCientificoCI = value; }

        Acceso_base_dato _BD = new Acceso_base_dato();

        public DataTable BuscarAsignacionPorLegajo(string legajoPc, int idCentro)
        {
            string sql = "select * from AsignacionCientificoCI join  CentroInvestigacion ci on ci.idAsignacionCientificoCI = AsignacionCientificoCI.id where AsignacionCientificoCI.idPersonalCientifico = " + legajoPc + " and ci.id = " + idCentro;
            return _BD.EjecutarSelect(sql);
        }

        public void New(int idEstadoReservado, DateTime fechaActual, int nuevoIdcmt)
        {
            string sql = "INSERT INTO CambioEstadoTurno Values (" + nuevoIdcmt + ", '" + fechaActual + "', NULL, "+ idEstadoReservado+ ")";
            _BD.EjecutarInsert(sql);
        }

        public void setTurno(string idTurnoSeleccionado, string idUsuario, int nuevoId)
        {
            string sql = "INSERT INTO AsignacionCientificoCI Values (" + nuevoId + ", " + idUsuario + ", "+ idTurnoSeleccionado + ")";
            _BD.EjecutarInsert(sql);
        }

        public DataTable getAC()
        {
            string sql = "select id from AsignacionCientificoCI";
            return _BD.EjecutarSelect(sql);
        }
    }
}