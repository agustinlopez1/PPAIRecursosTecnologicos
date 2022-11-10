using System;
using PPAIRecursosTecnologicos.Gestor;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAIRecursosTecnologicos.Entidades;
using PPAIRecursosTecnologicos.AccesoADatos;

namespace PPAIRecursosTecnologicos.Pantalla
{
    public partial class PantallaSeleccionTipoRecurso : Form
    {

        List<RecursoTecnologico> gestorLista;
        GestorRegistrarReserva gestor = new GestorRegistrarReserva();


        public PantallaSeleccionTipoRecurso()
        {
            InitializeComponent();
            pedirSeleccionTipoRecursoTecnologico();
            botonSeleccionTipoRecurso.Enabled = false;
        }

        // Se carga el combo box
        private void pedirSeleccionTipoRecursoTecnologico()
        {
            DataTable tablaTipoRT = gestor.buscarTipoRecursoTecnologico();
            Utils util = new Utils();
            List<string> listaTiport = util.ObtenerListaTipoRecursoTec(tablaTipoRT);

            comboTipoRecurso.DataSource = listaTiport;
            comboTipoRecurso.DisplayMember = "nombre";
        }

        // Verifica que se haya elegido un recurso para habilitar el boton "Seleccionar"
        private void comboTipoRecurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTipoRecurso.SelectedIndex != -1)
            {
                botonSeleccionTipoRecurso.Enabled = true;
            }
        }


        // Accion que se realiza al hacer click en "Seleccionar"
        private void botonSeleccionTipoRecurso_Click(object sender, EventArgs e)
        {
            string nombreEstadoRT = "";
            string nombreCentroIvestigacion = "";
            string nombreModelo = "";
            string nombreMarca = "";
            List<RecursoTecnologico> listaRTdeTipoRT = new List<RecursoTecnologico>();

            string tipoRecursoSeleccionado = tomarSeleccionTipoRecursoTecnologico();
            (nombreEstadoRT, nombreCentroIvestigacion, nombreModelo, nombreMarca, listaRTdeTipoRT) = gestor.tomarSeleccionTipoRecursoTecnologico(tipoRecursoSeleccionado);

            pedirSeleccionRecursoTecnologico(nombreEstadoRT, nombreCentroIvestigacion, nombreModelo, nombreMarca, listaRTdeTipoRT);
        }

        // La pantalla le envía el tipo de recurso seleccionado al gestor para setear
        private string tomarSeleccionTipoRecursoTecnologico()
        {
            string tipoRecursoSeleccionado = comboTipoRecurso.SelectedValue.ToString();
            return tipoRecursoSeleccionado;
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grid_rt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //carga grilla con los recursos tecnologicos reservables
        private void pedirSeleccionRecursoTecnologico(string nombreEstadoRT, string nombreCentroIvestigacion, string nombreModelo, string nombreMarca, List<RecursoTecnologico> listaRTdeTipoRT)
        {

            int columna = 0;
            int fila = 0;
            int estado = 0;
            int marca = 0;
            int modelo = 0;
            int centroInvestigacion = 0;

            grid_rt.Rows.Clear();

            foreach (RecursoTecnologico rt in listaRTdeTipoRT)
            {
                grid_rt.Rows.Add();
                //centro investigacion
                grid_rt.Rows[fila].Cells[columna].Value = nombreCentroIvestigacion;
                centroInvestigacion++;
                columna++;

                //nombre
                grid_rt.Rows[fila].Cells[columna].Value = rt.Nombre;
                columna++;

                //nro inventario
                grid_rt.Rows[fila].Cells[columna].Value = rt.NumeroRT;
                columna++;

                //estado
                grid_rt.Rows[fila].Cells[columna].Value = nombreEstadoRT;
                columna++;
                estado++;


                //marca
                grid_rt.Rows[fila].Cells[columna].Value = nombreMarca;
                columna++;
                marca++;

                //modelo
                grid_rt.Rows[fila].Cells[columna].Value = nombreModelo;
                columna++;
                modelo++;

                columna = 0;
                fila++;
            }
        }

        private void botonSeleccionarRT_Click(object sender, EventArgs e)
        {
            tomarSeleccionRecursoTecnologico();
            this.Hide();
        }

        //le envia al gestor el rt seleccionado
        //   private RecursoTecnologico tomarSeleccionRecursoTecnologico()
        //private void tomarSeleccionRecursoTecnologico()
        //{
        //    string nombreRecursoSeleccionado = grid_rt.CurrentRow.Cells[1].Value.ToString();
        //    RecursoTecnologico recursoSeleccionado = new RecursoTecnologico();

        //    foreach (RecursoTecnologico rt in gestorLista)
        //    {
        //        if (rt.Nombre == nombreRecursoSeleccionado)
        //        {
        //            recursoSeleccionado = rt;
        //        }
        //    }

        //    MessageBox.Show("Recurso seleccionado " + nombreRecursoSeleccionado);

        //    List<String> listaEstados = new List<String>();
        //    List<Turno> turnosPosteriorFecha = new List<Turno>();

        //    (turnosPosteriorFecha, listaEstados) = this.gestor.tomarSeleccionRecursoTecnologico(recursoSeleccionado);

        //    PantallaRegistrarTurno pantallaRegistrarTurno = new PantallaRegistrarTurno();
        //    pantallaRegistrarTurno.Show();
        //    pantallaRegistrarTurno.tomarGestor(gestor);
        //    pantallaRegistrarTurno.pedirSeleccionTurno(turnosPosteriorFecha, listaEstados);

        //    //return recursoSeleccionado;
        //}

        private void tomarSeleccionRecursoTecnologico()
        {
            string nombreRecursoSeleccionado = grid_rt.CurrentRow.Cells[1].Value.ToString();
            //buscar nombre del recurso seleccionado

            MessageBox.Show("Recurso seleccionado " + nombreRecursoSeleccionado);

            DataTable estadoTurnosActuales = this.gestor.tomarSeleccionRecursoTecnologico(nombreRecursoSeleccionado);

            PantallaRegistrarTurno pantallaRegistrarTurno = new PantallaRegistrarTurno();
            pantallaRegistrarTurno.Show();
            pantallaRegistrarTurno.tomarGestor(gestor);
            pantallaRegistrarTurno.pedirSeleccionTurno(estadoTurnosActuales);

            //return recursoSeleccionado;
        }
    }
}
