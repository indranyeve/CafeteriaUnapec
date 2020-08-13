namespace CafeteriaUNAPEC
{
    partial class BusquedaEmpleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCristerio = new System.Windows.Forms.ComboBox();
            this.txtABuscar = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvEmpleados = new System.Windows.Forms.DataGridView();
            this.CmdAgregar = new System.Windows.Forms.Button();
            this.CmdConsultar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CmdAgregar);
            this.panel1.Controls.Add(this.CmdConsultar);
            this.panel1.Controls.Add(this.txtABuscar);
            this.panel1.Controls.Add(this.cbxCristerio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 90);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criterio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Texto a buscar";
            // 
            // cbxCristerio
            // 
            this.cbxCristerio.FormattingEnabled = true;
            this.cbxCristerio.Location = new System.Drawing.Point(90, 23);
            this.cbxCristerio.Name = "cbxCristerio";
            this.cbxCristerio.Size = new System.Drawing.Size(194, 24);
            this.cbxCristerio.TabIndex = 2;
            // 
            // txtABuscar
            // 
            this.txtABuscar.Location = new System.Drawing.Point(465, 26);
            this.txtABuscar.Name = "txtABuscar";
            this.txtABuscar.Size = new System.Drawing.Size(291, 22);
            this.txtABuscar.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvEmpleados);
            this.panel2.Location = new System.Drawing.Point(12, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(991, 319);
            this.panel2.TabIndex = 1;
            // 
            // DgvEmpleados
            // 
            this.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEmpleados.Location = new System.Drawing.Point(16, 14);
            this.DgvEmpleados.Name = "DgvEmpleados";
            this.DgvEmpleados.RowHeadersWidth = 51;
            this.DgvEmpleados.RowTemplate.Height = 24;
            this.DgvEmpleados.Size = new System.Drawing.Size(959, 290);
            this.DgvEmpleados.TabIndex = 0;
            // 
            // CmdAgregar
            // 
            this.CmdAgregar.BackgroundImage = global::CafeteriaUNAPEC.Properties.Resources.plus;
            this.CmdAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CmdAgregar.Location = new System.Drawing.Point(890, 13);
            this.CmdAgregar.Name = "CmdAgregar";
            this.CmdAgregar.Size = new System.Drawing.Size(66, 64);
            this.CmdAgregar.TabIndex = 5;
            this.CmdAgregar.UseVisualStyleBackColor = true;
            // 
            // CmdConsultar
            // 
            this.CmdConsultar.BackColor = System.Drawing.SystemColors.Control;
            this.CmdConsultar.BackgroundImage = global::CafeteriaUNAPEC.Properties.Resources.search;
            this.CmdConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CmdConsultar.Location = new System.Drawing.Point(793, 13);
            this.CmdConsultar.Name = "CmdConsultar";
            this.CmdConsultar.Size = new System.Drawing.Size(66, 64);
            this.CmdConsultar.TabIndex = 4;
            this.CmdConsultar.UseVisualStyleBackColor = false;
            // 
            // BusquedaEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BusquedaEmpleados";
            this.Text = "Consulta de Empleados";
            this.Load += new System.EventHandler(this.BusquedaEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CmdAgregar;
        private System.Windows.Forms.Button CmdConsultar;
        private System.Windows.Forms.TextBox txtABuscar;
        private System.Windows.Forms.ComboBox cbxCristerio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgvEmpleados;
    }
}