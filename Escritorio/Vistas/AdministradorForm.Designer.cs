namespace Escritorio.Vistas {
    partial class AdministradorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblFootball = new System.Windows.Forms.Label();
            this.btnCrearUsuarios = new System.Windows.Forms.Button();
            this.btnVerUsuarios = new System.Windows.Forms.Button();
            this.btnVerReportes = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnPagarNomina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFootball
            // 
            this.lblFootball.AutoSize = true;
            this.lblFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootball.Location = new System.Drawing.Point(123, 46);
            this.lblFootball.Name = "lblFootball";
            this.lblFootball.Size = new System.Drawing.Size(159, 29);
            this.lblFootball.TabIndex = 0;
            this.lblFootball.Text = "Football XXI";
            this.lblFootball.Click += new System.EventHandler(this.LblFootball_Click);
            // 
            // btnCrearUsuarios
            // 
            this.btnCrearUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuarios.Location = new System.Drawing.Point(89, 102);
            this.btnCrearUsuarios.Name = "btnCrearUsuarios";
            this.btnCrearUsuarios.Size = new System.Drawing.Size(246, 50);
            this.btnCrearUsuarios.TabIndex = 1;
            this.btnCrearUsuarios.Text = "Crear Empleado";
            this.btnCrearUsuarios.UseVisualStyleBackColor = true;
            this.btnCrearUsuarios.Click += new System.EventHandler(this.BtnCrearUsuarios_Click);
            // 
            // btnVerUsuarios
            // 
            this.btnVerUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerUsuarios.Location = new System.Drawing.Point(89, 175);
            this.btnVerUsuarios.Name = "btnVerUsuarios";
            this.btnVerUsuarios.Size = new System.Drawing.Size(246, 48);
            this.btnVerUsuarios.TabIndex = 2;
            this.btnVerUsuarios.Text = "Ver Empleados";
            this.btnVerUsuarios.UseVisualStyleBackColor = true;
            this.btnVerUsuarios.Click += new System.EventHandler(this.BtnVerUsuarios_Click);
            // 
            // btnVerReportes
            // 
            this.btnVerReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReportes.Location = new System.Drawing.Point(89, 240);
            this.btnVerReportes.Name = "btnVerReportes";
            this.btnVerReportes.Size = new System.Drawing.Size(246, 51);
            this.btnVerReportes.TabIndex = 3;
            this.btnVerReportes.Text = "Ver Reportes";
            this.btnVerReportes.UseVisualStyleBackColor = true;
            this.btnVerReportes.Click += new System.EventHandler(this.BtnVerReportes_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(89, 458);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(246, 39);
            this.btnCerrarSesion.TabIndex = 4;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.BtnCerrarSesion_Click);
            // 
            // btnPagarNomina
            // 
            this.btnPagarNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarNomina.Location = new System.Drawing.Point(89, 318);
            this.btnPagarNomina.Name = "btnPagarNomina";
            this.btnPagarNomina.Size = new System.Drawing.Size(246, 46);
            this.btnPagarNomina.TabIndex = 5;
            this.btnPagarNomina.Text = "Pagar Nómina";
            this.btnPagarNomina.UseVisualStyleBackColor = true;
            this.btnPagarNomina.Click += new System.EventHandler(this.BtnPagarNomina_Click);
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 521);
            this.Controls.Add(this.btnPagarNomina);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnVerReportes);
            this.Controls.Add(this.btnVerUsuarios);
            this.Controls.Add(this.btnCrearUsuarios);
            this.Controls.Add(this.lblFootball);
            this.Name = "AdministradorForm";
            this.Text = "AdministradorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootball;
        private System.Windows.Forms.Button btnCrearUsuarios;
        private System.Windows.Forms.Button btnVerUsuarios;
        private System.Windows.Forms.Button btnVerReportes;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnPagarNomina;
    }
}