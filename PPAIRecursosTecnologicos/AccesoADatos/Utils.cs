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
        public List<String> DeTablaALista(DataTable tabla)
        {
            List<String> lista = new List<String>();

            foreach (DataRow elemento in tabla.Rows)
            {
                Sesion ses = new Sesion();

                ses.FechaHoraInicio = Convert.ToDateTime(sesion["fechaHoraInicio"]);
                if (sesion["fechaHoraFin"] == DBNull.Value)
                {
                    // ses.FechaHoraFin = DateTime.MinValue;
                    ses.FechaHoraFin = DateTime.MinValue;
                    // DateTime date1 = new DateTime(2008, 8, 29, 19, 27, 15)
                }
                else
                {

                    ses.FechaHoraFin = Convert.ToDateTime(sesion["fechaHoraFin"]);
                }

                ses.Usuario = Sesion.getEmpleadoEnSesion(Convert.ToInt32(sesion["idUsuario"]));

                listaSesiones.Add(ses);
            }
    }
}
