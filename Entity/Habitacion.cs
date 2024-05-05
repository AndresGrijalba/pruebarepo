using HotelBerlin.Entity;

namespace HotelBerlin.Entity
{
    public class Habitacion
    {
        // Propiedades de la habitación
        public int Numero { get; set; } // Número de la habitación
        public string Tipo { get; set; } // Tipo de habitación (individual, doble, suite, etc.)
        public bool Reservada { get; set; } // Indica si la habitación está reservada
        public bool Ocupada { get; set; } // Indica si la habitación está ocupada

        // Cliente que ocupa la habitación (null si la habitación no está ocupada)
        public Cliente ClienteOcupante { get; set; }

        // Constructor
        public Habitacion(int numero, string tipo)
        {
            Numero = numero;
            Tipo = tipo;
            Reservada = false; // Al iniciar, la habitación no está reservada
            Ocupada = false; // Al iniciar, la habitación no está ocupada
            ClienteOcupante = null; // Al iniciar, no hay ningún cliente ocupando la habitación
        }
    }
}
