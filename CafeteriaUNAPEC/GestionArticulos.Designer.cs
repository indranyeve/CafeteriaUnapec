namespace CafeteriaUNAPEC
{
    partial class GestionArticulos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCosto = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelExistencia = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.CmdAnadir = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ArticuloID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProveedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ArticuloID,
            this.Descripcion,
            this.Costo,
            this.ProveedorID,
            this.MarcaID,
            this.Existencia,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(21, 335);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(82, 17);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(595, 337);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(47, 17);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca";
            // 
            // labelCosto
            // 
            this.labelCosto.AutoSize = true;
            this.labelCosto.Location = new System.Drawing.Point(21, 385);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(44, 17);
            this.labelCosto.TabIndex = 3;
            this.labelCosto.Text = "Costo";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(21, 441);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(74, 17);
            this.labelProveedor.TabIndex = 4;
            this.labelProveedor.Text = "Proveedor";
            // 
            // labelExistencia
            // 
            this.labelExistencia.AutoSize = true;
            this.labelExistencia.Location = new System.Drawing.Point(595, 387);
            this.labelExistencia.Name = "labelExistencia";
            this.labelExistencia.Size = new System.Drawing.Size(71, 17);
            this.labelExistencia.TabIndex = 5;
            this.labelExistencia.Text = "Existencia";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(180, 335);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(355, 22);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescripcion);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(748, 337);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(355, 22);
            this.txtMarca.TabIndex = 8;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(180, 382);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(355, 22);
            this.txtCosto.TabIndex = 9;
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(174, 438);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(355, 22);
            this.txtProveedor.TabIndex = 10;
            this.txtProveedor.TextChanged += new System.EventHandler(this.TxtProveedor);
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(748, 382);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(355, 22);
            this.txtExistencia.TabIndex = 11;
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.Location = new System.Drawing.Point(329, 532);
            this.CmdAnadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(123, 74);
            this.CmdAnadir.TabIndex = 13;
            this.CmdAnadir.Text = "Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Location = new System.Drawing.Point(739, 532);
            this.CmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(120, 74);
            this.CmdLimpiar.TabIndex = 14;
            this.CmdLimpiar.Text = "Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.LimpiarRegistro);
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(537, 532);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(120, 74);
            this.CmdEliminar.TabIndex = 15;
            this.CmdEliminar.Text = "&Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(421, 629);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(355, 22);
            this.txtID.TabIndex = 16;
            this.txtID.Visible = false;
            // 
            // ArticuloID
            // 
            this.ArticuloID.HeaderText = "ArticuloID";
            this.ArticuloID.MinimumWidth = 6;
            this.ArticuloID.Name = "ArticuloID";
            this.ArticuloID.ReadOnly = true;
            this.ArticuloID.Visible = false;
            this.ArticuloID.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 125;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 6;
            this.Costo.Name = "Costo";
            this.Costo.ReadOnly = true;
            this.Costo.Width = 125;
            // 
            // ProveedorID
            // 
            this.ProveedorID.HeaderText = "ProveedorID";
            this.ProveedorID.MinimumWidth = 6;
            this.ProveedorID.Name = "ProveedorID";
            this.ProveedorID.ReadOnly = true;
            this.ProveedorID.Width = 125;
            // 
            // MarcaID
            // 
            this.MarcaID.HeaderText = "MarcaID";
            this.MarcaID.MinimumWidth = 6;
            this.MarcaID.Name = "MarcaID";
            this.MarcaID.ReadOnly = true;
            this.MarcaID.Width = 125;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "Existencia";
            this.Existencia.MinimumWidth = 6;
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            this.Existencia.Width = 125;
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
            // GestionArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 667);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelExistencia);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.labelCosto);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionArticulos";
            this.Text = "GestionArticulos";
            this.Load += new System.EventHandler(this.GestionArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelExistencia;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Button CmdAnadir;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArticuloID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProveedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}