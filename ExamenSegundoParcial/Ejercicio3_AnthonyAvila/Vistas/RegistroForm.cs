using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_AnthonyAvila
{
    public partial class RegistroForm : Form
    {
        public RegistroForm()
        {
            InitializeComponent();
            LoginController comand = new LoginController(this);
        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            Form login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void CrearBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
