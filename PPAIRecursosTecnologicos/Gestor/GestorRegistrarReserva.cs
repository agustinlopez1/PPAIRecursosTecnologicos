using PPAIRecursosTecnologicos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPAIRecursosTecnologicos.Pantalla;

namespace PPAIRecursosTecnologicos.Gestor
{
    public class GestorRegistrarReserva
    {
        private List<RecursoTecnologico> recursosTecnologicos;
        //private List<TipoRecurso> tiposRecursos;
        private List<string> tiposRecursos;
        private Sesion sesion;
        private Usuario usuario;
        private DateTime fechaHoraActual; // Ver
        private string TipoNotificacion; // Es otra entidad? Es string?
        private string tipoRecursoSeleccionado;

        public GestorRegistrarReserva()
        {
        }

        // GET Y SET de atributos
        public List<RecursoTecnologico> RecursosTecnologicos { get => recursosTecnologicos; set => recursosTecnologicos = value; }
        //   public List<TipoRecurso> TiposRecursos { get => tiposRecursos; set => tiposRecursos = value; }
        public List<string> TiposRecursos { get => tiposRecursos; set => tiposRecursos = value; }
        public Sesion Sesion { get => sesion; set => sesion = value; }

        //
        // Primer metodo Gestor
        //
        // Le solicito a "Tipo de Recursos Tecnologicos" que me devuelva una lista de todos.
        public List<string> buscarTipoRecursoTecnologico()
        {
            TipoRecurso tipoRecurso = new TipoRecurso();
            this.tiposRecursos = tipoRecurso.getNombre();

            return tiposRecursos;
        }

        // Gestor recibe el tipo de recurso desde la pantalla y lo setea
        public List<RecursoTecnologico> tomarSeleccionTipoRecursoTecnologico(string tipoRecurso)
        {
            this.tipoRecursoSeleccionado = tipoRecurso;
            List<RecursoTecnologico> listaRTdeTipoRT = obtenerRecursoTecnologicoActivo(tipoRecursoSeleccionado);

            return listaRTdeTipoRT;
        }

        //
        // Segundo metodo Gestor
        //
        //
        public List<RecursoTecnologico> obtenerRecursoTecnologicoActivo(string tipoRecursoSeleccionado)
        {
            RecursoTecnologico recursoTecnologico = new RecursoTecnologico();
            List<RecursoTecnologico> listaRTdeTipoRT = recursoTecnologico.esDeTipoRtSeleccionado(tipoRecursoSeleccionado);

            return listaRTdeTipoRT;
        }

        //public Usuario verificarUsuarioLogueado()
        //{
        //    Session sesion = new Session();

        //    this.usuario = sesion.getCientificoLogueado();

        //}



    }
}
