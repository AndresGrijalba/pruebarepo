using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HotelBerlin.BLL;
using HotelBerlin.Entity;

namespace HotelBerlin.GUI
{
    public partial class ListaHabitacionesDisponiblesForm : Form
    {
        private HabitacionBLL habitacionBLL;

        public ListaHabitacionesDisponiblesForm()
        {
            InitializeComponent();
            habitacionBLL = new HabitacionBLL();
            CargarHabitacionesDisponibles();
        }

        private void CargarHabitacionesDisponibles()
        {
            List<Habitacion> habitaciones = habitacionBLL.ObtenerTodasLasHabitaciones();

            dgvHabitacionesDisponibles.Rows.Clear();

            foreach (Habitacion habitacion in habitaciones)
            {
                if (!habitacion.Reservada && !habitacion.Ocupada)
                {
                    dgvHabitacionesDisponibles.Rows.Add(habitacion.Numero, habitacion.Tipo, habitacion.PrecioPorNoche);
                }
            }
        }
    }
}
