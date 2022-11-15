using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PPAIRecursosTecnologicos.AccesoADatos;
using PPAIRecursosTecnologicos.Entidades;
using PPAIRecursosTecnologicos.Gestor;

namespace PPAIRecursosTecnologicos.Pantalla
{
    public partial class PantallaRegistrarTurno : Form
    {

        private List<Turno> listaTurnos;
        private Turno turnoSeleccionado;
        private GestorRegistrarReserva gestorRegistrar;

        public PantallaRegistrarTurno()
        {
            InitializeComponent();
        }

        public void tomarGestor(GestorRegistrarReserva gestor)
        {
            gestorRegistrar = gestor;
        }

        public void pedirSeleccionTurno(List<string> listaestado, List<Turno> listaTurno)
        {
            int columna = 0;
            int fila = 0;
            int estado = 0;

            grid_turno.Rows.Clear();

            foreach (Turno turno in listaTurno)
            {
                grid_turno.Rows.Add();
                //fecha hora inicio
                grid_turno.Rows[fila].Cells[columna].Value = turno.FechaHoraInicio;
                columna++;

                //fecha hora fin
                grid_turno.Rows[fila].Cells[columna].Value = turno.FechaHoraFin;
                columna++;

                //estado
                grid_turno.Rows[fila].Cells[columna].Value = listaestado[estado];
                columna++;
                estado++;

                columna = 0;
                fila++;
            }
        }

        private void botonSeleccionarTurno_Click(object sender, EventArgs e)
        {
            tomarSeleccionTurno();
        }

        //toma la seleccion del usuario y se la envia al gestor
        public void tomarSeleccionTurno()
        {
            DateTime fechaTurno = (DateTime)grid_turno.CurrentRow.Cells[0].Value;

            DataTable turnoSeleccionado = gestorRegistrar.tomarSeleccionTurno(fechaTurno);
            mostrarDatosTurno(turnoSeleccionado);
        }


        public void mostrarDatosTurno(DataTable turnoSeleccionado)
        {
            string datosTurno = "";
            Utils util = new Utils();
            List<Turno> tablaTurnoSeleccionado = util.ObtenerTablaTurnoSeleccionado(turnoSeleccionado);

            foreach (Turno turno in tablaTurnoSeleccionado)
            {
                  datosTurno = "Datos del turno:" +
                    "\n Fecha hora inicio: " + turno.FechaHoraInicio +
                    "\n Fecha hora fin: " + turno.FechaHoraFin;
            }

            DialogResult dialogResult = MessageBox.Show(datosTurno, "Confirmar turno", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Turno confirmado correctamente");
                (List<Turno> ListaTurnoSeleccionado, List<string> listaestado) = gestorRegistrar.tomarConfirmacionReserva();
                mostrarTurnoSeleccionado(listaestado, ListaTurnoSeleccionado);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("No se confirmo el turno seleccionado");
            }

        }

        public void mostrarTurnoSeleccionado(List<string> nombreEstadoActual, List<Turno> turnoActualizado)
        {
            int columna = 0;
            int fila = 0;
            int estado = 0;

            grid_turno.Rows.Clear();

            foreach (Turno turno in turnoActualizado)
            {
                grid_turno.Rows.Add();
                //fecha hora inicio
                grid_turno.Rows[fila].Cells[columna].Value = turno.FechaHoraInicio;
                columna++;

                //fecha hora fin
                grid_turno.Rows[fila].Cells[columna].Value = turno.FechaHoraFin;
                columna++;

                //estado
                grid_turno.Rows[fila].Cells[columna].Value = nombreEstadoActual[estado];
                columna++;
                estado++;

                columna = 0;
                fila++;
            }
        }

        private void botonVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turno impreso correctamente");
        }
    }
}
