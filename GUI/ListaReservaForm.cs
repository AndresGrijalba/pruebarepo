using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelBerlin.BLL;
using HotelBerlin.Entity;

namespace HotelBerlin.GUI
{
    public partial class ListaReservasForm : Form
    {
        private ReservaBLL reservaBLL;

        public ListaReservasForm()
        {
            InitializeComponent();
            reservaBLL = new ReservaBLL();
            CargarReservas();
        }

        private void CargarReservas()
        {
            List<Reserva> reservas = reservaBLL.ObtenerTodasLasReservas();

            dgvReservas.Rows.Clear();

            foreach (Reserva reserva in reservas)
            {
                dgvReservas.Rows.Add(reserva.Id, reserva.Cliente.Nombre, reserva.Habitacion.Numero, reserva.FechaInicio.ToShortDateString(), reserva.FechaFin.ToShortDateString(), reserva.Estado);
            }
        }
    }
}
