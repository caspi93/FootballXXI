namespace Escritorio.Vistas {
    partial class DatosReporteForm {
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
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.cbTallas = new System.Windows.Forms.ComboBox();
            this.tblDatosReporte = new System.Windows.Forms.DataGridView();
            this.thNombreLiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thCantEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thCantVen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActPro = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblImagen = new System.Windows.Forms.Label();
            this.lblImagen2 = new System.Windows.Forms.Label();
            this.nombreLigaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadExistenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadVendidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datosReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFootball
            // 
            this.lblFootball.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootball.Location = new System.Drawing.Point(12, 9);
            this.lblFootball.Name = "lblFootball";
            this.lblFootball.Size = new System.Drawing.Size(868, 33);
            this.lblFootball.TabIndex = 0;
            this.lblFootball.Text = "Football XXI";
            this.lblFootball.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(207, 62);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(80, 24);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Género";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalla.Location = new System.Drawing.Point(659, 62);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(55, 24);
            this.lblTalla.TabIndex = 2;
            this.lblTalla.Text = "Talla";
            // 
            // cbGeneros
            // 
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Items.AddRange(new object[] {
            "Seleccione un género"});
            this.cbGeneros.Location = new System.Drawing.Point(87, 89);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(296, 21);
            this.cbGeneros.TabIndex = 3;
            this.cbGeneros.SelectedIndexChanged += new System.EventHandler(this.CbGeneros_SelectedIndexChanged);
            // 
            // cbTallas
            // 
            this.cbTallas.Enabled = false;
            this.cbTallas.FormattingEnabled = true;
            this.cbTallas.Items.AddRange(new object[] {
            "Seleccione una talla"});
            this.cbTallas.Location = new System.Drawing.Point(540, 89);
            this.cbTallas.Name = "cbTallas";
            this.cbTallas.Size = new System.Drawing.Size(305, 21);
            this.cbTallas.TabIndex = 4;
            this.cbTallas.SelectedIndexChanged += new System.EventHandler(this.CbTallas_SelectedIndexChanged);
            // 
            // tblDatosReporte
            // 
            this.tblDatosReporte.AutoGenerateColumns = false;
            this.tblDatosReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDatosReporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thNombreLiga,
            this.thEquipo,
            this.thCantEx,
            this.thCantVen,
            this.nombreLigaDataGridViewTextBoxColumn,
            this.nombreEquipoDataGridViewTextBoxColumn,
            this.cantidadExistenteDataGridViewTextBoxColumn,
            this.cantidadVendidaDataGridViewTextBoxColumn});
            this.tblDatosReporte.DataSource = this.datosReporteBindingSource;
            this.tblDatosReporte.Location = new System.Drawing.Point(242, 132);
            this.tblDatosReporte.Name = "tblDatosReporte";
            this.tblDatosReporte.Size = new System.Drawing.Size(444, 264);
            this.tblDatosReporte.TabIndex = 5;
            // 
            // thNombreLiga
            // 
            this.thNombreLiga.DataPropertyName = "NombreLiga";
            this.thNombreLiga.HeaderText = "Nombre de la liga";
            this.thNombreLiga.Name = "thNombreLiga";
            // 
            // thEquipo
            // 
            this.thEquipo.DataPropertyName = "NombreEquipo";
            this.thEquipo.HeaderText = "Nombre del equipo";
            this.thEquipo.Name = "thEquipo";
            // 
            // thCantEx
            // 
            this.thCantEx.DataPropertyName = "CantidadExistente";
            this.thCantEx.HeaderText = "Cantidad Existente";
            this.thCantEx.Name = "thCantEx";
            // 
            // thCantVen
            // 
            this.thCantVen.DataPropertyName = "CantidadVendida";
            this.thCantVen.HeaderText = "Cantidad Vendida";
            this.thCantVen.Name = "thCantVen";
            // 
            // btnActPro
            // 
            this.btnActPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnActPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActPro.Location = new System.Drawing.Point(483, 411);
            this.btnActPro.Name = "btnActPro";
            this.btnActPro.Size = new System.Drawing.Size(231, 27);
            this.btnActPro.TabIndex = 6;
            this.btnActPro.Text = "Actualizar Producto";
            this.btnActPro.UseVisualStyleBackColor = false;
            this.btnActPro.Click += new System.EventHandler(this.BtnActPro_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(324, 411);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(119, 27);
            this.btnAtras.TabIndex = 7;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // lblImagen
            // 
            this.lblImagen.Image = global::Escritorio.Properties.Resources.Paris_Saint_German;
            this.lblImagen.Location = new System.Drawing.Point(5, 132);
            this.lblImagen.Name = "lblImagen";
            this.lblImagen.Size = new System.Drawing.Size(231, 231);
            this.lblImagen.TabIndex = 9;
            // 
            // lblImagen2
            // 
            this.lblImagen2.Image = global::Escritorio.Properties.Resources.liverpool;
            this.lblImagen2.Location = new System.Drawing.Point(692, 132);
            this.lblImagen2.Name = "lblImagen2";
            this.lblImagen2.Size = new System.Drawing.Size(228, 231);
            this.lblImagen2.TabIndex = 8;
            // 
            // nombreLigaDataGridViewTextBoxColumn
            // 
            this.nombreLigaDataGridViewTextBoxColumn.DataPropertyName = "NombreLiga";
            this.nombreLigaDataGridViewTextBoxColumn.HeaderText = "NombreLiga";
            this.nombreLigaDataGridViewTextBoxColumn.Name = "nombreLigaDataGridViewTextBoxColumn";
            // 
            // nombreEquipoDataGridViewTextBoxColumn
            // 
            this.nombreEquipoDataGridViewTextBoxColumn.DataPropertyName = "NombreEquipo";
            this.nombreEquipoDataGridViewTextBoxColumn.HeaderText = "NombreEquipo";
            this.nombreEquipoDataGridViewTextBoxColumn.Name = "nombreEquipoDataGridViewTextBoxColumn";
            // 
            // cantidadExistenteDataGridViewTextBoxColumn
            // 
            this.cantidadExistenteDataGridViewTextBoxColumn.DataPropertyName = "CantidadExistente";
            this.cantidadExistenteDataGridViewTextBoxColumn.HeaderText = "CantidadExistente";
            this.cantidadExistenteDataGridViewTextBoxColumn.Name = "cantidadExistenteDataGridViewTextBoxColumn";
            // 
            // cantidadVendidaDataGridViewTextBoxColumn
            // 
            this.cantidadVendidaDataGridViewTextBoxColumn.DataPropertyName = "CantidadVendida";
            this.cantidadVendidaDataGridViewTextBoxColumn.HeaderText = "CantidadVendida";
            this.cantidadVendidaDataGridViewTextBoxColumn.Name = "cantidadVendidaDataGridViewTextBoxColumn";
            // 
            // datosReporteBindingSource
            // 
            this.datosReporteBindingSource.DataSource = typeof(Compartido.Modelo.DatosReporte);
            // 
            // DatosReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 450);
            this.Controls.Add(this.lblImagen);
            this.Controls.Add(this.lblImagen2);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnActPro);
            this.Controls.Add(this.tblDatosReporte);
            this.Controls.Add(this.cbTallas);
            this.Controls.Add(this.cbGeneros);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblFootball);
            this.Name = "DatosReporteForm";
            this.Text = "DatosReporteForm";
            ((System.ComponentModel.ISupportInitialize)(this.tblDatosReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datosReporteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootball;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.ComboBox cbTallas;
        private System.Windows.Forms.DataGridView tblDatosReporte;
        private System.Windows.Forms.Button btnActPro;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.BindingSource datosReporteBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn thNombreLiga;
        private System.Windows.Forms.DataGridViewTextBoxColumn thEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn thCantEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn thCantVen;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLigaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadExistenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadVendidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblImagen2;
        private System.Windows.Forms.Label lblImagen;
    }
}