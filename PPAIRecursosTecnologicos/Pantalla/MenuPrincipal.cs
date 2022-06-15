using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAIRecursosTecnologicos.Pantalla
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            PantallaRegistrarReserva ventana = new PantallaRegistrarReserva();
            ventana.Show();
            this.Hide();
        }

        private void botonSeleccionarTipoRecurso_Click(object sender, EventArgs e)
        {
            PantallaSeleccionTipoRecurso ventana = new PantallaSeleccionTipoRecurso();
            ventana.Show();

        }
    }
}
