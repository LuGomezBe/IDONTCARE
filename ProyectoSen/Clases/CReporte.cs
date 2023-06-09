using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ProyectoSen.Clases
{
    internal class CReporte

    {
        public void mostrarReporte(DataGridView tablaReporte)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from Reporte";
                tablaReporte.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaReporte.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se mostraron los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void modificarReporte_T(TextBox Id,TextBox Dni_t)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update reporte set DNI_Tecnico ='" + Dni_t.Text + "' where ID_Reporte = '" + Id.Text + "';";
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
        public void guardarReporte(TextBox Dni_T, TextBox Dni_C, TextBox Marca)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "insert into Reporte (DNI_Tecnico,DNI_Cliente,Marca)" + "values ('" + Dni_T.Text + "','" + Dni_C.Text + "','" + Marca.Text + "');";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No ERROR se guardo los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void SelecionTecnico(DataGridView tablaTecnico, TextBox Id, TextBox Dni_T, TextBox Dni_C, TextBox marca)
        {
            try
            {

                Id.Text = tablaTecnico.CurrentRow.Cells[0].Value.ToString();
                Dni_T.Text = tablaTecnico.CurrentRow.Cells[1].Value.ToString();
                Dni_C.Text = tablaTecnico.CurrentRow.Cells[2].Value.ToString();
                marca.Text = tablaTecnico.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se seleciona los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void SelecionCliente(DataGridView tablaTecnico, TextBox Dni_C)
        {
            try
            {

                Dni_C.Text = tablaTecnico.CurrentRow.Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se seleciona los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void SelecionEquipo(DataGridView tablaTecnico, TextBox Marca)
        {
            try
            {

                Marca.Text = tablaTecnico.CurrentRow.Cells[2].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se seleciona los datos de la base de datos, error " + ex.ToString());
            }
        }
        /*
        public void modificarCliente(TextBox Id, TextBox nombres, TextBox apellidos, TextBox Dni, TextBox telefono)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update cliente set Nombre_Cliente='" + nombres.Text + "', Apellidos_Cliente ='" + apellidos.Text + "', DNI_Cliente ='" + Dni.Text + "', Telefono ='" + telefono.Text + "' where ID_Cliente = '" + Id.Text + "';";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se modifico los datos de la base de datos, error " + ex.ToString());
            }
        }*/
        public void DeleteCliente(TextBox Id)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "delete from Cliente where ID_cliente = '" + Id.Text + "';";
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
        public void ResetCliente()
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "TRUNCATE TABLE cliente;";
                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se Reseto los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void BuscarReporte(DataGridView tablaReporte, TextBox Dni_t)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from Reporte where DNI_Tecnico ='" + Dni_t.Text + "';";
                tablaReporte.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaReporte.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No  pueba 1 los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void SelecionarTecnicoE(DataGridView tablaEquipo, ComboBox nombre)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from tecnico where Nombre_Tecnico  ='" + nombre.Text + "';";
                tablaEquipo.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaEquipo.DataSource = dt;
                
                objetoConexion.cerrarConexion();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("No  pueba 1 los datos de la base de datos, error " + ex.ToString());
            }
        }
    }
}
