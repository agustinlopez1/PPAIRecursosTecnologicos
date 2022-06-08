using PPAIRecursosTecnologicos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Gestor
{
    public class GestorRegistrarReserva
    {
        private List<RecursoTecnologico> recursosTecnologicos;
        private List<TipoRecurso> tiposRecursos;
        private Sesion sesion;
        private DateTime fechaHoraActual; // VER
        private string TipoNotificacion; // Es otra entidad? Es string?

        public GestorRegistrarReserva()
        {
        }

        public List<RecursoTecnologico> RecursosTecnologicos { get => recursosTecnologicos; set => recursosTecnologicos = value; }
        public List<TipoRecurso> TiposRecursos { get => tiposRecursos; set => tiposRecursos = value; }
        public Sesion Sesion { get => sesion; set => sesion = value; }



    }
}
