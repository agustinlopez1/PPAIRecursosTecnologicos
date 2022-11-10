using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class SesionDAO
    {
        private DateTime fechaHoraInicio;
        private DateTime fechaHoraFin;
        private int idUsuario;

        public DateTime FechaHoraInicio { get => fechaHoraInicio; set => fechaHoraInicio = value; }
        public DateTime FechaHoraFin { get => fechaHoraFin; set => fechaHoraFin = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        
        Acceso_base_dato _BD = new Acceso_base_dato();

        //Usar para reportes
        public DataTable getCientificoLogueado()
        {
            string sql = "SELECT nombre FROM TipoRecurso";
            return _BD.EjecutarSelect(sql);
        }


    }
}
