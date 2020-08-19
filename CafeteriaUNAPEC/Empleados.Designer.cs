namespace CafeteriaUNAPEC
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
            this.txtPorcientoComision = new System.Windows.Forms.TextBox();
            this.CmdAnadir = new System.Windows.Forms.Button();
            this.CmdLimpiar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CmdEditar = new System.Windows.Forms.Button();
            this.empleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButtonMatutina = new System.Windows.Forms.RadioButton();
            this.radioButtonVespertina = new System.Windows.Forms.RadioButton();
            this.radioButtonNocturna = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNombre.Location = new System.Drawing.Point(21, 322);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(68, 20);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // labelTandaLabor
            // 
            this.labelTandaLabor.AutoSize = true;
            this.labelTandaLabor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTandaLabor.Location = new System.Drawing.Point(701, 370);
            this.labelTandaLabor.Name = "labelTandaLabor";
            this.labelTandaLabor.Size = new System.Drawing.Size(103, 20);
            this.labelTandaLabor.TabIndex = 2;
            this.labelTandaLabor.Text = "Tanda/Labor";
            this.labelTandaLabor.Click += new System.EventHandler(this.labelTandaLabor_Click);
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCedula.Location = new System.Drawing.Point(21, 375);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(61, 20);
            this.labelCedula.TabIndex = 3;
            this.labelCedula.Text = "Cédula";
            this.labelCedula.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelPorcientoComision
            // 
            this.labelPorcientoComision.AutoSize = true;
            this.labelPorcientoComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelPorcientoComision.Location = new System.Drawing.Point(701, 322);
            this.labelPorcientoComision.Name = "labelPorcientoComision";
            this.labelPorcientoComision.Size = new System.Drawing.Size(155, 20);
            this.labelPorcientoComision.TabIndex = 4;
            this.labelPorcientoComision.Text = "Porciento/Comisión";
            this.labelPorcientoComision.Click += new System.EventHandler(this.labelPorcientoComision_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombre.Location = new System.Drawing.Point(198, 318);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(388, 26);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCedula.Location = new System.Drawing.Point(198, 370);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(388, 26);
            this.txtCedula.TabIndex = 8;
            this.txtCedula.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPorcientoComision
            // 
            this.txtPorcientoComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPorcientoComision.Location = new System.Drawing.Point(928, 322);
            this.txtPorcientoComision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPorcientoComision.Name = "txtPorcientoComision";
            this.txtPorcientoComision.Size = new System.Drawing.Size(388, 26);
            this.txtPorcientoComision.TabIndex = 10;
            this.txtPorcientoComision.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // CmdAnadir
            // 
            this.CmdAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdAnadir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CmdAnadir.Location = new System.Drawing.Point(928, 430);
            this.CmdAnadir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdAnadir.Name = "CmdAnadir";
            this.CmdAnadir.Size = new System.Drawing.Size(123, 51);
            this.CmdAnadir.TabIndex = 14;
            this.CmdAnadir.Text = "&Guardar";
            this.CmdAnadir.UseVisualStyleBackColor = true;
            this.CmdAnadir.Click += new System.EventHandler(this.CmdAnadir_Click);
            // 
            // CmdLimpiar
            // 
            this.CmdLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdLimpiar.Location = new System.Drawing.Point(1186, 430);
            this.CmdLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdLimpiar.Name = "CmdLimpiar";
            this.CmdLimpiar.Size = new System.Drawing.Size(123, 51);
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1357, 261);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // CmdEditar
            // 
            this.CmdEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CmdEditar.Location = new System.Drawing.Point(1057, 430);
            this.CmdEditar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdEditar.Name = "CmdEditar";
            this.CmdEditar.Size = new System.Drawing.Size(123, 51);
            this.CmdEditar.TabIndex = 17;
            this.CmdEditar.Text = "&Eliminar";
            this.CmdEditar.UseVisualStyleBackColor = true;
            this.CmdEditar.Click += new System.EventHandler(this.CmdEliminar);
            // 
            // radioButtonMatutina
            // 
            this.radioButtonMatutina.AutoSize = true;
            this.radioButtonMatutina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonMatutina.Location = new System.Drawing.Point(928, 368);
            this.radioButtonMatutina.Name = "radioButtonMatutina";
            this.radioButtonMatutina.Size = new System.Drawing.Size(94, 24);
            this.radioButtonMatutina.TabIndex = 20;
            this.radioButtonMatutina.TabStop = true;
            this.radioButtonMatutina.Text = "Matutina";
            this.radioButtonMatutina.UseVisualStyleBackColor = true;
            // 
            // radioButtonVespertina
            // 
            this.radioButtonVespertina.AutoSize = true;
            this.radioButtonVespertina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonVespertina.Location = new System.Drawing.Point(1061, 368);
            this.radioButtonVespertina.Name = "radioButtonVespertina";
            this.radioButtonVespertina.Size = new System.Drawing.Size(110, 24);
            this.radioButtonVespertina.TabIndex = 21;
            this.radioButtonVespertina.TabStop = true;
            this.radioButtonVespertina.Text = "Vespertina";
            this.radioButtonVespertina.UseVisualStyleBackColor = true;
            // 
            // radioButtonNocturna
            // 
            this.radioButtonNocturna.AutoSize = true;
            this.radioButtonNocturna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioButtonNocturna.Location = new System.Drawing.Point(1206, 368);
            this.radioButtonNocturna.Name = "radioButtonNocturna";
            this.radioButtonNocturna.Size = new System.Drawing.Size(98, 24);
            this.radioButtonNocturna.TabIndex = 22;
            this.radioButtonNocturna.TabStop = true;
            this.radioButtonNocturna.Text = "Nocturna";
            this.radioButtonNocturna.UseVisualStyleBackColor = true;
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1357, 515);
            this.Controls.Add(this.radioButtonNocturna);
            this.Controls.Add(this.radioButtonVespertina);
            this.Controls.Add(this.radioButtonMatutina);
            this.Controls.Add(this.CmdEditar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmdLimpiar);
            this.Controls.Add(this.CmdAnadir);
            this.Controls.Add(this.txtPorcientoComision);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelPorcientoComision);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.labelTandaLabor);
            this.Controls.Add(this.labelNombre);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Empleados";
            this.Text = "Mantenimiento Empleados";
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
        private System.Windows.Forms.TextBox txtPorcientoComision;
        private System.Windows.Forms.Button CmdAnadir;
        private System.Windows.Forms.Button CmdLimpiar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button CmdEditar;
        private System.Windows.Forms.RadioButton radioButtonMatutina;
        private System.Windows.Forms.RadioButton radioButtonVespertina;
        private System.Windows.Forms.RadioButton radioButtonNocturna;
    }
}