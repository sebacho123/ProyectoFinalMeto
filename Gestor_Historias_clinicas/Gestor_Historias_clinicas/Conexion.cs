using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestor_Historias_clinicas
{
    class Conexion
    {
        SqlConnection connection;
        SqlCommand Command;
        SqlDataReader reader;
        SqlDataAdapter adapter;
        DataTable dt;

        public Conexion()
        {
            try
            {
                connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;
                Initial Catalog=HistoriaClinica;Integrated Security=True");
                connection.Open();
                //MessageBox.Show("conectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Conexion: " + ex.ToString());
            }
        }

        public void insertar(String datos)
        {
            try
            {
                Command = new SqlCommand(datos, connection);
                Command.ExecuteNonQuery();
                MessageBox.Show("Se inserto los datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en Conexion: " + ex.ToString());
            }
        }
        public void cargar(DataGridView dg)
        {
            try
            {
                adapter = new SqlDataAdapter("Select * from Docotor",connection);
                adapter.Fill(dt);
                dt = new DataTable();
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el datagrid: " + ex.ToString());
            }
            
        }

        public void mostrarConsultas(DataGridView dg, int Ci)
        {
            try
            {
                adapter = new SqlDataAdapter("Select * from Consulta where CiPaciente='" + Ci + "'", connection);
                dt = new DataTable();
                adapter.Fill(dt);
                
                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el datagrid: " + ex.ToString());
            }

        }
        public void mostrarOrdenes(DataGridView dg, int Ci)
        {
            try
            {
                adapter = new SqlDataAdapter("Select * from OrdenMedica where CiPaciente='" + Ci + "'", connection);
                dt = new DataTable();
                adapter.Fill(dt);

                dg.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar el datagrid: " + ex.ToString());
            }

        }
        public int buscarDoc(string doc)
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("select * from Docotor where nombre='" + doc + "'",connection);
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                id = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            return id;
           
        }

        public int retornarConsulta(int ci)
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("select * from Consulta where CiPaciente='" + ci + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            return id;
        }

        public int retornarIdConsulta()
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Consulta ORDER BY Id DESC", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                id = Convert.ToInt32(dr[0]);
            }
            dr.Close();
            return id;
        }
        public void mostrarDoctor(ComboBox cb)
        {
            cb.Items.Clear();
            SqlCommand cmd = new SqlCommand("Select * from Docotor",connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[1].ToString());
            }
            dr.Close();
        }
        public void recuperarNombrePac(TextBox cb, int ci)
        {
            
            SqlCommand cmd = new SqlCommand("Select * from Paciente where CI='" + ci + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Text=dr[1].ToString();
            }
            dr.Close();
        }

        public bool EsMujer(int ci)
        {
             bool es = false;
            SqlCommand cmd = new SqlCommand("select * from Paciente where CI='" + ci + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[3].ToString()=="F")
                {
                    es = true;
                }
            }
            dr.Close();
            return es;
        }
        public bool existe(int ci)
        {
            bool existe = false;
            SqlCommand cmd = new SqlCommand("select * from Paciente where CI='" + ci + "'", connection);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr.FieldCount!=0)
                {
                    existe = true;
                }
            }
            dr.Close();
            return existe;
        }
       


    }
}
