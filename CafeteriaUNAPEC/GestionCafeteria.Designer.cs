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
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.CmdAnadir = new System.Windows.Forms.Button();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.cbxCampus = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdEliminar.Location = new System.Drawing.Point(997, 449);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(108, 46);
            this.CmdEliminar.TabIndex = 30;
            this.CmdEliminar.Text = "&Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLimpiar.Location = new System.Drawing.Point(1111, 449);
            this.CmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(108, 46);
            this.CmdLimpiar.TabIndex = 29;
            this.CmdLimpiar.Text = "Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.LimpiarRegistro);
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAnadir.Location = new System.Drawing.Point(884, 449);
            this.CmdAnadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(107, 46);
            this.CmdAnadir.TabIndex = 28;
            this.CmdAnadir.Text = "Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // txtEncargado
            // 
            this.txtEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEncargado.Location = new System.Drawing.Point(769, 335);
            this.txtEncargado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(355, 26);
            this.txtEncargado.TabIndex = 26;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescripcion.Location = new System.Drawing.Point(180, 336);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(355, 26);
            this.txtDescripcion.TabIndex = 23;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProveedor.Location = new System.Drawing.Point(616, 338);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(89, 20);
            this.labelProveedor.TabIndex = 21;
            this.labelProveedor.Text = "Encargado";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMarca.Location = new System.Drawing.Point(21, 392);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(71, 20);
            this.labelMarca.TabIndex = 19;
            this.labelMarca.Text = "Campus";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDescripcion.Location = new System.Drawing.Point(21, 336);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(99, 20);
            this.labelDescripcion.TabIndex = 18;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // cbxCampus
            // 
            this.cbxCampus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxCampus.FormattingEnabled = true;
            this.cbxCampus.Location = new System.Drawing.Point(180, 389);
            this.cbxCampus.Name = "cbxCampus";
            this.cbxCampus.Size = new System.Drawing.Size(355, 28);
            this.cbxCampus.TabIndex = 33;
            this.cbxCampus.SelectedIndexChanged += new System.EventHandler(this.cbxCampus_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 309);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // GestionCafeteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1240, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxCampus);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelDescripcion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionCafeteria";
            this.Text = "Mantenimiento Cafeteria";
            this.Load += new System.EventHandler(this.GestionCafeteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.Button CmdAnadir;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.ComboBox cbxCampus;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}