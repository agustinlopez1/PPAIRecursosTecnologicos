using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAIRecursosTecnologicos.Entidades;
using PPAIRecursosTecnologicos.Gestor;

namespace PPAIRecursosTecnologicos.Pantalla
{
    public partial class PantallaRegistrarTurno : Form
    {

        private List<Turno> listaTurnos;
        private static Turno turnoSeleccionado;

   //     GestorRegistrarReserva gestor = new GestorRegistrarReserva();


        public PantallaRegistrarTurno()
        {
            InitializeComponent();
        }

        public void pedirSeleccionTurno(List<Turno> turnosPosteriorFecha, List<String> listaEstados)
        {
            int columna = 0;
            int fila = 0;
            int estado = 0;

            listaTurnos = turnosPosteriorFecha;

            grid_turno.Rows.Clear();

            foreach (Turno turno in turnosPosteriorFecha)
            {
                grid_turno.Rows.Add();
                //fecha hora inicio
                grid_turno.Rows[fila].Cells[columna].Value = turno.FechaHoraInicio;
                columna++;

                //fecha hora fin
                grid_turno.Rows[fila].Cells[columna].Value = turno.FechaHoraFin;
                columna++;

                //estado
                grid_turno.Rows[fila].Cells[columna].Value = listaEstados[estado];
                columna++;
                estado++;

                columna = 0;
                fila++;
            }
        }

        private void botonSeleccionarTurno_Click(object sender, EventArgs e)
        {
            tomarSeleccionTurno();
            this.Hide();
        }

        //toma la seleccion del usuario y se la envia al gestor
        public  void tomarSeleccionTurno()
        {
            DateTime fechaTurno = (DateTime)grid_turno.CurrentRow.Cells[0].Value;

            foreach (Turno turno in listaTurnos)
            {
                if (fechaTurno == turno.FechaHoraInicio)
                {
                    turnoSeleccionado = turno;
                }
            }

            GestorRegistrarReserva.tomarSeleccionTurno(turnoSeleccionado);
        }

        public static void mostrarDatosTurno(Turno turnoSeleccionado)
        {

            String datosTurno = "Datos del turno:" +
                                "\n Fecha hora inicio: " + turnoSeleccionado.FechaHoraInicio  +
                                "\n Fecha hora fin: " + turnoSeleccionado.FechaHoraFin +
                                "\n Fecha generacion: " + turnoSeleccionado.FechaGeneracion;

            String datosTurno1 = "Datos actualizados del turno:" +
                    "\n Fecha hora inicio: " + turnoSeleccionado.FechaHoraInicio +
                    "\n Fecha hora fin: " + turnoSeleccionado.FechaHoraFin +
                    "\n Fecha generacion: " + turnoSeleccionado.FechaGeneracion +
                    "\n Estado: reservado";

            DialogResult dialogResult = MessageBox.Show(datosTurno, "Confirmar turno", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Turno confirmado correctamente");
                //GestorRegistrarReserva.tomarConfirmacionReserva();
                MessageBox.Show(datosTurno1);

            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("No se confirmo el turno seleccionado");
            }

        }


        
    }
}
