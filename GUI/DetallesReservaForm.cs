using System;
using System.Windows.Forms;
using HotelBerlin.BLL;
using HotelBerlin.Entity;

namespace HotelBerlin.GUI
{
    public partial class DetallesReservaForm : Form
    {
        private ReservaBLL reservaBLL;
        private int reservaId;

        public DetallesReservaForm(int idReserva)
        {
            InitializeComponent();
            reservaBLL = new ReservaBLL();
            reservaId = idReserva;
            MostrarDetallesReserva();
        }

        private void MostrarDetallesReserva()
        {
            Reserva reserva = reservaBLL.ObtenerReservaPorId(reservaId);

            if (reserva != null)
            {
                lblIdReserva.Text = reserva.Id.ToString();
                lblNombreCliente.Text = reserva.Cliente.Nombre;
                lblNumeroHabitacion.Text = reserva.Habitacion.Numero.ToString();
                lblFechaInicio.Text = reserva.FechaInicio.ToShortDateString();
                lblFechaFin.Text = reserva.FechaFin.ToShortDateString();
                lblEstado.Text = reserva.Estado.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró la reserva especificada.");
                this.Close();
            }
        }
    }
}
