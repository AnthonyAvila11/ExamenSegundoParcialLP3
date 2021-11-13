using Ejercicio3_AnthonyAvila.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_AnthonyAvila.Vistas
{
    public partial class DetallesForm : Form
    {
        public DetallesForm()
        {
            InitializeComponent();
            TicketsController con = new TicketsController(this);
        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DetallesForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
