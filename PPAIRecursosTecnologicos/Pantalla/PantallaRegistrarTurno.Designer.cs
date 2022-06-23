
namespace PPAIRecursosTecnologicos.Pantalla
{
    partial class PantallaRegistrarTurno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.botonSeleccionarTurno = new System.Windows.Forms.Button();
            this.grid_turno = new System.Windows.Forms.DataGridView();
            this.fechaHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_turno)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 36);
            this.label2.TabIndex = 16;
            this.label2.Text = "Seleccion  Turno";
            // 
            // botonSeleccionarTurno
            // 
            this.botonSeleccionarTurno.BackColor = System.Drawing.Color.SteelBlue;
            this.botonSeleccionarTurno.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonSeleccionarTurno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonSeleccionarTurno.FlatAppearance.BorderSize = 0;
            this.botonSeleccionarTurno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.botonSeleccionarTurno.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSeleccionarTurno.ForeColor = System.Drawing.Color.White;
            this.botonSeleccionarTurno.Location = new System.Drawing.Point(213, 345);
            this.botonSeleccionarTurno.Name = "botonSeleccionarTurno";
            this.botonSeleccionarTurno.Size = new System.Drawing.Size(101, 35);
            this.botonSeleccionarTurno.TabIndex = 31;
            this.botonSeleccionarTurno.Text = "Seleccionar";
            this.botonSeleccionarTurno.UseVisualStyleBackColor = false;
            this.botonSeleccionarTurno.Click += new System.EventHandler(this.botonSeleccionarTurno_Click);
            // 
            // grid_turno
            // 
            this.grid_turno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_turno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fechaHoraInicio,
            this.fechaHoraFin,
            this.estado});
            this.grid_turno.Location = new System.Drawing.Point(36, 104);
            this.grid_turno.Name = "grid_turno";
            this.grid_turno.Size = new System.Drawing.Size(468, 201);
            this.grid_turno.TabIndex = 32;
            // 
            // fechaHoraInicio
            // 
            this.fechaHoraInicio.HeaderText = "Fecha hora inicio";
            this.fechaHoraInicio.Name = "fechaHoraInicio";
            // 
            // fechaHoraFin
            // 
            this.fechaHoraFin.HeaderText = "Fecha hora fin";
            this.fechaHoraFin.Name = "fechaHoraFin";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // PantallaRegistrarTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPAIRecursosTecnologicos.Properties.Resources.maxresdefault3;
            this.ClientSize = new System.Drawing.Size(589, 428);
            this.Controls.Add(this.botonSeleccionarTurno);
            this.Controls.Add(this.grid_turno);
            this.Controls.Add(this.label2);
            this.Name = "PantallaRegistrarTurno";
            this.Text = "Seleccionar turno";
            ((System.ComponentModel.ISupportInitialize)(this.grid_turno)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonSeleccionarTurno;
        private System.Windows.Forms.DataGridView grid_turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
    }
}