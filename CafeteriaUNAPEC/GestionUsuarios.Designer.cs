namespace CafeteriaUNAPEC
{
    partial class GestionUsuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.CmdEliminar = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.CmdAnadir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTipoDeUsuario = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cédula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Limite de Crédito";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(105, 237);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 22);
            this.txtNombre.TabIndex = 6;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(105, 291);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(194, 22);
            this.txtCedula.TabIndex = 7;
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(594, 232);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(194, 22);
            this.txtLimiteCredito.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(226, 455);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(355, 22);
            this.txtID.TabIndex = 20;
            this.txtID.Visible = false;
            // 
            // CmdEliminar
            // 
            this.CmdEliminar.Location = new System.Drawing.Point(342, 358);
            this.CmdEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdEliminar.Name = "CmdEliminar";
            this.CmdEliminar.Size = new System.Drawing.Size(120, 74);
            this.CmdEliminar.TabIndex = 19;
            this.CmdEliminar.Text = "&Eliminar";
            this.CmdEliminar.UseVisualStyleBackColor = true;
            this.CmdEliminar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Location = new System.Drawing.Point(544, 358);
            this.CmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(120, 74);
            this.CmdLimpiar.TabIndex = 18;
            this.CmdLimpiar.Text = "Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.CmdLimpiar_Click);
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.Location = new System.Drawing.Point(134, 358);
            this.CmdAnadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(123, 74);
            this.CmdAnadir.TabIndex = 17;
            this.CmdAnadir.Text = "Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tipo de Usuario";
            // 
            // txtTipoDeUsuario
            // 
            this.txtTipoDeUsuario.Location = new System.Drawing.Point(594, 276);
            this.txtTipoDeUsuario.Name = "txtTipoDeUsuario";
            this.txtTipoDeUsuario.Size = new System.Drawing.Size(194, 22);
            this.txtTipoDeUsuario.TabIndex = 22;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioID,
            this.Nombre,
            this.Cedula,
            this.TipoDeUsuarioID,
            this.LimiteCredito,
            this.FechaRegistro,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(15, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 190);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // UsuarioID
            // 
            this.UsuarioID.HeaderText = "UsuarioID";
            this.UsuarioID.MinimumWidth = 6;
            this.UsuarioID.Name = "UsuarioID";
            this.UsuarioID.ReadOnly = true;
            this.UsuarioID.Visible = false;
            this.UsuarioID.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 125;
            // 
            // TipoDeUsuarioID
            // 
            this.TipoDeUsuarioID.HeaderText = "TipoDeUsuarioID";
            this.TipoDeUsuarioID.MinimumWidth = 6;
            this.TipoDeUsuarioID.Name = "TipoDeUsuarioID";
            this.TipoDeUsuarioID.ReadOnly = true;
            this.TipoDeUsuarioID.Width = 125;
            // 
            // LimiteCredito
            // 
            this.LimiteCredito.HeaderText = "LimiteCredito";
            this.LimiteCredito.MinimumWidth = 6;
            this.LimiteCredito.Name = "LimiteCredito";
            this.LimiteCredito.ReadOnly = true;
            this.LimiteCredito.Width = 125;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha de Registro";
            this.FechaRegistro.MinimumWidth = 6;
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Width = 125;
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
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtTipoDeUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.CmdEliminar);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtLimiteCredito);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GestionUsuarios";
            this.Text = "GestionUsuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button CmdEliminar;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.Button CmdAnadir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTipoDeUsuario;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}