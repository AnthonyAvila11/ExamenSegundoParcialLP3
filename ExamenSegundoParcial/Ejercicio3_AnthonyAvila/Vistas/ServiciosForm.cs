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
    public partial class ServiciosForm : Form
    {

        public ServiciosForm()
        {
            InitializeComponent();
            TipServiceController comand = new TipServiceController(this);

            CelularesGBX.Enabled = false;
            CompuGBX.Enabled = false;
            CelularesRadioButton.Checked = false;
            CompuRadioButton.Checked = false;
        }

        private void CelularesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CelularesRadioButton.Checked == true)
            {
                CelularesGBX.Enabled = true;
                CompuGBX.Enabled = false;
                CompuNombreTBox.Clear();

            }
        }

        private void CompuRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CompuRadioButton.Checked == true)
            {
                CompuGBX.Enabled = true;
                CelularesGBX.Enabled = false;
                CelNombreTBox.Clear();
            }
        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProcesoServicioBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
