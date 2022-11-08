
namespace PPAIRecursosTecnologicos
{
    partial class PantallaRegistrarReserva
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonRegistrarReserva = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonRegistrarReserva
            // 
            this.botonRegistrarReserva.BackColor = System.Drawing.Color.SteelBlue;
            this.botonRegistrarReserva.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonRegistrarReserva.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonRegistrarReserva.FlatAppearance.BorderSize = 0;
            this.botonRegistrarReserva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.botonRegistrarReserva.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonRegistrarReserva.ForeColor = System.Drawing.Color.White;
            this.botonRegistrarReserva.Location = new System.Drawing.Point(271, 303);
            this.botonRegistrarReserva.Name = "botonRegistrarReserva";
            this.botonRegistrarReserva.Size = new System.Drawing.Size(178, 67);
            this.botonRegistrarReserva.TabIndex = 2;
            this.botonRegistrarReserva.Text = "Registrar Turno";
            this.botonRegistrarReserva.UseVisualStyleBackColor = false;
            this.botonRegistrarReserva.Click += new System.EventHandler(this.botonRegistrarReserva_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SlateGray;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Dubai", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(294, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(393, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "Gestión de Recursos Tecnologicos";
            // 
            // botonSalir
            // 
            this.botonSalir.BackColor = System.Drawing.Color.SlateGray;
            this.botonSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.botonSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.botonSalir.FlatAppearance.BorderSize = 0;
            this.botonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(227)))));
            this.botonSalir.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonSalir.ForeColor = System.Drawing.Color.White;
            this.botonSalir.Location = new System.Drawing.Point(670, 403);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(105, 35);
            this.botonSalir.TabIndex = 29;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = false;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // PantallaRegistrarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::PPAIRecursosTecnologicos.Properties.Resources.maxresdefault3;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botonRegistrarReserva);
            this.MaximizeBox = false;
            this.Name = "PantallaRegistrarReserva";
            this.Text = "Registrar Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonRegistrarReserva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonSalir;
    }
}

