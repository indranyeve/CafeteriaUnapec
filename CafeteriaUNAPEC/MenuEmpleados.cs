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
    public partial class MenuEmpleados : Form
    {
        public MenuEmpleados()
        {
            InitializeComponent();
        }

        private void btnConsultaArticulos_Click(object sender, EventArgs e)
        {
            GestionArticulos form = new GestionArticulos();
            form.Show();
        }
    }
}
