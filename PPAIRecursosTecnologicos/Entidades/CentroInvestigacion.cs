using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class CentroInvestigacion
    {
        private int idCentroInvestigacion;
        private string nombre;
        private int idAsignacionCientificoCI;
        public CentroInvestigacion() { }

        public string Nombre { get => nombre; set => nombre = value; }
        public int IdAsignacionCientificoCI { get => idAsignacionCientificoCI; set => idAsignacionCientificoCI = value; }
        public int IdCentroInvestigacion { get => idCentroInvestigacion; set => idCentroInvestigacion = value; }


        public DataTable getCentroInvestigacion()
        {
            CentroInvestigacionDAO centroInvestigacionbd = new CentroInvestigacionDAO();
            DataTable tablaCentroInvestigacion = centroInvestigacionbd.getCentroInvestigacion();
            return tablaCentroInvestigacion;
        }

        //public string getNombre(RecursoTecnologico rt)
        //{
        //    string nombreCentroInvestigacion = rt.CentroInvestigacion.nombre;

        //    return nombreCentroInvestigacion;
        //}

        public DataTable esAsignado(DataTable usuarioLogeado, int idCentro)
        {
            AsignacionCientificoDeCentroInvestigacion asignacionCientificoDeCentroInvestigacion = new AsignacionCientificoDeCentroInvestigacion();
            DataTable asignacionPersonalLogueado = asignacionCientificoDeCentroInvestigacion.esTuCientifico(usuarioLogeado, idCentro);

            return asignacionPersonalLogueado;
        }

        public void asignarTurno(string idTurnoSeleccionado, string idUsuario, int nuevoIdcmt)
        {           
            AsignacionCientificoDeCentroInvestigacion ac = new AsignacionCientificoDeCentroInvestigacion();
            int nuevoIdAc = ac.setTurno(idTurnoSeleccionado, idUsuario);

            CentroInvestigacionDAO cibd = new CentroInvestigacionDAO();
            cibd.asignarTurno(nuevoIdAc);

            TurnoDAO turnobd = new TurnoDAO();
            turnobd.setNuevoCambioEstado(nuevoIdcmt, idTurnoSeleccionado);
        }
    }
}
