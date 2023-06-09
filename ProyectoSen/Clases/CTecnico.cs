using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSen.Clases
{
    internal class CTecnico
    {
        public void mostrarTecnico(DataGridView tablaTecnico)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from Tecnico";
                tablaTecnico.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaTecnico.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void guardarTecnico(TextBox nombres ,TextBox apellidos,TextBox Dni ,TextBox telefono , TextBox cargo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "insert into Tecnico (Nombre_Tecnico,Apellido_Tecnico,Dni_Tecnico,Telefono_Tecnico,Cargo)"+"values ('"+ nombres.Text+ "','"+apellidos.Text+ "','" + Dni.Text + "','" + telefono.Text + "','" + cargo.Text + "');";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se guardo los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void SelecionTecnico(DataGridView tablaTecnico,TextBox id,TextBox nombres, TextBox apellidos, TextBox Dni,TextBox telefono, TextBox cargo)
        {
            try
            {
                id.Text = tablaTecnico.CurrentRow.Cells[0].Value.ToString();
                nombres.Text = tablaTecnico.CurrentRow.Cells[1].Value.ToString();
                apellidos.Text = tablaTecnico.CurrentRow.Cells[2].Value.ToString();
                Dni.Text = tablaTecnico.CurrentRow.Cells[3].Value.ToString();
                telefono.Text = tablaTecnico.CurrentRow.Cells[4].Value.ToString();
                cargo.Text = tablaTecnico.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se seleciona los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void modificarTecnico(TextBox Id,TextBox nombres, TextBox apellidos, TextBox Dni,TextBox telefono , TextBox cargo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update Tecnico set Nombre_Tecnico='" + nombres.Text + "', Apellido_Tecnico='" + apellidos.Text + "', DNI_Tecnico ='" + Dni.Text + "', Telefono_Tecnico ='" + telefono.Text + "', Cargo ='" + cargo.Text + "' where ID_Tecnico = '" + Id.Text+"';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se modifico los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void DeleteTecnico(TextBox Id)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "delete from Tecnico where id_Tecnico = '" + Id.Text + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se elimino los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void ResetTecnico()
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "TRUNCATE TABLE tecnico;";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Reset los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void BuscarTecnico(DataGridView tablaTecnico, TextBox nombre)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from Tecnico where DNI_Tecnico ='" + nombre.Text + "';";
                tablaTecnico.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaTecnico.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No  pueba 1 los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void SelecionUnTecnico(DataGridView tablaEquipo, TextBox Dni)
        {
            try
            {

                Dni.Text = tablaEquipo.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se seleciona los datos de la base de datos, error " + ex.ToString());
            }
        }
    }
}
