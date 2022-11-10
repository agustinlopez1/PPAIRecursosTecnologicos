using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class AsignacionCientificoDeCentroInvestigacion
    {
        private int idAsignacionCientificoCI;
        private int idPersonalCientifico;
        private int idTurno;

        public int IdPersonalCientifico { get => idPersonalCientifico; set => idPersonalCientifico = value; }
        public int IdTurno { get => idTurno; set => idTurno = value; }
        public int IdAsignacionCientificoCI { get => idAsignacionCientificoCI; set => idAsignacionCientificoCI = value; }

        //public AsignacionCientificoDeCentroInvestigacion getAsignacionCientificoDeCentroInvestigacion()
        //{

        //    PersonalCientifico personalCientifico = new PersonalCientifico();
        //    PersonalCientifico personal = personalCientifico.generarPersonalCientifico();

        //    Turno turno = new Turno();
        //    List<Turno> listaTurno = new List<Turno>();
        //    listaTurno = turno.getTurnos();


        //    AsignacionCientificoDeCentroInvestigacion aginacionCientifico = new AsignacionCientificoDeCentroInvestigacion();
        //    aginacionCientifico.personalCientifico = personal;
        //    aginacionCientifico.turno = listaTurno[0];

        //    return aginacionCientifico;
        //}

        //public DataTable getAsignacionCientificoDeCentroInvestigacion(DataTable usuarioLogeado)
        //{
        //    PersonalCientifico personalCientifico = new PersonalCientifico();
        //    DataTable personalCientificoLogueado = personalCientifico.generarPersonalCientifico(usuarioLogeado);

        //    AsignacionCientificaCAO asignacionbd = new AsignacionCientificaCAO();
        //    DataTable asignacionPersonal = asignacionbd.BuscarAsignacionPersonal(personalCientificoLogueado);
        //    return asignacionPersonal;
        //}


        //public (bool, PersonalCientifico) esTuCientifico(Usuario usuario)
        //{
        //    AsignacionCientificoDeCentroInvestigacion asignacion = getAsignacionCientificoDeCentroInvestigacion();
        //    PersonalCientifico logeadoCientifico;

        //    if (asignacion.personalCientifico.Nombre + asignacion.personalCientifico.Apellido == usuario.Nombre)
        //    {
        //        logeadoCientifico = asignacion.personalCientifico;
        //        return (true, logeadoCientifico);
        //    }
        //    else
        //    {
        //        return (false, null);
        //    }
        //}

        public DataTable esTuCientifico(DataTable usuarioLogeado)
        {
            PersonalCientifico personalCientifico = new PersonalCientifico();
            DataTable asignacionPersonalLogueado = personalCientifico.generarPersonalCientifico(usuarioLogeado);

            return asignacionPersonalLogueado;
        }

        public void setTurno(Turno turnoSeleccionado, PersonalCientifico personalCientificoLogueado)
        {
            AsignacionCientificoDeCentroInvestigacion aginacionCientificoNueva = getAsignacionCientificoDeCentroInvestigacion();
            aginacionCientificoNueva.personalCientifico = personalCientificoLogueado;
            aginacionCientificoNueva.turno = turnoSeleccionado;

        }
    }
}
