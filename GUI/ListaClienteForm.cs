using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HotelBerlin.BLL;
using HotelBerlin.Entity;

namespace HotelBerlin.GUI
{
    public partial class ListaClientesForm : Form
    {
        private ClienteBLL clienteBLL;

        public ListaClientesForm()
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
            CargarClientes();
        }

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteBLL.ObtenerTodosLosClientes();

            dgvClientes.Rows.Clear();

            foreach (Cliente cliente in clientes)
            {
                dgvClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Cedula, cliente.Telefono, cliente.Sexo, cliente.Correo);
            }
        }
    }
}
