using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio3_AnthonyAvila.Vistas
{
    public partial class MenuView : Syncfusion.Windows.Forms.Office2010Form
    {
        public MenuView()
        {
            InitializeComponent();

        }

        ServiciosForm formServicio;
        TicketsForm formTickets;
        DetallesForm formDetalle;

        private void vistaForm(object sender, FormClosedEventArgs e)
        {
            formServicio = null;
            formDetalle = null;
            formTickets = null;
        }

        private void TicketsToolStripTabItem3_Click(object sender, EventArgs e)
        {
            if (formTickets == null)
            {
                formTickets = new TicketsForm();
                formTickets.MdiParent = this;
                formTickets.FormClosed += vistaForm;
                formTickets.Show();
            }
            else
            {
                formTickets.Activate();
            }
        }

        private void DetallesToolStripTabItem5_Click(object sender, EventArgs e)
        {
            if (formDetalle == null)
            {
                formDetalle = new DetallesForm();
                formDetalle.MdiParent = this;
                formDetalle.FormClosed += vistaForm;
                formDetalle.Show();
            }
            else
            {
                formDetalle.Activate();
            }
        }

        private void ServicioToolStripTabItem2_Click(object sender, EventArgs e)
        {

            if (formServicio == null)
            {
                formServicio = new ServiciosForm();
                formServicio.MdiParent = this;
                formServicio.FormClosed += vistaForm;
                formServicio.Show();
            }
            else
            {
                formServicio.Activate();
            }
        }

    }
}
