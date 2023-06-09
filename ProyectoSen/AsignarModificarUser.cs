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
    public partial class AsignarModificarUser : Form
    {
        public AsignarModificarUser()
        {
            InitializeComponent();
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void dgvReporte_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.SelecionTecnico(dgvReporte,txtId,txtTecnico,txtDni,txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.SelecionTecnico(dgvReporte, txtId, txtTecnico, txtDni, txtMarca);
            objetoReporte.mostrarReporte(dgvReporte);
        }
    }
}
