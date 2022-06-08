using PPAIRecursosTecnologicos.Gestor;
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
    }
}
