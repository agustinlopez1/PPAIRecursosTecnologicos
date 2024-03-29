﻿using PPAIRecursosTecnologicos.AccesoADatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAIRecursosTecnologicos.Entidades
{
    public class PersonalCientifico
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private int numeroDocumento;
        private string correoElectronicoInstitucional;
        private string correoElectronicoPersonal;
        private int telefonoCelular;

        public int Legajo { get => legajo; set => legajo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroDocumento { get => numeroDocumento; set => numeroDocumento = value; }
        public string CorreoElectronicoInstitucional { get => correoElectronicoInstitucional; set => correoElectronicoInstitucional = value; }
        public string CorreoElectronicoPersonal { get => correoElectronicoPersonal; set => correoElectronicoPersonal = value; }
        public int TelefonoCelular { get => telefonoCelular; set => telefonoCelular = value; }


        public string generarPersonalCientifico(DataTable usuarioLogeado)
        {
            PersonalCientificoDAO personalCientificobd = new PersonalCientificoDAO();
            Utils util = new Utils();

            //obtiene nombre usuario logueado
            string nombreUsuario = util.ObtenerNombreUsuarioLogueado(usuarioLogeado);

            DataTable personalCientidicoLogueado = personalCientificobd.getPersonalCientifico(nombreUsuario);

            //obtiene legajo del usuario logueado
            string legajoPc = util.ObtenerLegajoPersonalCientifico(personalCientidicoLogueado);
            return legajoPc;
        }
    }
}
