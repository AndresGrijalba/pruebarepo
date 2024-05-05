using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using HotelBerlin.BLL;
using HotelBerlin.Entity;

namespace HotelBerlin.GUI
{
    public partial class AgregarClienteForm : Form
    {
        private ClienteBLL clienteBLL;

        public AgregarClienteForm()
        {
            InitializeComponent();
            clienteBLL = new ClienteBLL();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            // Obtener los datos del formulario
            string nombre = txtNombre.Text;
            string cedula = txtCedula.Text;
            string telefono = txtTelefono.Text;
            string sexo = cmbSexo.SelectedItem.ToString();
            string correo = txtCorreo.Text;

            // Crear un nuevo objeto Cliente
            Cliente nuevoCliente = new Cliente(0, nombre, cedula, telefono, sexo, correo);

            // Agregar el cliente utilizando la capa BLL
            clienteBLL.AgregarCliente(nuevoCliente);

            MessageBox.Show("Cliente agregado correctamente.");

            // Limpiar los campos del formulario
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtCedula.Clear();
            txtTelefono.Clear();
            cmbSexo.SelectedIndex = -1;
            txtCorreo.Clear();
        }
    }
}

