using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeteriaUNAPEC
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultaEmpleados_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            //Buton de salida (evento)
            this.Hide();
            Login log = new Login();
            log.Show();
        }

        private void btnConsultaEmpleados_Click_1(object sender, EventArgs e)
        {
            //Llamando al CRUD de Empleados
            Empleados form = new Empleados();
            form.Show();
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe form = new AcercaDe();
            form.Show();
            
        }

        private void btnConsultaTDU_Click(object sender, EventArgs e)
        {
            TipoDeUsuario form = new TipoDeUsuario();
            form.Show();
        }

        private void btnConsultaMarcas_Click(object sender, EventArgs e)
        {
            GestionMarcas form = new GestionMarcas();
            form.Show();
        }

        private void btnConsultaCampus_Click(object sender, EventArgs e)
        {
            GestionCampus form = new GestionCampus();
            form.Show();
        }
    }
}
