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
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.cbTallas = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thNombreLiga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thCantEx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thCantVen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActPro = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Football XXI";
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
            this.lblTalla.Location = new System.Drawing.Point(526, 62);
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
            this.cbTallas.Location = new System.Drawing.Point(410, 89);
            this.cbTallas.Name = "cbTallas";
            this.cbTallas.Size = new System.Drawing.Size(305, 21);
            this.cbTallas.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.thNombreLiga,
            this.thEquipo,
            this.thCantEx,
            this.thCantVen});
            this.dataGridView1.Location = new System.Drawing.Point(164, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 56);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // thNombreLiga
            // 
            this.thNombreLiga.HeaderText = "Nombre de la liga";
            this.thNombreLiga.Name = "thNombreLiga";
            // 
            // thEquipo
            // 
            this.thEquipo.HeaderText = "Nombre del equipo";
            this.thEquipo.Name = "thEquipo";
            // 
            // thCantEx
            // 
            this.thCantEx.HeaderText = "Cantidad Existente";
            this.thCantEx.Name = "thCantEx";
            // 
            // thCantVen
            // 
            this.thCantVen.HeaderText = "Cantidad Vendida";
            this.thCantVen.Name = "thCantVen";
            // 
            // btnActPro
            // 
            this.btnActPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActPro.Location = new System.Drawing.Point(483, 411);
            this.btnActPro.Name = "btnActPro";
            this.btnActPro.Size = new System.Drawing.Size(231, 27);
            this.btnActPro.TabIndex = 6;
            this.btnActPro.Text = "Actualizar Producto";
            this.btnActPro.UseVisualStyleBackColor = true;
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
            // DatosReporteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnActPro);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbTallas);
            this.Controls.Add(this.cbGeneros);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.label1);
            this.Name = "DatosReporteForm";
            this.Text = "DatosReporteForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.ComboBox cbTallas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn thNombreLiga;
        private System.Windows.Forms.DataGridViewTextBoxColumn thEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn thCantEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn thCantVen;
        private System.Windows.Forms.Button btnActPro;
        private System.Windows.Forms.Button btnAtras;
    }
}