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
            this.articulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelCosto = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelExistencia = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.CmdAnadir = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.ForeColor = System.Drawing.Color.Black;
            this.labelDescripcion.Location = new System.Drawing.Point(21, 335);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(99, 20);
            this.labelDescripcion.TabIndex = 1;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // labelMarca
            // 
            this.labelMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMarca.AutoSize = true;
            this.labelMarca.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.ForeColor = System.Drawing.Color.Black;
            this.labelMarca.Location = new System.Drawing.Point(595, 337);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(56, 20);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca";
            // 
            // labelCosto
            // 
            this.labelCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCosto.AutoSize = true;
            this.labelCosto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCosto.ForeColor = System.Drawing.Color.Black;
            this.labelCosto.Location = new System.Drawing.Point(21, 385);
            this.labelCosto.Name = "labelCosto";
            this.labelCosto.Size = new System.Drawing.Size(53, 20);
            this.labelCosto.TabIndex = 3;
            this.labelCosto.Text = "Costo";
            // 
            // labelProveedor
            // 
            this.labelProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.ForeColor = System.Drawing.Color.Black;
            this.labelProveedor.Location = new System.Drawing.Point(21, 428);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(85, 20);
            this.labelProveedor.TabIndex = 4;
            this.labelProveedor.Text = "Proveedor";
            // 
            // labelExistencia
            // 
            this.labelExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelExistencia.AutoSize = true;
            this.labelExistencia.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelExistencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExistencia.ForeColor = System.Drawing.Color.Black;
            this.labelExistencia.Location = new System.Drawing.Point(595, 387);
            this.labelExistencia.Name = "labelExistencia";
            this.labelExistencia.Size = new System.Drawing.Size(86, 20);
            this.labelExistencia.TabIndex = 5;
            this.labelExistencia.Text = "Existencia";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Location = new System.Drawing.Point(180, 335);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(355, 22);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescripcion);
            // 
            // txtCosto
            // 
            this.txtCosto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCosto.Location = new System.Drawing.Point(180, 382);
            this.txtCosto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(355, 22);
            this.txtCosto.TabIndex = 2;
            this.txtCosto.TextChanged += new System.EventHandler(this.txtCosto_TextChanged);
            // 
            // txtExistencia
            // 
            this.txtExistencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtExistencia.Location = new System.Drawing.Point(748, 387);
            this.txtExistencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(355, 22);
            this.txtExistencia.TabIndex = 3;
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmdAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAnadir.Location = new System.Drawing.Point(726, 487);
            this.CmdAnadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(123, 44);
            this.CmdAnadir.TabIndex = 5;
            this.CmdAnadir.Text = "Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLimpiar.Location = new System.Drawing.Point(983, 487);
            this.CmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(120, 44);
            this.CmdLimpiar.TabIndex = 7;
            this.CmdLimpiar.Text = "Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.LimpiarRegistro);
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdEliminar.Location = new System.Drawing.Point(857, 487);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(120, 44);
            this.CmdEliminar.TabIndex = 6;
            this.CmdEliminar.Text = "&Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(180, 428);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(355, 24);
            this.cbxProveedor.TabIndex = 4;
            this.cbxProveedor.SelectedIndexChanged += new System.EventHandler(this.cbxProveedor_SelectedIndexChanged);
            // 
            // cbxMarca
            // 
            this.cbxMarca.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(748, 331);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(355, 24);
            this.cbxMarca.TabIndex = 1;
            this.cbxMarca.SelectedIndexChanged += new System.EventHandler(this.cbxMarca_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1128, 305);
            this.dataGridView2.TabIndex = 19;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
            // 
            // GestionArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1128, 587);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.cbxProveedor);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelExistencia);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.labelCosto);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDescripcion);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Artículos";
            this.Load += new System.EventHandler(this.GestionArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource articulosBindingSource;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelCosto;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelExistencia;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Button CmdAnadir;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}