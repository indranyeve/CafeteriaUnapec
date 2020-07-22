namespace CafeteriaUNAPEC
{
    partial class Usuarios
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
            this.idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeUsuarioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLimiteCredito = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.CmdEditar = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.CmdAnadir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuario,
            this.Nombre,
            this.Cedula,
            this.LimiteCredito,
            this.TipoDeUsuarioID,
            this.FechaRegistro,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 199);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // idUsuario
            // 
            this.idUsuario.HeaderText = "idUsuario";
            this.idUsuario.MinimumWidth = 6;
            this.idUsuario.Name = "idUsuario";
            this.idUsuario.ReadOnly = true;
            this.idUsuario.Visible = false;
            this.idUsuario.Width = 125;
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
            this.Cedula.HeaderText = "Cédula";
            this.Cedula.MinimumWidth = 6;
            this.Cedula.Name = "Cedula";
            this.Cedula.ReadOnly = true;
            this.Cedula.Width = 125;
            // 
            // LimiteCredito
            // 
            this.LimiteCredito.HeaderText = "Limite de Crédito";
            this.LimiteCredito.MinimumWidth = 6;
            this.LimiteCredito.Name = "LimiteCredito";
            this.LimiteCredito.ReadOnly = true;
            this.LimiteCredito.Width = 125;
            // 
            // TipoDeUsuarioID
            // 
            this.TipoDeUsuarioID.HeaderText = "Tipo De Usuario";
            this.TipoDeUsuarioID.MinimumWidth = 6;
            this.TipoDeUsuarioID.Name = "TipoDeUsuarioID";
            this.TipoDeUsuarioID.ReadOnly = true;
            this.TipoDeUsuarioID.Visible = false;
            this.TipoDeUsuarioID.Width = 125;
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
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(90, 248);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(13, 248);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(13, 309);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(52, 17);
            this.labelCedula.TabIndex = 3;
            this.labelCedula.Text = "Cédula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(90, 309);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(211, 22);
            this.txtCedula.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Límite de Crédito";
            // 
            // txtLimiteCredito
            // 
            this.txtLimiteCredito.Location = new System.Drawing.Point(540, 252);
            this.txtLimiteCredito.Name = "txtLimiteCredito";
            this.txtLimiteCredito.Size = new System.Drawing.Size(211, 22);
            this.txtLimiteCredito.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(182, 494);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(388, 22);
            this.txtID.TabIndex = 23;
            this.txtID.Visible = false;
            // 
            // CmdEditar
            // 
            this.CmdEditar.Location = new System.Drawing.Point(306, 394);
            this.CmdEditar.Name = "CmdEditar";
            this.CmdEditar.Size = new System.Drawing.Size(145, 76);
            this.CmdEditar.TabIndex = 22;
            this.CmdEditar.Text = "&Eliminar";
            this.CmdEditar.UseVisualStyleBackColor = true;
            this.CmdEditar.Click += new System.EventHandler(this.CmdEliminar_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Location = new System.Drawing.Point(526, 394);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(145, 76);
            this.CmdLimpiar.TabIndex = 21;
            this.CmdLimpiar.Text = "&Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.CmdLimpiar_Click);
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.Location = new System.Drawing.Point(91, 394);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(145, 76);
            this.CmdAnadir.TabIndex = 20;
            this.CmdAnadir.Text = "&Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 543);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.CmdEditar);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtLimiteCredito);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeUsuarioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLimiteCredito;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button CmdEditar;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.Button CmdAnadir;
    }
}