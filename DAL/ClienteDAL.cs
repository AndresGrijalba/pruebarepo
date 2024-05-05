using HotelBerlin.Entity;
using System.Collections.Generic;
using System.Linq;

namespace HotelBerlin.DAL
{
    public class ClienteDAL
    {
        private List<Cliente> clientes; // Simulación de una base de datos en memoria

        public ClienteDAL()
        {
            // Inicializamos la lista de clientes
            clientes = new List<Cliente>();
        }

        // Método para agregar un cliente a la "base de datos"
        public void AgregarCliente(Cliente cliente)
        {
            cliente.Id = clientes.Count + 1; // Generamos un ID único para el cliente
            clientes.Add(cliente);
        }

        // Método para obtener todos los clientes de la "base de datos"
        public List<Cliente> ObtenerTodosLosClientes()
        {
            return clientes;
        }

        // Método para obtener un cliente por su ID
        public Cliente ObtenerClientePorId(int id)
        {
            return clientes.FirstOrDefault(c => c.Id == id);
        }

        // Método para actualizar un cliente
        public void ActualizarCliente(Cliente clienteActualizado)
        {
            var clienteExistente = clientes.FirstOrDefault(c => c.Id == clienteActualizado.Id);
            if (clienteExistente != null)
            {
                clienteExistente.Nombre = clienteActualizado.Nombre;
                clienteExistente.Cedula = clienteActualizado.Cedula;
                clienteExistente.Telefono = clienteActualizado.Telefono;
                clienteExistente.Sexo = clienteActualizado.Sexo;
                clienteExistente.Correo = clienteActualizado.Correo;
            }
        }

        // Método para eliminar un cliente
        public void EliminarCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                clientes.Remove(cliente);
            }
        }
    }
}
