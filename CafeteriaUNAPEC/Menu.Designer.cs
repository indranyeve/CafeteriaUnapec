namespace CafeteriaUNAPEC
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsultaEmpleados = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnConsultaTDU = new System.Windows.Forms.Button();
            this.btnConsultaMarcas = new System.Windows.Forms.Button();
            this.btnConsultaCampus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaEmpleados
            // 
            this.btnConsultaEmpleados.Location = new System.Drawing.Point(12, 25);
            this.btnConsultaEmpleados.Name = "btnConsultaEmpleados";
            this.btnConsultaEmpleados.Size = new System.Drawing.Size(106, 79);
            this.btnConsultaEmpleados.TabIndex = 3;
            this.btnConsultaEmpleados.Text = "Consulta de Empleados";
            this.btnConsultaEmpleados.UseVisualStyleBackColor = true;
            this.btnConsultaEmpleados.Click += new System.EventHandler(this.btnConsultaEmpleados_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(439, 16);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Location = new System.Drawing.Point(439, 66);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(75, 23);
            this.btnAcercaDe.TabIndex = 4;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnConsultaTDU
            // 
            this.btnConsultaTDU.Location = new System.Drawing.Point(12, 128);
            this.btnConsultaTDU.Name = "btnConsultaTDU";
            this.btnConsultaTDU.Size = new System.Drawing.Size(106, 79);
            this.btnConsultaTDU.TabIndex = 5;
            this.btnConsultaTDU.Text = "Consulta de Tipos de Usuarios\r\n";
            this.btnConsultaTDU.UseVisualStyleBackColor = true;
            this.btnConsultaTDU.Click += new System.EventHandler(this.btnConsultaTDU_Click);
            // 
            // btnConsultaMarcas
            // 
            this.btnConsultaMarcas.Location = new System.Drawing.Point(12, 230);
            this.btnConsultaMarcas.Name = "btnConsultaMarcas";
            this.btnConsultaMarcas.Size = new System.Drawing.Size(106, 79);
            this.btnConsultaMarcas.TabIndex = 6;
            this.btnConsultaMarcas.Text = "Consulta de Marcas\r\n";
            this.btnConsultaMarcas.UseVisualStyleBackColor = true;
            this.btnConsultaMarcas.Click += new System.EventHandler(this.btnConsultaMarcas_Click);
            // 
            // btnConsultaCampus
            // 
            this.btnConsultaCampus.Location = new System.Drawing.Point(12, 332);
            this.btnConsultaCampus.Name = "btnConsultaCampus";
            this.btnConsultaCampus.Size = new System.Drawing.Size(106, 79);
            this.btnConsultaCampus.TabIndex = 7;
            this.btnConsultaCampus.Text = "Consulta de Campus";
            this.btnConsultaCampus.UseVisualStyleBackColor = true;
            this.btnConsultaCampus.Click += new System.EventHandler(this.btnConsultaCampus_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.btnConsultaCampus);
            this.Controls.Add(this.btnConsultaMarcas);
            this.Controls.Add(this.btnConsultaTDU);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnConsultaEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaEmpleados;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnConsultaTDU;
        private System.Windows.Forms.Button btnConsultaMarcas;
        private System.Windows.Forms.Button btnConsultaCampus;
    }
}