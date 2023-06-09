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
    public partial class AsignarRe : Form
    {
        public AsignarRe()
        {
            InitializeComponent();
        }

        private void cmbTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTecnico.SelectedIndex == 0)
            {
                txtTecnico.Text = "94241241";
            }
            if (cmbTecnico.SelectedIndex == 0)
            {
                txtTecnico.Text = "70821478";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.guardarReporte(txtTecnico, txtDni, txtMarca);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin admin = new InicioAdmin();
            admin.ShowDialog();
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "Ingrese DNI cliente";
                txtDni.ForeColor = Color.Black;
            }
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "Ingrese DNI cliente")
            {
                txtDni.Text = "";
                txtDni.ForeColor = Color.Black;
            }
        }

        private void cmbTecnico_Leave(object sender, EventArgs e)
        {
            if (cmbTecnico.Text == "")
            {
                cmbTecnico.Text = "Elija una opcion";
                cmbTecnico.ForeColor = Color.Black;
            }
        }

        private void cmbTecnico_Enter(object sender, EventArgs e)
        {
            if (cmbTecnico.Text == "Elija una opcion")
            {
                cmbTecnico.Text = "";
                cmbTecnico.ForeColor = Color.Black;
            }
        }

        private void txtMarca_Leave(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                txtMarca.Text = "Ingrese la Marca";
                txtMarca.ForeColor = Color.Black;
            }
        }

        private void txtMarca_Enter(object sender, EventArgs e)
        {
            if (txtMarca.Text == "Ingrese la Marca")
            {
                txtMarca.Text = "";
                txtMarca.ForeColor = Color.Black;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            AsignarModificar admin = new AsignarModificar();
            admin.ShowDialog();
        }
    }
}
