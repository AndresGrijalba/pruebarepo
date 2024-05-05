using HotelBerlin.DAL;
using HotelBerlin.Entity;
using System;
using System.Collections.Generic;

namespace HotelBerlin.BLL
{
    public class ReservaBLL
    {
        private ReservaDAL reservaDAL;

        public ReservaBLL()
        {
            reservaDAL = new ReservaDAL();
        }

        // Método para agregar una reserva
        public void AgregarReserva(Reserva reserva)
        {
            reservaDAL.AgregarReserva(reserva);
        }

        // Método para obtener todas las reservas
        public List<Reserva> ObtenerTodasLasReservas()
        {
            return reservaDAL.ObtenerTodasLasReservas();
        }

        // Método para obtener una reserva por su ID
        public Reserva ObtenerReservaPorId(int id)
        {
            return reservaDAL.ObtenerReservaPorId(id);
        }

        // Método para obtener todas las reservas de un cliente
        public List<Reserva> ObtenerReservasDeCliente(int clienteId)
        {
            return reservaDAL.ObtenerReservasDeCliente(clienteId);
        }

        // Método para actualizar el estado de una reserva
        public void ActualizarEstadoReserva(int id, EstadoReserva estado)
        {
            reservaDAL.ActualizarEstadoReserva(id, estado);
        }

        // Método para obtener todas las reservas en un rango de fechas
        public List<Reserva> ObtenerReservasEnRangoDeFechas(DateTime inicio, DateTime fin)
        {
            return reservaDAL.ObtenerReservasEnRangoDeFechas(inicio, fin);
        }
    }
}
