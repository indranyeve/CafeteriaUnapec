﻿namespace CafeteriaUNAPEC
{
    partial class Empleados
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTandaLabor = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.labelPorcientoComision = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTandaLabor = new System.Windows.Forms.TextBox();
            this.txtPorcientoComision = new System.Windows.Forms.TextBox();
            this.CmdAnadir = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TandaLabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcientoComision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.CmdEditar = new System.Windows.Forms.Button();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(24, 280);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // labelTandaLabor
            // 
            this.labelTandaLabor.AutoSize = true;
            this.labelTandaLabor.Location = new System.Drawing.Point(704, 329);
            this.labelTandaLabor.Name = "labelTandaLabor";
            this.labelTandaLabor.Size = new System.Drawing.Size(90, 17);
            this.labelTandaLabor.TabIndex = 2;
            this.labelTandaLabor.Text = "Tanda/Labor";
            this.labelTandaLabor.Click += new System.EventHandler(this.labelTandaLabor_Click);
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Location = new System.Drawing.Point(24, 334);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(52, 17);
            this.labelCedula.TabIndex = 3;
            this.labelCedula.Text = "Cédula";
            this.labelCedula.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelPorcientoComision
            // 
            this.labelPorcientoComision.AutoSize = true;
            this.labelPorcientoComision.Location = new System.Drawing.Point(704, 280);
            this.labelPorcientoComision.Name = "labelPorcientoComision";
            this.labelPorcientoComision.Size = new System.Drawing.Size(129, 17);
            this.labelPorcientoComision.TabIndex = 4;
            this.labelPorcientoComision.Text = "Porciento/Comisión";
            this.labelPorcientoComision.Click += new System.EventHandler(this.labelPorcientoComision_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 277);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(388, 22);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(201, 329);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(388, 22);
            this.txtCedula.TabIndex = 8;
            this.txtCedula.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTandaLabor
            // 
            this.txtTandaLabor.Location = new System.Drawing.Point(931, 324);
            this.txtTandaLabor.Name = "txtTandaLabor";
            this.txtTandaLabor.Size = new System.Drawing.Size(388, 22);
            this.txtTandaLabor.TabIndex = 9;
            this.txtTandaLabor.TextChanged += new System.EventHandler(this.txtTandaLabor_TextChanged);
            // 
            // txtPorcientoComision
            // 
            this.txtPorcientoComision.Location = new System.Drawing.Point(931, 280);
            this.txtPorcientoComision.Name = "txtPorcientoComision";
            this.txtPorcientoComision.Size = new System.Drawing.Size(388, 22);
            this.txtPorcientoComision.TabIndex = 10;
            this.txtPorcientoComision.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.Location = new System.Drawing.Point(432, 499);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(145, 76);
            this.CmdAnadir.TabIndex = 14;
            this.CmdAnadir.Text = "&Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.Location = new System.Drawing.Point(867, 499);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(145, 76);
            this.CmdLimpiar.TabIndex = 15;
            this.CmdLimpiar.Text = "&Limpiar";
            this.CmdLimpiar.UseVisualStyleBackColor = true;
            this.CmdLimpiar.Click += new System.EventHandler(this.LimpiarRegistro);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.Nombre,
            this.Cedula,
            this.TandaLabor,
            this.PorcientoComision,
            this.FechaIngreso});
            this.dataGridView1.Location = new System.Drawing.Point(15, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1331, 199);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // idEmpleado
            // 
            this.idEmpleado.HeaderText = "idEmpleado";
            this.idEmpleado.MinimumWidth = 6;
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            this.idEmpleado.Visible = false;
            this.idEmpleado.Width = 125;
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
            // TandaLabor
            // 
            this.TandaLabor.HeaderText = "TandaLabor";
            this.TandaLabor.MinimumWidth = 6;
            this.TandaLabor.Name = "TandaLabor";
            this.TandaLabor.ReadOnly = true;
            this.TandaLabor.Width = 125;
            // 
            // PorcientoComision
            // 
            this.PorcientoComision.HeaderText = "PorcientoComision";
            this.PorcientoComision.MinimumWidth = 6;
            this.PorcientoComision.Name = "PorcientoComision";
            this.PorcientoComision.ReadOnly = true;
            this.PorcientoComision.Width = 125;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "FechaIngreso";
            this.FechaIngreso.MinimumWidth = 6;
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Width = 125;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(483, 601);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(388, 22);
            this.txtID.TabIndex = 19;
            this.txtID.Visible = false;
            this.txtID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CmdEditar
            // 
            this.CmdEditar.Location = new System.Drawing.Point(647, 499);
            this.CmdEditar.Name = "CmdEditar";
            this.CmdEditar.Size = new System.Drawing.Size(145, 76);
            this.CmdEditar.TabIndex = 17;
            this.CmdEditar.Text = "&Eliminar";
            this.CmdEditar.UseVisualStyleBackColor = true;
            this.CmdEditar.Click += new System.EventHandler(this.CmdEliminar);
            // 
            // empleadoBindingSource
            // 
            //this.empleadoBindingSource.DataSource = typeof(CafeteriaUNAPEC.Modelos.Empleado);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 625);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.CmdEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtPorcientoComision);
            this.Controls.Add(this.txtTandaLabor);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelPorcientoComision);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.labelTandaLabor);
            this.Controls.Add(this.labelNombre);
            this.Name = "Empleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource empleadoBindingSource;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTandaLabor;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.Label labelPorcientoComision;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTandaLabor;
        private System.Windows.Forms.TextBox txtPorcientoComision;
        private System.Windows.Forms.Button CmdAnadir;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn TandaLabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcientoComision;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.Button CmdEditar;
    }
}