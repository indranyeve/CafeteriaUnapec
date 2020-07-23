namespace CafeteriaUNAPEC
{
    partial class MenuEmpleados
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
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnConsultaArticulos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacturacionArticulos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Location = new System.Drawing.Point(722, 13);
            this.btnAcercaDe.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(100, 28);
            this.btnAcercaDe.TabIndex = 7;
            this.btnAcercaDe.Text = "Acerca de";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            // 
            // btnConsultaArticulos
            // 
            this.btnConsultaArticulos.Location = new System.Drawing.Point(480, 72);
            this.btnConsultaArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultaArticulos.Name = "btnConsultaArticulos";
            this.btnConsultaArticulos.Size = new System.Drawing.Size(208, 62);
            this.btnConsultaArticulos.TabIndex = 6;
            this.btnConsultaArticulos.Text = "Consulta de Articulos";
            this.btnConsultaArticulos.UseVisualStyleBackColor = true;
            this.btnConsultaArticulos.Click += new System.EventHandler(this.btnConsultaArticulos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(841, 13);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnFacturacionArticulos
            // 
            this.btnFacturacionArticulos.Location = new System.Drawing.Point(733, 72);
            this.btnFacturacionArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnFacturacionArticulos.Name = "btnFacturacionArticulos";
            this.btnFacturacionArticulos.Size = new System.Drawing.Size(208, 62);
            this.btnFacturacionArticulos.TabIndex = 8;
            this.btnFacturacionArticulos.Text = "Facturación de Articulos";
            this.btnFacturacionArticulos.UseVisualStyleBackColor = true;
            // 
            // MenuEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.btnFacturacionArticulos);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.btnConsultaArticulos);
            this.Controls.Add(this.btnSalir);
            this.Name = "MenuEmpleados";
            this.Text = "MenuEmpleados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnConsultaArticulos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFacturacionArticulos;
    }
}