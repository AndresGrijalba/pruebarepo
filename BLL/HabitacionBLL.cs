using HotelBerlin.DAL;
using HotelBerlin.Entity;
using System.Collections.Generic;

namespace HotelBerlin.BLL
{
    public class HabitacionBLL
    {
        private HabitacionDAL habitacionDAL;

        public HabitacionBLL()
        {
            habitacionDAL = new HabitacionDAL();
        }

        // Método para agregar una habitación
        public void AgregarHabitacion(Habitacion habitacion)
        {
            habitacionDAL.AgregarHabitacion(habitacion);
        }

        // Método para obtener todas las habitaciones
        public List<Habitacion> ObtenerTodasLasHabitaciones()
        {
            return habitacionDAL.ObtenerTodasLasHabitaciones();
        }

        // Método para obtener una habitación por su número
        public Habitacion ObtenerHabitacionPorNumero(int numero)
        {
            return habitacionDAL.ObtenerHabitacionPorNumero(numero);
        }

        // Método para actualizar el estado de una habitación
        public void ActualizarEstadoHabitacion(int numero, bool reservada, bool ocupada)
        {
            habitacionDAL.ActualizarEstadoHabitacion(numero, reservada, ocupada);
        }
    }
}
