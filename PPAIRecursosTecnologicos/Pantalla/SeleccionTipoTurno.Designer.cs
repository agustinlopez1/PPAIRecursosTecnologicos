
namespace PPAIRecursosTecnologicos.Pantalla
{
    partial class PantallaSeleccionTipoRecurso
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
            this.groupBoxTipoRecurso = new System.Windows.Forms.GroupBox();
            this.botonSeleccionTipoRecurso = new System.Windows.Forms.Button();
            this.comboTipoRecurso = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.botonVolver = new System.Windows.Forms.Button();
            this.grid_rt = new System.Windows.Forms.DataGridView();
            this.centro_investigacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero_rt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTipoRecurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTipoRecurso
            // 
            this.groupBoxTipoRecurso.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTipoRecurso.Controls.Add(this.botonSeleccionTipoRecurso);
            this.groupBoxTipoRecurso.Controls.Add(this.comboTipoRecurso);
            this.groupBoxTipoRecurso.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxTipoRecurso.Location = new System.Drawing.Point(12, 158);
            this.groupBoxTipoRecurso.Name = "groupBoxTipoRecurso";
            this.groupBoxTipoRecurso.Size = new System.Drawing.Size(347, 232);
            this.groupBoxTipoRecurso.TabIndex = 0;
            this.groupBoxTipoRecurso.TabStop = false;
            this.groupBoxTipoRecurso.Text = "Seleccion tipo recurso tecnologico";
            // 
            // botonSeleccionTipoRecurso
            // 
            this.botonSeleccionTipoRecurso.BackColor = System.Drawing.Color.SteelBlue;
            this.botonSeleccionTipoRecurso.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonSeleccionTipoRecurso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonSeleccionTipoRecurso.FlatAppearance.BorderSize = 0;
            this.botonSeleccionTipoRecurso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.botonSeleccionTipoRecurso.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSeleccionTipoRecurso.ForeColor = System.Drawing.Color.White;
            this.botonSeleccionTipoRecurso.Location = new System.Drawing.Point(113, 173);
            this.botonSeleccionTipoRecurso.Name = "botonSeleccionTipoRecurso";
            this.botonSeleccionTipoRecurso.Size = new System.Drawing.Size(101, 35);
            this.botonSeleccionTipoRecurso.TabIndex = 16;
            this.botonSeleccionTipoRecurso.Text = "Seleccionar";
            this.botonSeleccionTipoRecurso.UseVisualStyleBackColor = false;
            this.botonSeleccionTipoRecurso.Click += new System.EventHandler(this.botonSeleccionTipoRecurso_Click);
            // 
            // comboTipoRecurso
            // 
            this.comboTipoRecurso.AccessibleName = "";
            this.comboTipoRecurso.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboTipoRecurso.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoRecurso.ForeColor = System.Drawing.SystemColors.Window;
            this.comboTipoRecurso.FormattingEnabled = true;
            this.comboTipoRecurso.Location = new System.Drawing.Point(50, 42);
            this.comboTipoRecurso.Name = "comboTipoRecurso";
            this.comboTipoRecurso.Size = new System.Drawing.Size(258, 26);
            this.comboTipoRecurso.TabIndex = 0;
            this.comboTipoRecurso.Text = "Todos";
            this.comboTipoRecurso.SelectedIndexChanged += new System.EventHandler(this.comboTipoRecurso_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Dubai", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(220, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 36);
            this.label2.TabIndex = 15;
            this.label2.Text = "Seleccion Recurso Tecnologico";
            // 
            // botonVolver
            // 
            this.botonVolver.BackColor = System.Drawing.Color.SlateGray;
            this.botonVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonVolver.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonVolver.FlatAppearance.BorderSize = 0;
            this.botonVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.botonVolver.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonVolver.ForeColor = System.Drawing.Color.White;
            this.botonVolver.Location = new System.Drawing.Point(44, 407);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(89, 31);
            this.botonVolver.TabIndex = 29;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = false;
            this.botonVolver.Click += new System.EventHandler(this.botonVolver_Click);
            // 
            // grid_rt
            // 
            this.grid_rt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_rt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.centro_investigacion,
            this.nombre,
            this.numero_rt,
            this.estado,
            this.Modelo,
            this.Marca});
            this.grid_rt.Location = new System.Drawing.Point(441, 200);
            this.grid_rt.Name = "grid_rt";
            this.grid_rt.Size = new System.Drawing.Size(648, 116);
            this.grid_rt.TabIndex = 30;
            this.grid_rt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_rt_CellContentClick);
            // 
            // centro_investigacion
            // 
            this.centro_investigacion.HeaderText = "Centro Investigacion";
            this.centro_investigacion.Name = "centro_investigacion";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // numero_rt
            // 
            this.numero_rt.HeaderText = "Numero Inventario";
            this.numero_rt.Name = "numero_rt";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.Name = "Marca";
            // 
            // PantallaSeleccionTipoRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PPAIRecursosTecnologicos.Properties.Resources.maxresdefault3;
            this.ClientSize = new System.Drawing.Size(1157, 503);
            this.Controls.Add(this.grid_rt);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxTipoRecurso);
            this.Name = "PantallaSeleccionTipoRecurso";
            this.Text = "Seleccion Tipo Turno";
            this.groupBoxTipoRecurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_rt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTipoRecurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTipoRecurso;
        private System.Windows.Forms.Button botonSeleccionTipoRecurso;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.DataGridView grid_rt;
        private System.Windows.Forms.DataGridViewTextBoxColumn centro_investigacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero_rt;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
    }
}