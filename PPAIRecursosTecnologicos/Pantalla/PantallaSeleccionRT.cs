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

            (List<RecursoTecnologico> listagestor, List<String> listaEstados, List<String> listaMarca, List<String> listaModelo, List<string> listaCentroInvestigacion) = gestor.tomarSeleccionTipoRecursoTecnologico(tipoRecursoSeleccionado);

            this.gestorLista = listagestor;

            pedirSeleccionRecursoTecnologico(listagestor, listaEstados, listaMarca, listaModelo, listaCentroInvestigacion);

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

        //carga grilla con los recursos tecnologicos reservables
        private void pedirSeleccionRecursoTecnologico(List<RecursoTecnologico> listagestor, List<string> listaEstados, List<String> listaMarca, List<String> listaModelo, List<string> listaCentroInvestigacion)
        {

            int columna = 0;
            int fila = 0;
            int estado = 0;
            int marca = 0;
            int modelo = 0;
            int centroInvestigacion = 0;

            grid_rt.Rows.Clear();

            foreach (RecursoTecnologico rt in listagestor)
            {
                grid_rt.Rows.Add();
                //centro investigacion
                grid_rt.Rows[fila].Cells[columna].Value = listaCentroInvestigacion[centroInvestigacion];
                centroInvestigacion++;
                columna++;

                //nombre
                grid_rt.Rows[fila].Cells[columna].Value = rt.Nombre;
                columna++;

                //nro inventario
                grid_rt.Rows[fila].Cells[columna].Value = rt.NumeroRT;
                columna++;

                //estado
                grid_rt.Rows[fila].Cells[columna].Value = listaEstados[estado];
                columna++;
                estado++;


                //marca
                grid_rt.Rows[fila].Cells[columna].Value = listaMarca[marca];
                columna++;
                marca++;

                //modelo
                grid_rt.Rows[fila].Cells[columna].Value = listaModelo[modelo];
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
        private void tomarSeleccionRecursoTecnologico()
        {
            string nombreRecursoSeleccionado = grid_rt.CurrentRow.Cells[1].Value.ToString();
            RecursoTecnologico recursoSeleccionado = new RecursoTecnologico();

            foreach (RecursoTecnologico rt in gestorLista)
            {
                if (rt.Nombre == nombreRecursoSeleccionado)
                {
                    recursoSeleccionado = rt;
                }
            }

            MessageBox.Show("Recurso seleccionado " + nombreRecursoSeleccionado);

            List<String> listaEstados = new List<String>();
            List<Turno> turnosPosteriorFecha = new List<Turno>();

            (turnosPosteriorFecha, listaEstados) = this.gestor.tomarSeleccionRecursoTecnologico(recursoSeleccionado);

            PantallaRegistrarTurno pantallaRegistrarTurno = new PantallaRegistrarTurno();
            pantallaRegistrarTurno.Show();
            pantallaRegistrarTurno.tomarGestor(gestor);
            pantallaRegistrarTurno.pedirSeleccionTurno(turnosPosteriorFecha, listaEstados);

            //return recursoSeleccionado;
        }
    }
}
