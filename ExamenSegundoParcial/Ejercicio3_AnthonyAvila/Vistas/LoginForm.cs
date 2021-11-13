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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            LoginController controlador = new LoginController(this);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistroBTN_Click(object sender, EventArgs e)
        {
            Form registrarse = new RegistroForm();
            registrarse.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
