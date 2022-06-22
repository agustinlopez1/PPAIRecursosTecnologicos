using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class RecursoTecnologico
    {
        private string nombre;
        private int numeroRT;
        private string imagen;
        private DateTime fechaAlta;
        private Modelo modelo;
        private List<CambioEstadoRT> cambioEstadoRT;
        private TipoRecurso tipoRecurso;
        private CentroInvestigacion centroInvestigacion;
        private string periodicidadMantenimientoPrev;
        private string duracionMantenimientoPrev;
        private string fraccionHorarioTurnos;
        // private PersonalCientifico cientifico; // Ver
        // private int numeroInventario;
        // private int idTipoRecurso;
        // private bool disponibilidad; // Ver
        // private string caracteristica;

        public RecursoTecnologico()
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public Modelo Modelo { get => modelo; set => modelo = value; }
        public List<CambioEstadoRT> CambioEstadoRT { get => cambioEstadoRT; set => cambioEstadoRT = value; }
        public TipoRecurso TipoRecurso { get => TipoRecurso; set => TipoRecurso = value; }
        public CentroInvestigacion CentroInvestigacion { get => centroInvestigacion; set => centroInvestigacion = value; }
        public int NumeroRT { get => numeroRT; set => numeroRT = value; }
        public string PeriodicidadMantenimientoPrev { get => periodicidadMantenimientoPrev; set => periodicidadMantenimientoPrev = value; }
        public string DuracionMantenimientoPrev { get => duracionMantenimientoPrev; set => duracionMantenimientoPrev = value; }
        public string FraccionHorarioTurnos { get => fraccionHorarioTurnos; set => fraccionHorarioTurnos = value; }

        //public PersonalCientifico Cientifico { get => cientifico; set => cientifico = value; }      
        //public string Caracteristica { get => caracteristica; set => caracteristica = value; }
        //public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        //public int IdTipoRecurso { get => idTipoRecurso; set => idTipoRecurso = value; }

        public List<RecursoTecnologico> getRecursosTecnologicos()
        {
            Modelo modelo = new Modelo();
            List<Modelo> listaModelo = modelo.getModelo();
            
            TipoRecurso tipoRt = new TipoRecurso();
            List<TipoRecurso> listaTiposRt = tipoRt.ListaTipoRecursos();

            CentroInvestigacion centroInvestigacion = new CentroInvestigacion();
            List<CentroInvestigacion> listaCentroInv = centroInvestigacion.getCentroInvestigacion();

            CambioEstadoRT cambioEstadoRT = new CambioEstadoRT();
            (List<CambioEstadoRT> listaCambioEstadoRT1, List<CambioEstadoRT> listaCambioEstadoRT2) = cambioEstadoRT.getCambioEstadoRT();

            List<RecursoTecnologico> listaRecursosTecnologicos = new List<RecursoTecnologico>();

            //BALANZA DE PRECISION RESERVABLE
            RecursoTecnologico recursoTecnologico1 = new RecursoTecnologico();
            recursoTecnologico1.nombre = "recurso tipo Balanza de precisión";
            recursoTecnologico1.numeroRT = 1;
            recursoTecnologico1.imagen = "imagen1";
            recursoTecnologico1.fechaAlta = DateTime.Now;
            recursoTecnologico1.periodicidadMantenimientoPrev = "cada 10 meses";
            recursoTecnologico1.duracionMantenimientoPrev = "1 semana";
            recursoTecnologico1.fraccionHorarioTurnos = "15 minutos";
            recursoTecnologico1.tipoRecurso = listaTiposRt[0];
            recursoTecnologico1.centroInvestigacion = listaCentroInv[0];
            recursoTecnologico1.cambioEstadoRT = listaCambioEstadoRT1;
            recursoTecnologico1.modelo = listaModelo[0];

            listaRecursosTecnologicos.Add(recursoTecnologico1);

            // BALANZA DE PRECISION RESERVABLE
            RecursoTecnologico recursoTecnologico2 = new RecursoTecnologico();
            recursoTecnologico2.nombre = "recurso tipo BALANZA DE PRECISION";
            recursoTecnologico2.numeroRT = 2;
            recursoTecnologico2.imagen = "imagen2";
            recursoTecnologico2.fechaAlta = DateTime.Now;
            recursoTecnologico2.periodicidadMantenimientoPrev = "cada 3 meses";
            recursoTecnologico2.duracionMantenimientoPrev = "45 semana";
            recursoTecnologico2.fraccionHorarioTurnos = "15 minutos";
            recursoTecnologico2.tipoRecurso = listaTiposRt[0];
            recursoTecnologico2.centroInvestigacion = listaCentroInv[1];
            recursoTecnologico2.cambioEstadoRT = listaCambioEstadoRT2;
            recursoTecnologico2.modelo = listaModelo[1];

            listaRecursosTecnologicos.Add(recursoTecnologico2);

            // RESONADOR CON ESTADO RESERVABLE
            RecursoTecnologico recursoTecnologico3 = new RecursoTecnologico();
            recursoTecnologico3.nombre = "recurso tipo Resonador Magnetico";
            recursoTecnologico3.numeroRT = 3;
            recursoTecnologico3.imagen = "imagen3";
            recursoTecnologico3.fechaAlta = DateTime.Now;
            recursoTecnologico3.periodicidadMantenimientoPrev = "cada 1 año";
            recursoTecnologico3.duracionMantenimientoPrev = "9 meses";
            recursoTecnologico3.fraccionHorarioTurnos = "15 minutos";
            recursoTecnologico3.tipoRecurso = listaTiposRt[2];
            recursoTecnologico3.centroInvestigacion = listaCentroInv[2];
            recursoTecnologico3.cambioEstadoRT = listaCambioEstadoRT1;
            recursoTecnologico3.modelo = listaModelo[2];

            listaRecursosTecnologicos.Add(recursoTecnologico3);


            //recursoTecnologico1.cientifico = "";
            //recursoTecnologico1.disponibilidad = true;
            //recursoTecnologico1.caracteristica = "caracteristica1";

            return listaRecursosTecnologicos;

        }

        public List<RecursoTecnologico> esDeTipoRtSeleccionado(string tipoRtSeleccionado)
        {
            List<RecursoTecnologico> listaRecursosTecnologicos = getRecursosTecnologicos();
            List<RecursoTecnologico> listaRtTipoSelecc = new List<RecursoTecnologico>();

            foreach (RecursoTecnologico rt in listaRecursosTecnologicos)
            {
                if (rt.tipoRecurso.Nombre == tipoRtSeleccionado)
                {
                    listaRtTipoSelecc.Add(rt); 
                }
            }
            return listaRtTipoSelecc;
        }

        public (List<RecursoTecnologico>, List<String>) esReservable(List<RecursoTecnologico> listaRTdeTipoRT)
        {
            CambioEstadoRT cambioEstadoRT = new CambioEstadoRT();
            List<RecursoTecnologico> listaRTReservable = new List<RecursoTecnologico>();

            Boolean esActual = false;
            Boolean reservable = false;
            List<String> listaEstados = new List<String>();

            foreach (RecursoTecnologico rt in listaRTdeTipoRT)
            {
                (esActual, reservable, listaEstados) = cambioEstadoRT.EsActual(rt, listaEstados);
                if (esActual == true && reservable == true)
                {
                    listaRTReservable.Add(rt);
                }
            }

            return (listaRTReservable, listaEstados);
        }

        //busca marca y modelo
        public (List<string>, List<string>) getMarcaModelo(List<RecursoTecnologico> listaRTReservable)
        {
            Modelo modelo = new Modelo();

            List<string> listaModelos = new List<string>();
            List<string> listaMarca = new List<string>();

            string nombreModelo = " ";
            string nombreMarca = " ";

            foreach (RecursoTecnologico rt in listaRTReservable)
            {
                (nombreMarca, nombreModelo) = modelo.getMarcaModelo(rt);
                listaModelos.Add(nombreModelo);
                listaMarca.Add(nombreMarca);
            }

            return (listaMarca, listaModelos);
        }

        public List<string> getCentroInvestigacion(List<RecursoTecnologico> listaRTReservable)
        {
            CentroInvestigacion centroInvestigacion = new CentroInvestigacion();
            List<string> listaCentroInvestigacion = new List<string>();
            string nombreCentroInvestigacion = " ";

            foreach (RecursoTecnologico rt in listaRTReservable)
            {
                nombreCentroInvestigacion = centroInvestigacion.getNombre(rt);
                listaCentroInvestigacion.Add(nombreCentroInvestigacion);
            }

            return listaCentroInvestigacion;
        }

    }
}
