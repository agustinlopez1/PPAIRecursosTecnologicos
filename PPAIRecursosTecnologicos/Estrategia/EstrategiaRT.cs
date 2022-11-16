using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Estrategia
{
    public interface EstrategiaRT
    {
        (DataTable, DataTable) getTurnos(DataTable asignacionPersonalLogueado);
    }
}
