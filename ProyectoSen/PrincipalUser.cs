using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen
{
    public partial class PrincipalUser : Form
    {
        public PrincipalUser()
        {
            InitializeComponent();
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.mostrarReporte(dgvReporte);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWithEllipse,
           int nHeightEllipse

           );
        [DllImport("user32.dll")]
        private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoTecnico = new Clases.CEquipo();
            objetoTecnico.mostrarEquipo(dgvPrincipal);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoTecnico = new Clases.CCliente();
            objetoTecnico.mostrarCliente(dgvPrincipal);
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.mostrarTecnico(dgvPrincipal);
        }

        private void btnBuscarR_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.BuscarReporte(dgvReporte, txtBuscarR);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioUsuario usuario = new InicioUsuario();
            usuario.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbBuscar.Text == "TECNICO")
            {
                Clases.CTecnico objetoReporte = new Clases.CTecnico();
                objetoReporte.BuscarTecnico(dgvPrincipal, txtBuscar);

            }

            if (cmbBuscar.Text == "CLIENTE")
            {
                Clases.CCliente objetoReporte = new Clases.CCliente();
                objetoReporte.BuscarCliente(dgvPrincipal, txtBuscar);
            }
            else
            {
                cmbBuscar.Text = "Elija una opcion";
            }
        }

        private void PrincipalUser_Load(object sender, EventArgs e)
        {
            IntPtr region = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region, true);

            IntPtr region1 = CreateRoundRectRgn(0, 0, btnBuscar.Width, btnBuscar.Height, 30, 30);
            SetWindowRgn(btnBuscar.Handle, region1, true);

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnTecnico.Width, btnTecnico.Height, 30, 30);
            SetWindowRgn(btnTecnico.Handle, region2, true);

            IntPtr region3 = CreateRoundRectRgn(0, 0, btnEquipo.Width, btnEquipo.Height, 30, 30);
            SetWindowRgn(btnEquipo.Handle, region3, true);

            IntPtr region4 = CreateRoundRectRgn(0, 0, btnCliente.Width, btnCliente.Height, 30, 30);
            SetWindowRgn(btnCliente.Handle, region4, true);

            IntPtr region5 = CreateRoundRectRgn(0, 0, btnBuscarR.Width, btnBuscarR.Height, 30, 30);
            SetWindowRgn(btnBuscarR.Handle, region5, true);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PrincipalUser_DoubleClick(object sender, EventArgs e)
        {

        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Ingrese DNI";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Ingrese DNI")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscarR_Leave(object sender, EventArgs e)
        {
            if (txtBuscarR.Text == "")
            {
                txtBuscarR.Text = "Ingrese DNI Tecnico";
                txtBuscarR.ForeColor = Color.Black;
            }
        }

        private void txtBuscarR_Enter(object sender, EventArgs e)
        {
            if (txtBuscarR.Text == "Ingrese DNI Tecnico")
            {
                txtBuscarR.Text = "";
                txtBuscarR.ForeColor = Color.Black;
            }
        }

    }
}
