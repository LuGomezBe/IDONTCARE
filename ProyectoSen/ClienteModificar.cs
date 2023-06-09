using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class ClienteModificar : Form
    {
        public ClienteModificar()
        {
            InitializeComponent();
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.modificarCliente(txtId, txtNombre, txtApellido, txtDni, txtTelefono);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.DeleteCliente(txtId);
            objetoCliente.mostrarCliente(dgvCliente);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente admin = new Cliente();
            admin.ShowDialog();
        }

        private void dgvCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CCliente objetoCliente = new Clases.CCliente();
            objetoCliente.SelecionCliente(dgvCliente, txtId, txtNombre, txtApellido, txtDni, txtTelefono);
        }

    }
}
