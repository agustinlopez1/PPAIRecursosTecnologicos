using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    class PersonalCientificoDAO
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private int numeroDocumento;
        private string correoElectronicoInstitucional;
        private string correoElectronicoPersonal;
        private int telefonoCelular;

        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string CorreoElectronicoInstitucional { get => correoElectronicoInstitucional; set => correoElectronicoInstitucional = value; }
        public string CorreoElectronicoPersonal { get => correoElectronicoPersonal; set => correoElectronicoPersonal = value; }
        public int TelefonoCelular { get => telefonoCelular; set => telefonoCelular = value; }

        Acceso_base_dato _BD = new Acceso_base_dato();

        public DataTable getPersonalCientifico(string nombreUsuario)
        {
            string sql = "select legajo from PersonalCientifico where nombre = '" + nombreUsuario + "'";
            return _BD.EjecutarSelect(sql);
        }


    }
}