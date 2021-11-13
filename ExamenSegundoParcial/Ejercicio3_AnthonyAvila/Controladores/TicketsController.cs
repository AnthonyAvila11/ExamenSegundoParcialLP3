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
    class TicketsController
    {
        TicketsForm vista;
        DetallesForm vistas;
        TicketDAO _tiket = new TicketDAO();

        public TicketsController(DetallesForm views)
        {
            vistas = views;

            vistas.Load += new EventHandler(Load);
        }

        private void Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            vistas.DGVDetalles.DataSource = _tiket.GetTicket();
        }

        public TicketsController(TicketsForm view)
        {
            vista = view;

            vista.TicketBtn.Click += new EventHandler(InsertarDato);
        }

        private void InsertarDato(object sender, EventArgs e)
        {
            TicketDAO ticketDAO = new TicketDAO();
            Ticket _tiket = new Ticket();

            _tiket.NomCliente = vista.IdClienteTBox.Text;
            _tiket.TipoSop = vista.TipoServicioTBox.Text;
            _tiket.ModeloSop = vista.ModeloTBox.Text;
            _tiket.DescripcionMod = vista.DescripcionTBox.Text;

            bool insertar = ticketDAO.InsertarDato(_tiket);

            if (insertar)
            {
                MessageBox.Show("Dato Insertado en la base", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo insertar el dato", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
