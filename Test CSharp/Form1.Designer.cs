namespace Test_CSharp
{
    partial class Videojuegos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.cbnCategoria = new System.Windows.Forms.ComboBox();
            this.cbnPEGI = new System.Windows.Forms.ComboBox();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.lstVideojuegos = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PEGI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha de lanzamiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Empresa";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(139, 140);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(121, 20);
            this.txtEmpresa.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(139, 108);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(121, 20);
            this.txtStock.TabIndex = 2;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(139, 76);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 1;
            // 
            // cbnCategoria
            // 
            this.cbnCategoria.FormattingEnabled = true;
            this.cbnCategoria.Location = new System.Drawing.Point(139, 179);
            this.cbnCategoria.Name = "cbnCategoria";
            this.cbnCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbnCategoria.TabIndex = 4;
            // 
            // cbnPEGI
            // 
            this.cbnPEGI.FormattingEnabled = true;
            this.cbnPEGI.Location = new System.Drawing.Point(139, 213);
            this.cbnPEGI.Name = "cbnPEGI";
            this.cbnPEGI.Size = new System.Drawing.Size(121, 21);
            this.cbnPEGI.TabIndex = 5;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(60, 262);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLanzamiento.TabIndex = 6;
            // 
            // lstVideojuegos
            // 
            this.lstVideojuegos.FormattingEnabled = true;
            this.lstVideojuegos.Location = new System.Drawing.Point(328, 39);
            this.lstVideojuegos.Name = "lstVideojuegos";
            this.lstVideojuegos.Size = new System.Drawing.Size(276, 238);
            this.lstVideojuegos.TabIndex = 12;
            this.lstVideojuegos.SelectedIndexChanged += new System.EventHandler(this.lstVideojuegos_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(60, 309);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(156, 309);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(433, 309);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(529, 309);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(259, 309);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Videojuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 344);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstVideojuegos);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.cbnPEGI);
            this.Controls.Add(this.cbnCategoria);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Videojuegos";
            this.Text = "Videojuegos";
            this.Load += new System.EventHandler(this.Videojuegos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cbnCategoria;
        private System.Windows.Forms.ComboBox cbnPEGI;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.ListBox lstVideojuegos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
    }
}

