using HotelBerlin.Entity;
using System.Collections.Generic;
using System.Linq;

namespace HotelBerlin.DAL
{
    public class HabitacionDAL
    {
        private List<Habitacion> habitaciones; // Simulación de una base de datos en memoria

        public HabitacionDAL()
        {
            // Inicializamos la lista de habitaciones
            habitaciones = new List<Habitacion>();
        }

        // Método para agregar una habitación a la "base de datos"
        public void AgregarHabitacion(Habitacion habitacion)
        {
            habitaciones.Add(habitacion);
        }

        // Método para obtener todas las habitaciones de la "base de datos"
        public List<Habitacion> ObtenerTodasLasHabitaciones()
        {
            return habitaciones;
        }

        // Método para obtener una habitación por su número
        public Habitacion ObtenerHabitacionPorNumero(int numero)
        {
            return habitaciones.FirstOrDefault(h => h.Numero == numero);
        }

        // Método para actualizar el estado de una habitación
        public void ActualizarEstadoHabitacion(int numero, bool reservada, bool ocupada)
        {
            var habitacion = habitaciones.FirstOrDefault(h => h.Numero == numero);
            if (habitacion != null)
            {
                habitacion.Reservada = reservada;
                habitacion.Ocupada = ocupada;
            }
        }
    }
}
