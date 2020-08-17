namespace CafeteriaUNAPEC
{
    partial class GestionFacturacionArticulos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtUnidadVendida = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.CmdEditar = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.CmdAnadir = new System.Windows.Forms.Button();
            this.cbxEmpleado = new System.Windows.Forms.ComboBox();
            this.cbxArticulo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(963, 233);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Articulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(502, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Unidad Vendida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Comentario";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(144, 379);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(207, 22);
            this.txtMonto.TabIndex = 8;
            // 
            // txtUnidadVendida
            // 
            this.txtUnidadVendida.Location = new System.Drawing.Point(658, 273);
            this.txtUnidadVendida.Name = "txtUnidadVendida";
            this.txtUnidadVendida.Size = new System.Drawing.Size(207, 22);
            this.txtUnidadVendida.TabIndex = 9;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(658, 328);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(207, 22);
            this.txtComentario.TabIndex = 10;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(244, 553);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(388, 22);
            this.txtID.TabIndex = 23;
            this.txtID.Visible = false;
            // 
            // CmdEditar
            // 
            this.CmdEditar.Location = new System.Drawing.Point(408, 450);
            this.CmdEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdEditar.Name = "CmdEditar";
            this.CmdEditar.Size = new System.Drawing.Size(145, 76);
            this.CmdEditar.TabIndex = 22;
            this.CmdEditar.Text = "&Eliminar";
            this.CmdEditar.UseVisualStyleBackColor = true;
            this.CmdEditar.Click += new System.EventHandler(this.CmdEliminar);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Location = new System.Drawing.Point(628, 450);
            this.CmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(145, 76);
            this.CmdLimpiar.TabIndex = 21;
            this.CmdLimpiar.Text = "&Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.LimpiarRegistros);
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.Location = new System.Drawing.Point(193, 450);
            this.CmdAnadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(145, 76);
            this.CmdAnadir.TabIndex = 20;
            this.CmdAnadir.Text = "&Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // cbxEmpleado
            // 
            this.cbxEmpleado.FormattingEnabled = true;
            this.cbxEmpleado.Location = new System.Drawing.Point(144, 271);
            this.cbxEmpleado.Name = "cbxEmpleado";
            this.cbxEmpleado.Size = new System.Drawing.Size(207, 24);
            this.cbxEmpleado.TabIndex = 24;
            this.cbxEmpleado.SelectedIndexChanged += new System.EventHandler(this.cbxEmpleado_SelectedIndexChanged);
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.FormattingEnabled = true;
            this.cbxArticulo.Location = new System.Drawing.Point(144, 328);
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.Size = new System.Drawing.Size(207, 24);
            this.cbxArticulo.TabIndex = 25;
            this.cbxArticulo.SelectedIndexChanged += new System.EventHandler(this.cbxArticulo_SelectedIndexChanged);
            // 
            // GestionFacturacionArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 602);
            this.Controls.Add(this.cbxArticulo);
            this.Controls.Add(this.cbxEmpleado);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.CmdEditar);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtUnidadVendida);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GestionFacturacionArticulos";
            this.Text = "GestionFacturacionArticulos";
            this.Load += new System.EventHandler(this.GestionFacturacionArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtUnidadVendida;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button CmdEditar;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.Button CmdAnadir;
        private System.Windows.Forms.ComboBox cbxEmpleado;
        private System.Windows.Forms.ComboBox cbxArticulo;
    }
}