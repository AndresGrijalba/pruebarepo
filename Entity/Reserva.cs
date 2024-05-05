using HotelBerlin.Entity;
using System;

namespace HotelBerlin.Entity
{
    public class Reserva
    {
        // Propiedades de la reserva
        public int Id { get; set; } // Identificador único de la reserva
        public Cliente Cliente { get; set; } // Cliente que realiza la reserva
        public Habitacion Habitacion { get; set; } // Habitación reservada
        public DateTime FechaReserva { get; set; } // Fecha de la reserva
        public DateTime FechaInicio { get; set; } // Fecha de inicio de la reserva
        public DateTime FechaFin { get; set; } // Fecha de fin de la reserva
        public EstadoReserva Estado { get; set; } // Estado de la reserva (Vigente, Vencida, Cancelada)

        // Constructor
        public Reserva(int id, Cliente cliente, Habitacion habitacion, DateTime fechaReserva, DateTime fechaInicio, DateTime fechaFin, EstadoReserva estado)
        {
            Id = id;
            Cliente = cliente;
            Habitacion = habitacion;
            FechaReserva = fechaReserva;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            Estado = estado;
        }
    }

    // Enumeración para el estado de la reserva
    public enum EstadoReserva
    {
        Vigente,
        Vencida,
        Cancelada
    }
}
