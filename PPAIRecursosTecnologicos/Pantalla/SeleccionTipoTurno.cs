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

            pedirSeleccionRecursoTecnologico(listagestor);

        }

        // La pantalla le envía el tipo de recurso seleccionado al gestor para setear
        private string tomarSeleccionTipoRecursoTecnologico()
        {
            string tipoRecursoSeleccionado = comboTipoRecurso.SelectedItem.ToString();
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


        private void pedirSeleccionRecursoTecnologico(List<RecursoTecnologico> listagestor)
        {
            int columna = 0;
            int fila = 0;

            grid_rt.Rows.Clear();

                foreach (RecursoTecnologico rt in listagestor)
                {
                    grid_rt.Rows.Add();
                    //centro investigacion
                    grid_rt.Rows[fila].Cells[columna].Value = rt.CentroInvestigacion.Nombre;
                    columna++;

                    //nombre
                    grid_rt.Rows[fila].Cells[columna].Value = rt.Nombre;
                    columna++;

                    //nro inventario
                    grid_rt.Rows[fila].Cells[columna].Value = rt.NumeroRT;
                    columna++;

                //estado
                    //grid_rt.Rows[fila].Cells[columna].Value = rt.getEstado(rt);
                    columna++;

                    //modelo
                    //grid_rt.Rows[fila].Cells[columna].Value = rt.Modelo.Nombre;
                    columna++;

                    //marca
                    //grid_rt.Rows[fila].Cells[columna].Value = rt.Modelo;

                    columna++;

                    columna = 0;
                    fila++;
                }
        }
    }
}
