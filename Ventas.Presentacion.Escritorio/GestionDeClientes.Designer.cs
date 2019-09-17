namespace Ventas.Presentacion.Escritorio
{
    partial class GestionDeClientes
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
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.ListBox();
            this.DNI = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Ubigeo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FechaDeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TablaDeClientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(143, 38);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(196, 20);
            this.Nombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sexo";
            // 
            // Sexo
            // 
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.Sexo.Location = new System.Drawing.Point(143, 78);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(196, 30);
            this.Sexo.TabIndex = 3;
            // 
            // DNI
            // 
            this.DNI.Location = new System.Drawing.Point(143, 131);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(196, 20);
            this.DNI.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(143, 170);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(196, 20);
            this.Direccion.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // Ubigeo
            // 
            this.Ubigeo.Location = new System.Drawing.Point(143, 205);
            this.Ubigeo.Name = "Ubigeo";
            this.Ubigeo.Size = new System.Drawing.Size(196, 20);
            this.Ubigeo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ubigeo";
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(143, 245);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(196, 20);
            this.Correo.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo";
            // 
            // Celular
            // 
            this.Celular.Location = new System.Drawing.Point(143, 286);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(196, 20);
            this.Celular.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha De Nacimiento";
            // 
            // FechaDeNacimiento
            // 
            this.FechaDeNacimiento.Location = new System.Drawing.Point(143, 329);
            this.FechaDeNacimiento.Name = "FechaDeNacimiento";
            this.FechaDeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.FechaDeNacimiento.TabIndex = 15;
            // 
            // TablaDeClientes
            // 
            this.TablaDeClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaDeClientes.Location = new System.Drawing.Point(390, 38);
            this.TablaDeClientes.Name = "TablaDeClientes";
            this.TablaDeClientes.Size = new System.Drawing.Size(493, 311);
            this.TablaDeClientes.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 45);
            this.button2.TabIndex = 18;
            this.button2.Text = "Registrar Cliente";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // GestionDeClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 427);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TablaDeClientes);
            this.Controls.Add(this.FechaDeNacimiento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Ubigeo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Name = "GestionDeClientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.GestionDeClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TablaDeClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Sexo;
        private System.Windows.Forms.TextBox DNI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Ubigeo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Celular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FechaDeNacimiento;
        private System.Windows.Forms.DataGridView TablaDeClientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

