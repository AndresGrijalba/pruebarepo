namespace HotelBerlin.Entity
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }
        public string Correo { get; set; }

        // Constructor
        public Cliente(int id, string nombre, string cedula, string telefono, string sexo, string correo)
        {
            Id = id;
            Nombre = nombre;
            Cedula = cedula;
            Telefono = telefono;
            Sexo = sexo;
            Correo = correo;
        }
    }
}
