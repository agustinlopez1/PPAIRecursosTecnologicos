using PPAIRecursosTecnologicos.Gestor;
using PPAIRecursosTecnologicos.Pantalla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPAIRecursosTecnologicos
{
    public partial class PantallaRegistrarReserva : Form
    {
        GestorRegistrarReserva gestor = new GestorRegistrarReserva();

        // Esta entidad a traves del GESTOR es la encargada de levantar todos los datos de la DB al iniciar

        public PantallaRegistrarReserva()
        {
            InitializeComponent();
        }

        private void botonRegistrarReserva_Click(object sender, EventArgs e)
        {
            MenuPrincipal ventana = new MenuPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
