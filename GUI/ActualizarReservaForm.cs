using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelBerlin.BLL;
using HotelBerlin.Entity;

namespace HotelBerlin.GUI
{
    public partial class ActualizarReservaForm : Form
    {
        private ReservaBLL reservaBLL;
        private int reservaId;

        public ActualizarReservaForm(int idReserva)
        {
            InitializeComponent();
            reservaBLL = new ReservaBLL();
            reservaId = idReserva;
            CargarDatosReserva();
        }

        private void CargarDatosReserva()
        {
            Reserva reserva = reservaBLL.ObtenerReservaPorId(reservaId);

            if (reserva != null)
            {
                cmbEstado.SelectedItem = reserva.Estado;
                dtpFechaInicio.Value = reserva.FechaInicio;
                dtpFechaFin.Value = reserva.FechaFin;
            }
            else
            {
                MessageBox.Show("No se encontró la reserva especificada.");
                this.Close();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            EstadoReserva nuevoEstado = (EstadoReserva)cmbEstado.SelectedItem;
            DateTime nuevaFechaInicio = dtpFechaInicio.Value;
            DateTime nuevaFechaFin = dtpFechaFin.Value;

            // Validación de fechas
            if (nuevaFechaFin <= nuevaFechaInicio)
            {
                MessageBox.Show("La fecha de fin de la reserva debe ser posterior a la fecha de inicio.");
                return;
            }

            // Actualizar la reserva
            reservaBLL.ActualizarEstadoReserva(reservaId, nuevoEstado);
            MessageBox.Show("Reserva actualizada correctamente.");

            // Cerrar el formulario
            this.Close();
        }
    }
}
