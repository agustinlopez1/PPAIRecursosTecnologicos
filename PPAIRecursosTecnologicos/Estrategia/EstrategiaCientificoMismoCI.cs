using PPAIRecursosTecnologicos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Estrategia
{
    public class EstrategiaCientificoMismoCI : EstrategiaRT
    {
        public (DataTable, DataTable) getTurnos(DataTable asignacionPersonalLogueado)
        {
            Turno turno = new Turno();
            (DataTable estadoTurnosActuales, DataTable tablaTurnos) = turno.getTurnos(asignacionPersonalLogueado);
            return (estadoTurnosActuales, tablaTurnos);
        }
    }
}
