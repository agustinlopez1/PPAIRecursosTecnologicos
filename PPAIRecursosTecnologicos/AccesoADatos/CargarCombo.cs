using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    public class CargarCombo : ComboBox
    {
        public string Pp_Pk { get; set; }
        public string Pp_descripcion { get; set; }
        public string Pp_tabla { get; set; }
        public bool Pp_Conseleccion { get; set; }

        Acceso_base_dato _BD = new Acceso_base_dato();
        public void CargarComboBox()
        {
            string sql = "SELECT " + Pp_Pk + ", " + Pp_descripcion + " FROM " + Pp_tabla;
            this.DisplayMember = Pp_descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (this.Pp_Conseleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
        }



    }
}
