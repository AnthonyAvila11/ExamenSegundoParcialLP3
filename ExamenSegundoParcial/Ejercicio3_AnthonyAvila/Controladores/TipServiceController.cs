using Ejercicio3_AnthonyAvila.Modelos.DAO;
using Ejercicio3_AnthonyAvila.Modelos.Entidadaes;
using Ejercicio3_AnthonyAvila.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3_AnthonyAvila.Controladores
{
    class TipServiceController
    {
        ServiciosForm vista;

        public TipServiceController(ServiciosForm view)
        {
            vista = view;

            vista.ProcesoServicioBTN.Click += new EventHandler(InsertarDatos);
        }

        private void InsertarDatos(object sender, EventArgs e)
        {
            TipoSopoteDAO tipoDAO = new TipoSopoteDAO();
            TipoSoporte soporte = new TipoSoporte();

            soporte.Tipo = SaberTipo();
            soporte.Modelo = SaberModelo();

            bool insertar = tipoDAO.InsertarDatos(soporte);

            if (insertar)
            {                
                MessageBox.Show("Dato Insertado en la base", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo insertar el dato", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public string SaberTipo()
        {
            string STipo = "";
            if (vista.CelularesRadioButton.Checked == true)
            {
                STipo = "Reparacion de Celulares";
            }
            else if (vista.CompuRadioButton.Checked == true)
            {
                STipo = "Reparacion de Computadora";
            }
            return STipo;
        }

        public string SaberModelo()
        {
            string SModelo = "";
            if (vista.CelularesRadioButton.Checked == true)
            {
                SModelo = vista.CelNombreTBox.Text;
            }
            else if (vista.CompuRadioButton.Checked == true)
            {
                SModelo = vista.CompuNombreTBox.Text;
            }
            return SModelo;
        }
    }
}
