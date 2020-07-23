namespace CafeteriaUNAPEC
{
    partial class GestionCafeteria
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.CmdAnadir = new System.Windows.Forms.Button();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtCampus = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CafeteriaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CampusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Encargado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(421, 630);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(355, 22);
            this.txtID.TabIndex = 31;
            this.txtID.Visible = false;
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(535, 533);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(120, 74);
            this.CmdEliminar.TabIndex = 30;
            this.CmdEliminar.Text = "&Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Location = new System.Drawing.Point(737, 533);
            this.CmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(120, 74);
            this.CmdLimpiar.TabIndex = 29;
            this.CmdLimpiar.Text = "Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.LimpiarRegistro);
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.Location = new System.Drawing.Point(329, 533);
            this.CmdAnadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(123, 74);
            this.CmdAnadir.TabIndex = 28;
            this.CmdAnadir.Text = "Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // txtEncargado
            // 
            this.txtEncargado.Location = new System.Drawing.Point(769, 335);
            this.txtEncargado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(355, 22);
            this.txtEncargado.TabIndex = 26;
            // 
            // txtCampus
            // 
            this.txtCampus.Location = new System.Drawing.Point(180, 389);
            this.txtCampus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCampus.Name = "txtCampus";
            this.txtCampus.Size = new System.Drawing.Size(355, 22);
            this.txtCampus.TabIndex = 24;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(180, 336);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(355, 22);
            this.txtDescripcion.TabIndex = 23;
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(616, 338);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(77, 17);
            this.labelProveedor.TabIndex = 21;
            this.labelProveedor.Text = "Encargado";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(21, 389);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(59, 17);
            this.labelMarca.TabIndex = 19;
            this.labelMarca.Text = "Campus";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(21, 336);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 17);
            this.labelDescripcion.TabIndex = 18;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CafeteriaID,
            this.Descripcion,
            this.CampusID,
            this.Estado,
            this.Encargado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 265);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // CafeteriaID
            // 
            this.CafeteriaID.HeaderText = "CafeteriaID";
            this.CafeteriaID.MinimumWidth = 6;
            this.CafeteriaID.Name = "CafeteriaID";
            this.CafeteriaID.ReadOnly = true;
            this.CafeteriaID.Visible = false;
            this.CafeteriaID.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // CampusID
            // 
            this.CampusID.HeaderText = "CampusID";
            this.CampusID.MinimumWidth = 6;
            this.CampusID.Name = "CampusID";
            this.CampusID.ReadOnly = true;
            this.CampusID.Width = 125;
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
            // Encargado
            // 
            this.Encargado.HeaderText = "Encargado";
            this.Encargado.MinimumWidth = 6;
            this.Encargado.Name = "Encargado";
            this.Encargado.ReadOnly = true;
            this.Encargado.Width = 125;
            // 
            // GestionCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 667);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.txtCampus);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDescripcion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionCafeteria";
            this.Text = "GestionCafeteria";
            this.Load += new System.EventHandler(this.GestionCafeteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.Button CmdAnadir;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.TextBox txtCampus;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CafeteriaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CampusID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Encargado;
    }
}