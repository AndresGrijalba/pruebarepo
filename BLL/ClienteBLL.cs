using HotelBerlin.DAL;
using HotelBerlin.Entity;
using System.Collections.Generic;

namespace HotelBerlin.BLL
{
    public class ClienteBLL
    {
        private ClienteDAL clienteDAL;

        public ClienteBLL()
        {
            clienteDAL = new ClienteDAL();
        }

        // Método para agregar un cliente
        public void AgregarCliente(Cliente cliente)
        {
            clienteDAL.AgregarCliente(cliente);
        }

        // Método para obtener todos los clientes
        public List<Cliente> ObtenerTodosLosClientes()
        {
            return clienteDAL.ObtenerTodosLosClientes();
        }

        // Método para obtener un cliente por su ID
        public Cliente ObtenerClientePorId(int id)
        {
            return clienteDAL.ObtenerClientePorId(id);
        }

        // Método para actualizar un cliente
        public void ActualizarCliente(Cliente cliente)
        {
            clienteDAL.ActualizarCliente(cliente);
        }

        // Método para eliminar un cliente
        public void EliminarCliente(int id)
        {
            clienteDAL.EliminarCliente(id);
        }
    }
}


