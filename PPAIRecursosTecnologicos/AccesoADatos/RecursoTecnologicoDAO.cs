﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.AccesoADatos
{
    public class RecursoTecnologicoDAO
    {
        public string pp_id_rubro { get; set; }
        public string pp_nombre { get; set; }

        Acceso_base_dato _BD = new Acceso_base_dato();

        //Usar para reportes
        public DataTable BuscarNombre(object nombre)
        {
            string sql = "SELECT * FROM PersonalCientifico WHERE nombre = '" + nombre + "'";
            return _BD.EjecutarSelect(sql);
        }
    }
}
