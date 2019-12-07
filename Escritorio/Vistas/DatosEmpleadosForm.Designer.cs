namespace Escritorio.Vistas {
    partial class DatosEmpleadosForm {
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
            this.lblDatos = new System.Windows.Forms.Label();
            this.tblEmpleados = new System.Windows.Forms.DataGridView();
            this.thNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thTipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thNumIde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFootball
            // 
            this.lblFootball.AutoSize = true;
            this.lblFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootball.Location = new System.Drawing.Point(499, 25);
            this.lblFootball.Name = "lblFootball";
            this.lblFootball.Size = new System.Drawing.Size(185, 33);
            this.lblFootball.TabIndex = 0;
            this.lblFootball.Text = "Football XXI";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(455, 77);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(265, 25);
            this.lblDatos.TabIndex = 1;
            this.lblDatos.Text = "Datos de los empleados";
            // 
            // tblEmpleados
            // 
            this.tblEmpleados.AllowUserToAddRows = false;
            this.tblEmpleados.AllowUserToDeleteRows = false;
            this.tblEmpleados.AutoGenerateColumns = false;
            this.tblEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thNombres,
            this.thApellidos,
            this.thTipoDoc,
            this.thNumIde,
            this.thGenero,
            this.thDireccion,
            this.thRol,
            this.thCelular,
            this.thCorreo,
            this.edadDataGridViewTextBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn});
            this.tblEmpleados.DataSource = this.empleadoBindingSource;
            this.tblEmpleados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tblEmpleados.Location = new System.Drawing.Point(12, 122);
            this.tblEmpleados.MultiSelect = false;
            this.tblEmpleados.Name = "tblEmpleados";
            this.tblEmpleados.ReadOnly = true;
            this.tblEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblEmpleados.Size = new System.Drawing.Size(1198, 430);
            this.tblEmpleados.TabIndex = 2;
            // 
            // thNombres
            // 
            this.thNombres.DataPropertyName = "Nombres";
            this.thNombres.HeaderText = "Nombres";
            this.thNombres.Name = "thNombres";
            this.thNombres.ReadOnly = true;
            // 
            // thApellidos
            // 
            this.thApellidos.DataPropertyName = "Apellidos";
            this.thApellidos.HeaderText = "Apellidos";
            this.thApellidos.Name = "thApellidos";
            this.thApellidos.ReadOnly = true;
            // 
            // thTipoDoc
            // 
            this.thTipoDoc.DataPropertyName = "NombreTipoDoc";
            this.thTipoDoc.HeaderText = "T.Documento";
            this.thTipoDoc.Name = "thTipoDoc";
            this.thTipoDoc.ReadOnly = true;
            // 
            // thNumIde
            // 
            this.thNumIde.DataPropertyName = "NumDoc";
            this.thNumIde.HeaderText = "N.Documento";
            this.thNumIde.Name = "thNumIde";
            this.thNumIde.ReadOnly = true;
            // 
            // thGenero
            // 
            this.thGenero.DataPropertyName = "NombreGenero";
            this.thGenero.HeaderText = "Género";
            this.thGenero.Name = "thGenero";
            this.thGenero.ReadOnly = true;
            // 
            // thDireccion
            // 
            this.thDireccion.DataPropertyName = "Dirreccion";
            this.thDireccion.HeaderText = "Dirección";
            this.thDireccion.Name = "thDireccion";
            this.thDireccion.ReadOnly = true;
            // 
            // thRol
            // 
            this.thRol.DataPropertyName = "NombreRol";
            this.thRol.HeaderText = "Cargo";
            this.thRol.Name = "thRol";
            this.thRol.ReadOnly = true;
            // 
            // thCelular
            // 
            this.thCelular.DataPropertyName = "Celular";
            this.thCelular.HeaderText = "N.Celular";
            this.thCelular.Name = "thCelular";
            this.thCelular.ReadOnly = true;
            // 
            // thCorreo
            // 
            this.thCorreo.DataPropertyName = "Email";
            this.thCorreo.HeaderText = "Correo";
            this.thCorreo.Name = "thCorreo";
            this.thCorreo.ReadOnly = true;
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "NombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empleadoBindingSource
            // 
            this.empleadoBindingSource.DataSource = typeof(Compartido.Modelo.Empleado);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEmpleado.Location = new System.Drawing.Point(939, 558);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(243, 35);
            this.btnEditarEmpleado.TabIndex = 3;
            this.btnEditarEmpleado.Text = "Editar Empleado";
            this.btnEditarEmpleado.UseVisualStyleBackColor = true;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.BtnEditarEmpleado_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(778, 558);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(118, 35);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.BtnAtras_Click);
            // 
            // DatosEmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 605);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnEditarEmpleado);
            this.Controls.Add(this.tblEmpleados);
            this.Controls.Add(this.lblDatos);
            this.Controls.Add(this.lblFootball);
            this.Name = "DatosEmpleadosForm";
            this.Text = "DatosEmpleadosForm";
            ((System.ComponentModel.ISupportInitialize)(this.tblEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootball;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.DataGridView tblEmpleados;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn thNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn thApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn thTipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn thNumIde;
        private System.Windows.Forms.DataGridViewTextBoxColumn thGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn thDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn thRol;
        private System.Windows.Forms.DataGridViewTextBoxColumn thCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn thCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
    }
}