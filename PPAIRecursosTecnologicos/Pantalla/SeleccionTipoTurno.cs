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
            cargarComboTipoRecurso();
            botonSeleccionTipoRecurso.Enabled = false;

        }

        // Se carga el combo box
        private void cargarComboTipoRecurso()
        {
            GestorRegistrarReserva gestor = new GestorRegistrarReserva();
            List<TipoRecurso> listagestor = gestor.buscarTipoRecursoTecnologico();

            foreach (TipoRecurso tipo in listagestor)
            {
                comboTipoRecurso.Items.Add(tipo.Nombre);
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
             tomarSeleccionTipoRecursoTecnologico();
        }

        // La pantalla le envía el tipo de recurso seleccionado al gestor para setear
        private void tomarSeleccionTipoRecursoTecnologico()
        {
            GestorRegistrarReserva gestor = new GestorRegistrarReserva();
            MessageBox.Show(comboTipoRecurso.SelectedItem.ToString());
            gestor.setearTipoRecurso(comboTipoRecurso.SelectedItem.ToString());
            
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
