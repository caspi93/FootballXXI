namespace Escritorio.Vistas {
    partial class AgregarProductoForm {
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
            this.lblLiga = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCanCom = new System.Windows.Forms.Label();
            this.txtCanCom = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.cbLigas = new System.Windows.Forms.ComboBox();
            this.cbGeneros = new System.Windows.Forms.ComboBox();
            this.cbEquipos = new System.Windows.Forms.ComboBox();
            this.cbTallas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblFootball
            // 
            this.lblFootball.AutoSize = true;
            this.lblFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootball.Location = new System.Drawing.Point(326, 35);
            this.lblFootball.Name = "lblFootball";
            this.lblFootball.Size = new System.Drawing.Size(185, 33);
            this.lblFootball.TabIndex = 0;
            this.lblFootball.Text = "Football XXI";
            // 
            // lblLiga
            // 
            this.lblLiga.AutoSize = true;
            this.lblLiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiga.Location = new System.Drawing.Point(145, 98);
            this.lblLiga.Name = "lblLiga";
            this.lblLiga.Size = new System.Drawing.Size(57, 25);
            this.lblLiga.TabIndex = 1;
            this.lblLiga.Text = "Liga";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(580, 98);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(89, 25);
            this.lblGenero.TabIndex = 2;
            this.lblGenero.Text = "Género";
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipo.Location = new System.Drawing.Point(117, 228);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(85, 25);
            this.lblEquipo.TabIndex = 3;
            this.lblEquipo.Text = "Equipo";
            this.lblEquipo.Click += new System.EventHandler(this.LblEquipo_Click);
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTalla.Location = new System.Drawing.Point(593, 228);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(64, 25);
            this.lblTalla.TabIndex = 4;
            this.lblTalla.Text = "Talla";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(118, 327);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(86, 20);
            this.lblCantidad.TabIndex = 5;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(120, 368);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblCanCom
            // 
            this.lblCanCom.AutoSize = true;
            this.lblCanCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanCom.Location = new System.Drawing.Point(534, 327);
            this.lblCanCom.Name = "lblCanCom";
            this.lblCanCom.Size = new System.Drawing.Size(169, 20);
            this.lblCanCom.TabIndex = 7;
            this.lblCanCom.Text = "Cantidad a Comprar";
            // 
            // txtCanCom
            // 
            this.txtCanCom.Location = new System.Drawing.Point(598, 368);
            this.txtCanCom.Name = "txtCanCom";
            this.txtCanCom.Size = new System.Drawing.Size(45, 20);
            this.txtCanCom.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(665, 415);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 33);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(521, 415);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(119, 33);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            // 
            // cbLigas
            // 
            this.cbLigas.FormattingEnabled = true;
            this.cbLigas.Items.AddRange(new object[] {
            "Seleccione una liga"});
            this.cbLigas.Location = new System.Drawing.Point(26, 126);
            this.cbLigas.Name = "cbLigas";
            this.cbLigas.Size = new System.Drawing.Size(278, 21);
            this.cbLigas.TabIndex = 11;
            // 
            // cbGeneros
            // 
            this.cbGeneros.FormattingEnabled = true;
            this.cbGeneros.Items.AddRange(new object[] {
            "Seleccione un género"});
            this.cbGeneros.Location = new System.Drawing.Point(480, 126);
            this.cbGeneros.Name = "cbGeneros";
            this.cbGeneros.Size = new System.Drawing.Size(294, 21);
            this.cbGeneros.TabIndex = 12;
            // 
            // cbEquipos
            // 
            this.cbEquipos.FormattingEnabled = true;
            this.cbEquipos.Items.AddRange(new object[] {
            "Seleccione un equipo"});
            this.cbEquipos.Location = new System.Drawing.Point(26, 266);
            this.cbEquipos.Name = "cbEquipos";
            this.cbEquipos.Size = new System.Drawing.Size(278, 21);
            this.cbEquipos.TabIndex = 13;
            // 
            // cbTallas
            // 
            this.cbTallas.FormattingEnabled = true;
            this.cbTallas.Items.AddRange(new object[] {
            "Seleccione una talla"});
            this.cbTallas.Location = new System.Drawing.Point(483, 265);
            this.cbTallas.Name = "cbTallas";
            this.cbTallas.Size = new System.Drawing.Size(291, 21);
            this.cbTallas.TabIndex = 14;
            // 
            // AgregarProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.cbTallas);
            this.Controls.Add(this.cbEquipos);
            this.Controls.Add(this.cbGeneros);
            this.Controls.Add(this.cbLigas);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCanCom);
            this.Controls.Add(this.lblCanCom);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblLiga);
            this.Controls.Add(this.lblFootball);
            this.Name = "AgregarProductoForm";
            this.Text = "AgregarProductoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootball;
        private System.Windows.Forms.Label lblLiga;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEquipo;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCanCom;
        private System.Windows.Forms.TextBox txtCanCom;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ComboBox cbLigas;
        private System.Windows.Forms.ComboBox cbGeneros;
        private System.Windows.Forms.ComboBox cbEquipos;
        private System.Windows.Forms.ComboBox cbTallas;
    }
}