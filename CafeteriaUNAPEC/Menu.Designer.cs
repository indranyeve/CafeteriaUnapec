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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.btnConsultaEmpleados);
            this.Controls.Add(this.btnSalir);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConsultaEmpleados;
        private System.Windows.Forms.Button btnSalir;
    }
}