using HotelBerlin.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelBerlin.DAL
{
    public class ReservaDAL
    {
        private List<Reserva> reservas; // Simulación de una base de datos en memoria

        public ReservaDAL()
        {
            // Inicializamos la lista de reservas
            reservas = new List<Reserva>();
        }

        // Método para agregar una reserva a la "base de datos"
        public void AgregarReserva(Reserva reserva)
        {
            reserva.Id = reservas.Count + 1; // Generamos un ID único para la reserva
            reservas.Add(reserva);
        }

        // Método para obtener todas las reservas de la "base de datos"
        public List<Reserva> ObtenerTodasLasReservas()
        {
            return reservas;
        }

        // Método para obtener una reserva por su ID
        public Reserva ObtenerReservaPorId(int id)
        {
            return reservas.FirstOrDefault(r => r.Id == id);
        }

        // Método para obtener todas las reservas de un cliente
        public List<Reserva> ObtenerReservasDeCliente(int clienteId)
        {
            return reservas.Where(r => r.Cliente.Id == clienteId).ToList();
        }

        // Método para actualizar el estado de una reserva
        public void ActualizarEstadoReserva(int id, EstadoReserva estado)
        {
            var reserva = reservas.FirstOrDefault(r => r.Id == id);
            if (reserva != null)
            {
                reserva.Estado = estado;
            }
        }

        // Método para obtener todas las reservas en un rango de fechas
        public List<Reserva> ObtenerReservasEnRangoDeFechas(DateTime inicio, DateTime fin)
        {
            return reservas.Where(r => r.FechaInicio >= inicio && r.FechaFin <= fin).ToList();
        }
    }
}
