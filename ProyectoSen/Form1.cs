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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.guardarTecnico(txtNombre, txtApellido, txtDni,txtTelefono,txtCargo);
            objetoTecnico.mostrarTecnico(dgvTecnico);

        }

        private void dgvTecnico_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.SelecionTecnico(dgvTecnico, txtId, txtNombre, txtApellido, txtDni, txtTelefono, txtCargo);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.modificarTecnico(txtId,txtNombre, txtApellido, txtDni ,txtTelefono , txtCargo);
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.DeleteTecnico(txtId);
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin formularioP = new InicioAdmin();
            formularioP.ShowDialog();
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.ResetTecnico();
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }


        private void dgvTecnico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
