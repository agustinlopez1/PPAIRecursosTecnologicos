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
        private Usuario usuario;
        private DateTime fechaHoraActual; // VER
        private string TipoNotificacion; // Es otra entidad? Es string?

        public GestorRegistrarReserva()
        {
        }

        // GET Y SET de atributos
        public List<RecursoTecnologico> RecursosTecnologicos { get => recursosTecnologicos; set => recursosTecnologicos = value; }
        public List<TipoRecurso> TiposRecursos { get => tiposRecursos; set => tiposRecursos = value; }
        public Sesion Sesion { get => sesion; set => sesion = value; }


        // Le solicito a "Tipo de Recursos Tecnologicos" que me devuelva una lista de todos.
        public List<TipoRecurso> buscarTipoRecursoTecnologico()
        {
            TipoRecurso tipoRecurso = new TipoRecurso();
            this.tiposRecursos = tipoRecurso.generarTipoRecursos();

            return tiposRecursos;
        }


        //public Usuario verificarUsuarioLogueado()
        //{
        //    Session sesion = new Session();

        //    this.usuario = sesion.getCientificoLogueado();

        //}



    }
}
