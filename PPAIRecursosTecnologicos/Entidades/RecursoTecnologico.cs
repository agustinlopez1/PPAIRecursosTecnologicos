using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class RecursoTecnologico
    {
        private string nombre;
        private int numeroRT;
        private DateTime fechaAlta;
        private int idModelo;
        private int idCambioEstadoRT;
        private int idTipoRecurso;
        private int idCentroInvestigacion;
        private string periodicidadMantenimientoPrev;
        private string duracionMantenimientoPrev;
        private string fraccionHorarioTurnos;
        private int idTurnos;


        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public int IdModelo { get => idModelo; set => idModelo = value; }
        public int IdCambioEstadoRT { get => idCambioEstadoRT; set => idCambioEstadoRT = value; }
        public int IdTipoRecurso { get => idTipoRecurso; set => idTipoRecurso = value; }
        public int IdCentroInvestigacion { get => idCentroInvestigacion; set => idCentroInvestigacion = value; }
        public int NumeroRT { get => numeroRT; set => numeroRT = value; }
        public string PeriodicidadMantenimientoPrev { get => periodicidadMantenimientoPrev; set => periodicidadMantenimientoPrev = value; }
        public string DuracionMantenimientoPrev { get => duracionMantenimientoPrev; set => duracionMantenimientoPrev = value; }
        public string FraccionHorarioTurnos { get => fraccionHorarioTurnos; set => fraccionHorarioTurnos = value; }
        public int IdTurnos { get => idTurnos; set => idTurnos = value; }

        Turno turno = new Turno();

        //public List<RecursoTecnologico> getRecursosTecnologicos()
        //{
        //    Modelo modelo = new Modelo();
        //    DataTable listaModelo = modelo.getModelo();

        //    TipoRecurso tipoRt = new TipoRecurso();
        //    DataTable listaTiposRt = tipoRt.getTipoRecurso();

        //    CentroInvestigacion centroInvestigacion = new CentroInvestigacion();
        //    List<CentroInvestigacion> listaCentroInv = centroInvestigacion.getCentroInvestigacion();

        //    CambioEstadoRT cambioEstadoRT = new CambioEstadoRT();
        //    (List<CambioEstadoRT> listaCambioEstadoRT1, List<CambioEstadoRT> listaCambioEstadoRT2) = cambioEstadoRT.getCambioEstadoRT();

        //    List<RecursoTecnologico> listaRecursosTecnologicos = new List<RecursoTecnologico>();

        //    List<Turno> turnos = turno.getTurnos();


        //    //BALANZA DE PRECISION RESERVABLE
        //    RecursoTecnologico recursoTecnologico1 = new RecursoTecnologico();
        //    recursoTecnologico1.nombre = "recurso tipo Balanza de precisión";
        //    recursoTecnologico1.numeroRT = 1;
        //    recursoTecnologico1.imagen = "imagen1";
        //    recursoTecnologico1.fechaAlta = DateTime.Now;
        //    recursoTecnologico1.periodicidadMantenimientoPrev = "cada 10 meses";
        //    recursoTecnologico1.duracionMantenimientoPrev = "1 semana";
        //    recursoTecnologico1.fraccionHorarioTurnos = "15 minutos";
        //    recursoTecnologico1.tipoRecurso = listaTiposRt[0];
        //    recursoTecnologico1.centroInvestigacion = listaCentroInv[0];
        //    recursoTecnologico1.cambioEstadoRT = listaCambioEstadoRT1;
        //    recursoTecnologico1.modelo = listaModelo[0];
        //    recursoTecnologico1.listaTurnos = turnos;

        //    listaRecursosTecnologicos.Add(recursoTecnologico1);

        //    // BALANZA DE PRECISION RESERVABLE
        //    RecursoTecnologico recursoTecnologico2 = new RecursoTecnologico();
        //    recursoTecnologico2.nombre = "recurso tipo BALANZA DE PRECISION";
        //    recursoTecnologico2.numeroRT = 2;
        //    recursoTecnologico2.imagen = "imagen2";
        //    recursoTecnologico2.fechaAlta = DateTime.Now;
        //    recursoTecnologico2.periodicidadMantenimientoPrev = "cada 3 meses";
        //    recursoTecnologico2.duracionMantenimientoPrev = "45 semana";
        //    recursoTecnologico2.fraccionHorarioTurnos = "15 minutos";
        //    recursoTecnologico2.tipoRecurso = listaTiposRt[0];
        //    recursoTecnologico2.centroInvestigacion = listaCentroInv[1];
        //    recursoTecnologico2.cambioEstadoRT = listaCambioEstadoRT2;
        //    recursoTecnologico2.modelo = listaModelo[1];
        //    recursoTecnologico2.listaTurnos = turnos;


        //    listaRecursosTecnologicos.Add(recursoTecnologico2);

        //    // RESONADOR CON ESTADO RESERVABLE
        //    RecursoTecnologico recursoTecnologico3 = new RecursoTecnologico();
        //    recursoTecnologico3.nombre = "recurso tipo Resonador Magnetico";
        //    recursoTecnologico3.numeroRT = 3;
        //    recursoTecnologico3.imagen = "imagen3";
        //    recursoTecnologico3.fechaAlta = DateTime.Now;
        //    recursoTecnologico3.periodicidadMantenimientoPrev = "cada 1 año";
        //    recursoTecnologico3.duracionMantenimientoPrev = "9 meses";
        //    recursoTecnologico3.fraccionHorarioTurnos = "15 minutos";
        //    recursoTecnologico3.tipoRecurso = listaTiposRt[2];
        //    recursoTecnologico3.centroInvestigacion = listaCentroInv[2];
        //    recursoTecnologico3.cambioEstadoRT = listaCambioEstadoRT1;
        //    recursoTecnologico3.modelo = listaModelo[2];
        //    recursoTecnologico3.listaTurnos = turnos;


        //    listaRecursosTecnologicos.Add(recursoTecnologico3);

        //    return listaRecursosTecnologicos;

        //}

        public DataTable getRecursosTecnologicos(string nombreRecursoSeleccionado)
        {
            RecursoTecnologicoDAO rtbd = new RecursoTecnologicoDAO();
            DataTable tablaRTseleccionado = rtbd.getRecursosTecnologicos(nombreRecursoSeleccionado);
            return tablaRTseleccionado;
        }

        public DataTable getTurnos(DataTable asignacionPersonalLogueado)
        {
            Turno turno = new Turno();
            DataTable estadoTurnosActuales = turno.getTurnos(asignacionPersonalLogueado);
            return estadoTurnosActuales;
        }

        public DataTable esDeTipoRtSeleccionado(string tipoRtSeleccionado)
        {
            RecursoTecnologicoDAO rtBaseDatos = new RecursoTecnologicoDAO();
            DataTable tablaTipoRt = rtBaseDatos.BuscarRtPorTipo(tipoRtSeleccionado);
            return tablaTipoRt;
        }

        public Boolean esReservable(List<RecursoTecnologico> listaRTdeTipoRT)
        {
            Boolean bandera = false;
            foreach(RecursoTecnologico rt in listaRTdeTipoRT)
            {
                if (rt.idCambioEstadoRT == 1)
                    bandera = true;
                else
                    bandera = false;
            }
            return bandera;
        }

        //busca marca y modelo
        //public (List<string>, List<string>) getMarcaModelo(List<RecursoTecnologico> listaRTReservable)
        //{
        //    Modelo modelo = new Modelo();

        //    List<string> listaModelos = new List<string>();
        //    List<string> listaMarca = new List<string>();

        //    string nombreModelo = " ";
        //    string nombreMarca = " ";

        //    foreach (RecursoTecnologico rt in listaRTReservable)
        //    {
        //        (nombreMarca, nombreModelo) = modelo.getMarcaModelo(rt);
        //        listaModelos.Add(nombreModelo);
        //        listaMarca.Add(nombreMarca);
        //    }

        //    return (listaMarca, listaModelos);
        //}

        //public List<string> getCentroInvestigacion(List<RecursoTecnologico> listaRTReservable)
        //{
        //    CentroInvestigacion centroInvestigacion = new CentroInvestigacion();
        //    List<string> listaCentroInvestigacion = new List<string>();
        //    string nombreCentroInvestigacion = " ";

        //    foreach (RecursoTecnologico rt in listaRTReservable)
        //    {
        //        nombreCentroInvestigacion = centroInvestigacion.getNombre(rt);
        //        listaCentroInvestigacion.Add(nombreCentroInvestigacion);
        //    }

        //    return listaCentroInvestigacion;
        //}

        public DataTable getRecursosTecnologicosPorNumero(DataTable tablaRtActualesReservable)
        {
            RecursoTecnologicoDAO rtbd = new RecursoTecnologicoDAO();
            DataTable tablaRt = rtbd.getRecursosTecnologicosPorNumero(tablaRtActualesReservable);
            return tablaRt;
        }

        //public (bool, PersonalCientifico) esCientificoDelCentroDeInvestigacion(Usuario cientificoLogeado)
        //{
        //    Boolean bandera;
        //    PersonalCientifico logeadoCientifico;

        //    (bandera, logeadoCientifico) = centroInvestigacion.esAsignado(cientificoLogeado);
        //    return (bandera, logeadoCientifico);
        //}

        public DataTable esCientificoDelCentroDeInvestigacion(DataTable usuarioLogeado, DataTable tablaRTseleccionado)
        {

            CentroInvestigacion centroInvestigacion = new CentroInvestigacion();
            DataTable centroInvestigacionRtSeleccioando = centroInvestigacion.esAsignado(usuarioLogeado, tablaRTseleccionado);
            return centroInvestigacionRtSeleccioando;
        }

        public (Turno, string) reservar(Estado estadoReservado, Turno turnoSeleccionado, PersonalCientifico pesrsonalCientificoLogeado)
        {
            String nombreEstadoActual = "";
           // nombreEstadoActual = turno.reservar(estadoReservado, turnoSeleccionado);
            //   centroInvestigacion.asignarTurno(turnoSeleccionado, pesrsonalCientificoLogeado);

            return (turnoSeleccionado, nombreEstadoActual);
        }



    }
}
