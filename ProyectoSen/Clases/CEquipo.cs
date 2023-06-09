using K4os.Compression.LZ4.Encoders;
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
    internal class CEquipo
    {
        public void mostrarEquipo(DataGridView tablaEquipo)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from equipo";
                tablaEquipo.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objetoConexion.establecerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaEquipo.DataSource = dt;
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No iNI se mostraron los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void guardarEquipo(TextBox dni,ComboBox equipo, TextBox marca, TextBox descripcion,Label fecha,Label hora )
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "insert into Equipo (DNI_Cliente,Tipo_d_Equipo,Marca,Descripcion_Falla,Fecha,Hora)" + "values ('" + dni.Text + "','" + equipo.Text + "','" + marca.Text + "','" + descripcion.Text + "','" + fecha.Text + "','" + hora.Text + "');";

                MySqlCommand mySqlCommand = new MySqlCommand(query, objetoConexion.establecerConexion());
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                while (reader.Read()) { }
                objetoConexion.cerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No FECHA DE MRD se guardo los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void SelecionEquipo(DataGridView tablaEquipo,TextBox Id ,TextBox Dni, ComboBox equipo, TextBox marca, TextBox descripcion ,Label fecha , Label hora)
        {
            try
            {
                Id.Text = tablaEquipo.CurrentRow.Cells[0].Value.ToString();
                Dni.Text = tablaEquipo.CurrentRow.Cells[1].Value.ToString();
                equipo.Text = tablaEquipo.CurrentRow.Cells[2].Value.ToString();
                marca.Text = tablaEquipo.CurrentRow.Cells[3].Value.ToString();
                descripcion.Text = tablaEquipo.CurrentRow.Cells[4].Value.ToString();
                fecha.Text = tablaEquipo.CurrentRow.Cells[5].Value.ToString();
                hora.Text = tablaEquipo.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noo se seleciona los datos de la base de datos, error " + ex.ToString());
            }
        }
        public void modificarEquipo(TextBox Id, TextBox Dni,ComboBox equipo, TextBox marca, TextBox descripcion ,Label fecha , Label hora)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "update equipo set DNI_Cliente ='" + Dni.Text + "',Tipo_d_Equipo='" + equipo.Text + "', Marca='" + marca.Text + "', Descripcion_Falla ='" + descripcion.Text + "', Fecha ='" + fecha.Text + "', Hora ='" + hora.Text + "' where Num_Registro= '" + Id.Text + "';";
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
        public void DeleteEquipo(TextBox Id)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "delete from equipo where Num_Registro = '" + Id.Text + "';";
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
        public void ResetEquipo()
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "TRUNCATE TABLE equipo;";
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
        public void BuscarEquipo(DataGridView tablaEquipo, TextBox nombre)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from equipo where Tipo_d_Equipo ='" + nombre.Text + "';";
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
        public void BuscarDni(DataGridView tablaEquipo ,TextBox dni)
        {
            try
            {
                CConexion objetoConexion = new CConexion();

                String query = "Select * from cliente where DNI_Cliente  ='" + dni.Text + "';";
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
