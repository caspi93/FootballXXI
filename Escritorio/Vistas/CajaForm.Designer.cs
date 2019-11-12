namespace Escritorio.Vistas {
    partial class CajaForm {
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.THNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thPrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnSelVen = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.tnCerrarSesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFootball
            // 
            this.lblFootball.AutoSize = true;
            this.lblFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFootball.Location = new System.Drawing.Point(327, 9);
            this.lblFootball.Name = "lblFootball";
            this.lblFootball.Size = new System.Drawing.Size(185, 33);
            this.lblFootball.TabIndex = 0;
            this.lblFootball.Text = "Football XXI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carrito de compras";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(13, 234);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(92, 20);
            this.lblVendedor.TabIndex = 2;
            this.lblVendedor.Text = "Vendedor:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.THNombre,
            this.THGenero,
            this.thTalla,
            this.thPrecioUnitario,
            this.thCantidad,
            this.thSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(122, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 158);
            this.dataGridView1.TabIndex = 3;
            // 
            // THNombre
            // 
            this.THNombre.HeaderText = "Nombre";
            this.THNombre.Name = "THNombre";
            // 
            // THGenero
            // 
            this.THGenero.HeaderText = "Género";
            this.THGenero.Name = "THGenero";
            // 
            // thTalla
            // 
            this.thTalla.HeaderText = "Talla";
            this.thTalla.Name = "thTalla";
            // 
            // thPrecioUnitario
            // 
            this.thPrecioUnitario.HeaderText = "Precio Uniario";
            this.thPrecioUnitario.Name = "thPrecioUnitario";
            // 
            // thCantidad
            // 
            this.thCantidad.HeaderText = "Cantidad";
            this.thCantidad.Name = "thCantidad";
            // 
            // thSubtotal
            // 
            this.thSubtotal.HeaderText = "Subtotal";
            this.thSubtotal.Name = "thSubtotal";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(675, 234);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(69, 20);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total: $";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(53, 510);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 34);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // btnSelVen
            // 
            this.btnSelVen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelVen.Location = new System.Drawing.Point(175, 510);
            this.btnSelVen.Name = "btnSelVen";
            this.btnSelVen.Size = new System.Drawing.Size(219, 34);
            this.btnSelVen.TabIndex = 6;
            this.btnSelVen.Text = "Seleccionar Vendedor";
            this.btnSelVen.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCompra.Location = new System.Drawing.Point(438, 510);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(184, 34);
            this.btnCancelarCompra.TabIndex = 7;
            this.btnCancelarCompra.Text = "Cancelar Comprar";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(654, 510);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(173, 34);
            this.btnFinalizarCompra.TabIndex = 8;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // tnCerrarSesion
            // 
            this.tnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnCerrarSesion.Location = new System.Drawing.Point(654, 564);
            this.tnCerrarSesion.Name = "tnCerrarSesion";
            this.tnCerrarSesion.Size = new System.Drawing.Size(173, 34);
            this.tnCerrarSesion.TabIndex = 9;
            this.tnCerrarSesion.Text = "Cerrar Sesión";
            this.tnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // CajaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 599);
            this.Controls.Add(this.tnCerrarSesion);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnCancelarCompra);
            this.Controls.Add(this.btnSelVen);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFootball);
            this.Name = "CajaForm";
            this.Text = "CajaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFootball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn THNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn THGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn thTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn thPrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn thCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn thSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnSelVen;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Button tnCerrarSesion;
    }
}