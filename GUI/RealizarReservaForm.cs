using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using HotelBerlin.BLL;
using HotelBerlin.Entity;

namespace HotelBerlin.GUI
{
    public partial class RealizarReservaForm : Form
    {
        private ClienteBLL clienteBLL;
        private HabitacionBLL habitacionBLL;
        private ReservaBLL reservaBLL;

        public RealizarReservaForm()
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
            habitacionBLL = new HabitacionBLL();
            reservaBLL = new ReservaBLL();

            CargarClientes();
            CargarHabitacionesDisponibles();
        }

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteBLL.ObtenerTodosLosClientes();
            cmbCliente.DataSource = clientes;
            cmbCliente.DisplayMember = "Nombre";
            cmbCliente.ValueMember = "Id";
        }

        private void CargarHabitacionesDisponibles()
        {
            List<Habitacion> habitaciones = habitacionBLL.ObtenerTodasLasHabitaciones();

            cmbHabitacion.Items.Clear();
            foreach (Habitacion habitacion in habitaciones)
            {
                if (!habitacion.Reservada && !habitacion.Ocupada)
                {
                    cmbHabitacion.Items.Add(habitacion);
                }
            }
            cmbHabitacion.DisplayMember = "Numero";
        }

        private void btnRealizarReserva_Click(object sender, EventArgs e)
        {
            Cliente cliente = (Cliente)cmbCliente.SelectedItem;
            Habitacion habitacion = (Habitacion)cmbHabitacion.SelectedItem;
            DateTime fechaReserva = DateTime.Now;
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFin.Value;

            // Validación de fechas
            if (fechaFin <= fechaInicio)
            {
                MessageBox.Show("La fecha de fin de la reserva debe ser posterior a la fecha de inicio.");
                return;
            }

            // Crear la reserva
            Reserva reserva = new Reserva(0, cliente, habitacion, fechaReserva, fechaInicio, fechaFin, EstadoReserva.Vigente);
            reservaBLL.AgregarReserva(reserva);

            MessageBox.Show("Reserva realizada correctamente.");

            // Limpiar los campos del formulario
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cmbCliente.SelectedIndex = -1;
            cmbHabitacion.SelectedIndex = -1;
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;
        }
    }
}
