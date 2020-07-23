﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaUNAPEC
{
    public partial class Empleados : Form
    {
        private SqlConnection dbCafeteria = connection.cadenaConexion;
        public Empleados()
        {
            InitializeComponent();
            ActualizarTabla();
        }

        public void LimpiarCampos()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCedula.Text = "";
            txtTandaLabor.Text = "";
            txtPorcientoComision.Text = "";
        }
        public void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();
            string dbString = "Select * from Empleado where Estado = 1";
            SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
            dbCafeteria.Open();
            using (SqlDataReader Lector = Consulta.ExecuteReader())
            {
                while (Lector.Read())
                {
                    dataGridView1.Rows.Add(Lector["EmpleadoID"].ToString(), Lector["Nombre"].ToString(),
                        Lector["Cedula"].ToString(), Lector["TandaLabor"].ToString(), Lector["PorcentajeComision"].ToString(),
                        Lector["FechaIngreso"].ToString());

                }
                dbCafeteria.Close();
            }
        }

        //Evento Añadir
        private void CmdAnadir_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                var TandaLabor = txtTandaLabor.Text;
                var PorcientajeComision = Convert.ToInt32(txtPorcientoComision.Text);
                string FechaIngreso = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");
                var Estado = "1";
                try
                {
                    dbCafeteria.Open();
                    string dbString = "insert into Empleado values('" + Nombre + "', '" + Cedula + "', '" + TandaLabor + "', '"
                        + PorcientajeComision + "', '" + FechaIngreso + "', '" + Estado + "')";
                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al insertar un registro");
                    throw;
                }
            }
            else
            {
                var ID = txtID.Text;
                var Nombre = txtNombre.Text;
                var Cedula = txtCedula.Text;
                var TandaLabor = txtTandaLabor.Text;
                var PorcientajeComision = Convert.ToInt32(txtPorcientoComision.Text);
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Empleado set Nombre = '"+Nombre+"', Cedula = '"+Cedula+"', TandaLabor = '"+TandaLabor+ "',  PorcentajeComision = '" + PorcientajeComision + "' where EmpleadoID ="+ID;
                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar un registro");
                    throw;
                }
            }

        }

        //Limpiar Campos
        private void LimpiarRegistro(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //Evento Recoger Datos de la Fila
        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCedula.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTandaLabor.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPorcientoComision.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            
        }

        //Eliminar
        private void CmdEliminar(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("No has seleccionado una fila para eliminar");
            }
            else
            {
                var ID = txtID.Text;
                try
                {
                    dbCafeteria.Open();
                    string dbString = "update Empleado set Estado = 0 where EmpleadoID =" + ID;
                    SqlCommand Consulta = new SqlCommand(dbString, dbCafeteria);
                    Consulta.ExecuteNonQuery();
                    dbCafeteria.Close();
                    ActualizarTabla();
                    LimpiarCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error al actualizar un registro");
                    
                }
            }
        }
        private void CmdEditar_Click(object sender, EventArgs e)
        {

        }
        private void Empleados_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void labelTandaLabor_Click(object sender, EventArgs e)
        {

        }

        private void txtTandaLabor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPorcientoComision_Click(object sender, EventArgs e)
        {

        }

        private void labelFechaIngreso_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFechaIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

