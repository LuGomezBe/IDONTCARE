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
    public partial class EquipoModificar : Form
    {
        public EquipoModificar()
        {
            InitializeComponent();
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            EquipoUser user = new EquipoUser();
            user.ShowDialog();
        }

        private void dgvEquipo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.SelecionEquipo(dgvEquipo, txtId, txtDni ,cmbTipoE,txtMarca,txtDescripcion,lblFecha,lblHora);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.modificarEquipo(txtId, txtDni, cmbTipoE, txtMarca, txtDescripcion, lblFecha, lblHora);
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoEquipo = new Clases.CEquipo();
            objetoEquipo.DeleteEquipo(txtId);
            objetoEquipo.mostrarEquipo(dgvEquipo);
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
