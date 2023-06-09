
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
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
            //-----------------------------------------------------------------------------------------
            //----            ---          ---            ------        -------------------------------
            //----   ------------   ----------   ------   -----    ----   -----------------------------
            //----   ------------   ----------   ------   ----    ------   ----------------------------
            //----   ------------          ---   ------   ----   --------   ---------------------------
            //----   --       ---   ----------        --------   --------   ---------------------------
            //----   -----    ---   ----------   ---   -------    ------   ----------------------------
            //----   -----    ---   ----------   -----   ------    ----   -----------------------------
            //----            ---          ---   -------    ----        -------------------------------
            //-----------------------------------------------------------------------------------------
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



        private void btnCliente_Click(object sender, EventArgs e)
        {
            Clases.CCliente objetoTecnico = new Clases.CCliente();
            objetoTecnico.mostrarCliente(dgvPrincipal);
        }

        private void btnEquipo_Click(object sender, EventArgs e)
        {
            Clases.CEquipo objetoTecnico = new Clases.CEquipo();
            objetoTecnico.mostrarEquipo(dgvPrincipal);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbBuscar.Text == "TECNICO")
            {
                Clases.CTecnico objetoReporte = new Clases.CTecnico();
                objetoReporte.BuscarTecnico(dgvPrincipal,txtBuscar);
                
            }
            
            if(cmbBuscar.Text == "CLIENTE")
            {
                Clases.CCliente objetoReporte = new Clases.CCliente();
                objetoReporte.BuscarCliente(dgvPrincipal, txtBuscar);
            }
            else
            {
                cmbBuscar.Text = "Elija una opcion";
            }
        }

        private void btnBuscarR_Click(object sender, EventArgs e)
        {
            Clases.CReporte objetoReporte = new Clases.CReporte();
            objetoReporte.BuscarReporte(dgvReporte,txtBuscarR);
        }


        private void Principal_Load(object sender, EventArgs e)
        {

            /*IntPtr region = CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 30, 30);
            SetWindowRgn(panel1.Handle, region, true);*/

            IntPtr region1 = CreateRoundRectRgn(0, 0, btnTecnico.Width, btnTecnico.Height, 30, 30);
            SetWindowRgn(btnTecnico.Handle, region1, true);

            IntPtr region2 = CreateRoundRectRgn(0, 0, btnEquipo.Width, btnEquipo.Height, 30, 30);
            SetWindowRgn(btnEquipo.Handle, region2, true);

            IntPtr region3 = CreateRoundRectRgn(0, 0, btnCliente.Width, btnCliente.Height, 30, 30);
            SetWindowRgn(btnCliente.Handle, region3, true);

            IntPtr region4 = CreateRoundRectRgn(0, 0, btnBuscarR.Width, btnBuscarR.Height, 30, 30);
            SetWindowRgn(btnBuscarR.Handle, region4, true);

            /*IntPtr region5 = CreateRoundRectRgn(0, 0, btnVolver.Width, btnVolver.Height, 30, 30);
            SetWindowRgn(btnVolver.Handle, region5, true);*/





        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
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
            if(txtBuscar.Text == "Ingrese DNI")
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

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            InicioAdmin admin = new InicioAdmin();
            admin.ShowDialog();
        }

        private void btnTecnico_Click(object sender, EventArgs e)
        {
            Clases.CTecnico objetoTecnico = new Clases.CTecnico();
            objetoTecnico.mostrarTecnico(dgvPrincipal);
        }





        //if nombre == juan que muestre todo sus actividades
        // que guarde en ambas partes 
    }
}
