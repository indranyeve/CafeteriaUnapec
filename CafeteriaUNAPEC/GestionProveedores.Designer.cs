namespace CafeteriaUNAPEC
{
    partial class GestionProveedores
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
            this.labelNombreComercial = new System.Windows.Forms.Label();
            this.labelRNC = new System.Windows.Forms.Label();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.txtRNC = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.CmdAnadir = new System.Windows.Forms.Button();
            this.ProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreComercial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProveedorID,
            this.NombreComercial,
            this.RNC,
            this.FechaIngreso,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(704, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // labelNombreComercial
            // 
            this.labelNombreComercial.AutoSize = true;
            this.labelNombreComercial.Location = new System.Drawing.Point(10, 230);
            this.labelNombreComercial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreComercial.Name = "labelNombreComercial";
            this.labelNombreComercial.Size = new System.Drawing.Size(93, 13);
            this.labelNombreComercial.TabIndex = 1;
            this.labelNombreComercial.Text = "Nombre Comercial";
            // 
            // labelRNC
            // 
            this.labelRNC.AutoSize = true;
            this.labelRNC.Location = new System.Drawing.Point(380, 231);
            this.labelRNC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRNC.Name = "labelRNC";
            this.labelRNC.Size = new System.Drawing.Size(30, 13);
            this.labelRNC.TabIndex = 2;
            this.labelRNC.Text = "RNC";
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.Location = new System.Drawing.Point(123, 230);
            this.txtNombreComercial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(226, 20);
            this.txtNombreComercial.TabIndex = 3;
            // 
            // txtRNC
            // 
            this.txtRNC.Location = new System.Drawing.Point(431, 231);
            this.txtRNC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(76, 20);
            this.txtRNC.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(176, 399);
            this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(292, 20);
            this.txtID.TabIndex = 23;
            this.txtID.Visible = false;
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(299, 316);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(109, 62);
            this.CmdEliminar.TabIndex = 22;
            this.CmdEliminar.Text = "&Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Location = new System.Drawing.Point(464, 316);
            this.CmdLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(109, 62);
            this.CmdLimpiar.TabIndex = 21;
            this.CmdLimpiar.Text = "&Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.LimpiarRegistro);
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.Location = new System.Drawing.Point(138, 316);
            this.CmdAnadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(109, 62);
            this.CmdAnadir.TabIndex = 20;
            this.CmdAnadir.Text = "&Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // ProveedorID
            // 
            this.ProveedorID.HeaderText = "ProveedorID";
            this.ProveedorID.MinimumWidth = 6;
            this.ProveedorID.Name = "ProveedorID";
            this.ProveedorID.ReadOnly = true;
            this.ProveedorID.Visible = false;
            this.ProveedorID.Width = 125;
            // 
            // NombreComercial
            // 
            this.NombreComercial.HeaderText = "NombreComercial";
            this.NombreComercial.MinimumWidth = 6;
            this.NombreComercial.Name = "NombreComercial";
            this.NombreComercial.ReadOnly = true;
            this.NombreComercial.Width = 125;
            // 
            // RNC
            // 
            this.RNC.HeaderText = "RNC";
            this.RNC.MinimumWidth = 6;
            this.RNC.Name = "RNC";
            this.RNC.ReadOnly = true;
            this.RNC.Width = 125;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "FechaIngreso";
            this.FechaIngreso.MinimumWidth = 6;
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 125;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            this.Estado.Width = 125;
            // 
            // GestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 431);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtRNC);
            this.Controls.Add(this.txtNombreComercial);
            this.Controls.Add(this.labelRNC);
            this.Controls.Add(this.labelNombreComercial);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GestionProveedores";
            this.Text = "GestionProveedores";
            this.Load += new System.EventHandler(this.GestionProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelNombreComercial;
        private System.Windows.Forms.Label labelRNC;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtRNC;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.Button CmdAnadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreComercial;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}