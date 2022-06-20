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

namespace PPAIRecursosTecnologicos.Pantalla
{
    public partial class PantallaSeleccionTipoRecurso : Form
    {
        public PantallaSeleccionTipoRecurso()
        {
            InitializeComponent();
            pedirSeleccionTipoRecursoTecnologico();
            botonSeleccionTipoRecurso.Enabled = false;
        }

        // Se carga el combo box
        private void pedirSeleccionTipoRecursoTecnologico()
        {
            GestorRegistrarReserva gestor = new GestorRegistrarReserva();
            List<string> listagestor = gestor.buscarTipoRecursoTecnologico();

            foreach (String tipo in listagestor)
            {
                comboTipoRecurso.Items.Add(tipo);
            }
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
            string tipoRecursoSeleccionado = tomarSeleccionTipoRecursoTecnologico();

            GestorRegistrarReserva gestor = new GestorRegistrarReserva();
            List<RecursoTecnologico> listagestor = gestor.tomarSeleccionTipoRecursoTecnologico(tipoRecursoSeleccionado);

            cargarGrid(listagestor);

        }

        // La pantalla le envía el tipo de recurso seleccionado al gestor para setear
        private string tomarSeleccionTipoRecursoTecnologico()
        {
            //GestorRegistrarReserva gestor = new GestorRegistrarReserva();
            //MessageBox.Show(comboTipoRecurso.SelectedItem.ToString());
            //gestor.tomarSeleccionTipoRecursoTecnologico(comboTipoRecurso.SelectedItem.ToString());
            string tipoRecursoSeleccionado = comboTipoRecurso.SelectedItem.ToString();
            return tipoRecursoSeleccionado;

            //  pedirSeleccionRecursoTecnologico(null);
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


        private void cargarGrid(List<RecursoTecnologico> listagestor)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(grid_rt);
            fila.Cells[0].Value = "ok";
            grid_rt.Rows.Add(fila);

            //foreach (RecursoTecnologico rt in listagestor)
            //{


            //    //  fila.Cells[0].Value = rt.CentroInvestigacion;
            //    fila.Cells[0].Value = "hola";
            //    fila.Cells[1].Value = rt.Nombre;
            //    fila.Cells[2].Value = rt.NumeroRT;
            //    //fila.Cells[3].Value = rt.Estado;
            //    //fila.Cells[4].Value = rt.Modelo;
            //    //fila.Cells[5].Value = rt.Marca;

            //    grid_rt.Rows.Add(fila);
            //}
        }

        public void pedirSeleccionRecursoTecnologico(List<RecursoTecnologico> listagestor)
        {
            GestorRegistrarReserva gestor = new GestorRegistrarReserva();
            gestor.tomarSeleccionTipoRecursoTecnologico(comboTipoRecurso.SelectedItem.ToString());

            //DataGridViewRow fila = new DataGridViewRow();
            //fila.CreateCells(grid_rt);
            //fila.Cells[0].Value = "ok";
            //grid_rt.Rows.Add(fila);


            //foreach (RecursoTecnologico rt in listagestor)
            //{


            //    //  fila.Cells[0].Value = rt.CentroInvestigacion;
            //    fila.Cells[0].Value = "hola";
            //    fila.Cells[1].Value = rt.Nombre;
            //    fila.Cells[2].Value = rt.NumeroRT;
            //    //fila.Cells[3].Value = rt.Estado;
            //    //fila.Cells[4].Value = rt.Modelo;
            //    //fila.Cells[5].Value = rt.Marca;

            //    grid_rt.Rows.Add(fila);


            //    grid_rt.Rows.Add();
            //    grid_rt.Rows[1].Cells[0].Value = rt.Nombre;
            //    grid_rt.Rows[1].Cells[1].Value = "FACTURA";
            //}

            //grid_rt.Rows.Add();
            //grid_rt.Rows[1].Cells[1].Value = "FACTURA";
        }
    }
}
