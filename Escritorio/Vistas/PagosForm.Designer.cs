namespace Escritorio.Vistas {
    partial class PagosForm {
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
            this.components = new System.ComponentModel.Container();
            this.lblFootball = new System.Windows.Forms.Label();
            this.tblPagoNomina = new System.Windows.Forms.DataGridView();
            this.pagoEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblTabla = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnAtrás = new System.Windows.Forms.Button();
            this.thCodEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thUltFecPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thSalario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thComisiones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblPagoNomina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoEmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFootball
            // 
            this.lblFootball.AutoSize = true;
            this.lblFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootball.Location = new System.Drawing.Point(381, 19);
            this.lblFootball.Name = "lblFootball";
            this.lblFootball.Size = new System.Drawing.Size(203, 37);
            this.lblFootball.TabIndex = 0;
            this.lblFootball.Text = "Football XXI";
            // 
            // tblPagoNomina
            // 
            this.tblPagoNomina.AutoGenerateColumns = false;
            this.tblPagoNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPagoNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thCodEmpleado,
            this.thNombres,
            this.thApellidos,
            this.thCargo,
            this.thUltFecPago,
            this.thSalario,
            this.thComisiones,
            this.thTotal});
            this.tblPagoNomina.DataSource = this.pagoEmpleadosBindingSource;
            this.tblPagoNomina.Location = new System.Drawing.Point(61, 128);
            this.tblPagoNomina.Name = "tblPagoNomina";
            this.tblPagoNomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPagoNomina.Size = new System.Drawing.Size(843, 268);
            this.tblPagoNomina.TabIndex = 1;
            // 
            // pagoEmpleadosBindingSource
            // 
            this.pagoEmpleadosBindingSource.DataSource = typeof(Compartido.Modelo.PagoEmpleados);
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabla.Location = new System.Drawing.Point(383, 87);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(198, 29);
            this.lblTabla.TabIndex = 2;
            this.lblTabla.Text = "Tabla de Pagos";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(314, 422);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(139, 24);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total a Pagar:";
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(404, 460);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(180, 34);
            this.btnPagar.TabIndex = 4;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.BtnPagar_Click);
            // 
            // btnAtrás
            // 
            this.btnAtrás.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtrás.Location = new System.Drawing.Point(797, 492);
            this.btnAtrás.Name = "btnAtrás";
            this.btnAtrás.Size = new System.Drawing.Size(107, 37);
            this.btnAtrás.TabIndex = 5;
            this.btnAtrás.Text = "Atrás";
            this.btnAtrás.UseVisualStyleBackColor = true;
            this.btnAtrás.Click += new System.EventHandler(this.BtnAtrás_Click);
            // 
            // thCodEmpleado
            // 
            this.thCodEmpleado.DataPropertyName = "Codigo";
            this.thCodEmpleado.HeaderText = "Código de Empleado";
            this.thCodEmpleado.Name = "thCodEmpleado";
            // 
            // thNombres
            // 
            this.thNombres.DataPropertyName = "Nombres";
            this.thNombres.HeaderText = "Nombres";
            this.thNombres.Name = "thNombres";
            // 
            // thApellidos
            // 
            this.thApellidos.DataPropertyName = "Apellidos";
            this.thApellidos.HeaderText = "Apellidos";
            this.thApellidos.Name = "thApellidos";
            // 
            // thCargo
            // 
            this.thCargo.DataPropertyName = "Cargo";
            this.thCargo.HeaderText = "Cargo";
            this.thCargo.Name = "thCargo";
            // 
            // thUltFecPago
            // 
            this.thUltFecPago.DataPropertyName = "UltimaFechaPago";
            this.thUltFecPago.HeaderText = "Última fecha de pago";
            this.thUltFecPago.Name = "thUltFecPago";
            // 
            // thSalario
            // 
            this.thSalario.DataPropertyName = "SalarioBasico";
            this.thSalario.HeaderText = "Salario básico";
            this.thSalario.Name = "thSalario";
            // 
            // thComisiones
            // 
            this.thComisiones.DataPropertyName = "Comisiones";
            this.thComisiones.HeaderText = "Comisones";
            this.thComisiones.Name = "thComisiones";
            // 
            // thTotal
            // 
            this.thTotal.DataPropertyName = "SalarioComisiones";
            this.thTotal.HeaderText = "Salario más comisión";
            this.thTotal.Name = "thTotal";
            // 
            // PagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 541);
            this.Controls.Add(this.btnAtrás);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.tblPagoNomina);
            this.Controls.Add(this.lblFootball);
            this.Name = "PagosForm";
            this.Text = "PagosForm";
            ((System.ComponentModel.ISupportInitialize)(this.tblPagoNomina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagoEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootball;
        private System.Windows.Forms.DataGridView tblPagoNomina;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnAtrás;
        private System.Windows.Forms.BindingSource pagoEmpleadosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn thCodEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn thNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn thApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn thCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn thUltFecPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn thSalario;
        private System.Windows.Forms.DataGridViewTextBoxColumn thComisiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn thTotal;
    }
}