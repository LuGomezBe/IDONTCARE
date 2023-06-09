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
    public partial class Tecnico : Form
    {
        public Tecnico()
        {
            InitializeComponent();
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.DeleteTecnico(txtId);
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.modificarTecnico(txtId, txtNombre, txtApellido, txtDni, txtTelefono, txtCargo);
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.guardarTecnico(txtNombre, txtApellido, txtDni, txtTelefono, txtCargo);
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.ResetTecnico();
            objetoTecnico.mostrarTecnico(dgvTecnico);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin formularioP = new InicioAdmin();
            formularioP.ShowDialog();
        }
    }
}
