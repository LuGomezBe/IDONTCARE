using MySqlConnector;
using ProyectoSen.Clases;
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
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }
        //desde aqui
        //call the function dll
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
//hata aqui copiar


        private void btnTareas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal principal = new Principal();
            principal.ShowDialog();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRegistrarT_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tecnico tecnico= new Tecnico();
            tecnico.ShowDialog();
        }

        private void btnRegistrarC_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cliente cliente = new Cliente();
            cliente.ShowDialog();
        }

        private void btnRegistrarE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Equipo equipo= new Equipo();
            equipo.ShowDialog();
        }

        private void InicioAdmin_Load(object sender, EventArgs e)
        {
            //this is for login load
           
            panel1.Anchor = AnchorStyles.None;
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0,
            panel1.Width, panel1.Height, 30, 30));
           // btnRegistrarC.Region = Region.FromHrgn(CreateRoundRectRgn(0,0,btnRegistrarC.Width, btnRegistrarC.Height,30,30));
            IntPtr region = CreateRoundRectRgn(0, 0, btnCSesion.Width, btnCSesion.Height, 30, 30);
            SetWindowRgn(btnCSesion.Handle, region, true);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCSesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login equipo = new Login();
            equipo.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /*private void btnUsuario_Click(object sender, EventArgs e)
        {
            string usuario;
            usuario = txtUsuario.Text;

            CConexion objetoConexion = new CConexion();

            String query = "Select * from login where Usuario ='" + usuario + "';";

            MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
            MySqlDataReader reader = mySqlCommand.ExecuteReader();
            
                if (usuario == "ADMIN@PERUSIS.COM")
                {
                    txtUsuario.Text = usuario;
                }
                else
                {

                    MessageBox.Show("Error " + usuario);

                }

            
           
            objetoConexion.cerrarConexion();
        }*/
    }
}
