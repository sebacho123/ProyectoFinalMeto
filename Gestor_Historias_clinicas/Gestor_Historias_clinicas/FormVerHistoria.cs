using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gestor_Historias_clinicas.HistoryMed;

namespace Gestor_Historias_clinicas
{
    public partial class FormVerHistoria : Form
    {
        Conexion c;
        SqlConnection connection;
        public static class CompartirCi2
        {
            public static int ci2;
        }
        public int criterioBusqueda { get; set; }
        public FormVerHistoria()
        {
            connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;
                Initial Catalog=HistoriaClinica;Integrated Security=True");
            connection.Open();
            InitializeComponent();
            c = new Conexion();
            c.mostrarConsultas(dgConsultas, CompartirCi.Ci);
            c.mostrarOrdenes(dgOrdenes, CompartirCi.Ci);
            cargarPaciente();
            cargarDesv();
            cargarAntecedentesGineco();

        }

        void cargarAntecedentesGineco()
        {
            SqlCommand comando = new SqlCommand("select * from Ginecoobstetricos where Ci='" + CompartirCi.Ci + "'", connection);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                txtFecPar.Text = reader["FechaParto"].ToString();
                txtCicloMens.Text = reader["CicloMenstrual"].ToString();
                txtUltMens.Text = reader["UltimaMenstruacion"].ToString();
                txtVidSexAc.Text = reader["IncVidaSexual"].ToString();
                txtPlanFam.Text = reader["PlanificacionFamiliar"].ToString();
                txtMeno.Text = reader["Menopausia"].ToString();
                txtGestas.Text = reader["Gestas"].ToString();
                txtPartos.Text = reader["Partos"].ToString();
                txtAbortos.Text = reader["Abortos"].ToString();
                txtCesar.Text = reader["Cesareas"].ToString();
            }
            reader.Close();
        }


        void cargarDesv()
        {
            int id = c.retornarConsulta(CompartirCi.Ci);
            SqlCommand comando = new SqlCommand("select * from Desv where IdConsulta='" + id + "'", connection);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                txtEdad.Text = reader["Edad"].ToString();
                TxtEstatura.Text = reader["Estatura"].ToString();
                txtPresArt.Text = reader["PresionArterial"].ToString();
                txtGrpSan.Text = reader["GrpSanguineo"].ToString();
                txtTemp.Text = reader["Temperatura"].ToString();
                txtPeso.Text = reader["Peso"].ToString();
            }
            reader.Close();
        }

        void cargarPaciente()
        {
            SqlCommand comando = new SqlCommand("select * from Paciente where CI='" +CompartirCi.Ci + "'", connection);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                txtNombre.Text = reader["Nombres"].ToString();
                txtApellidos.Text = reader["Apellidos"].ToString();
                txtSexo.Text = reader["Sexo"].ToString();
                txtDepartamento.Text = reader["Departamento"].ToString();
                txtProvincia.Text = reader["Provincia"].ToString();
                txtDireccion.Text = reader["Direccion"].ToString();
                txtTelefono.Text = reader["Telefono"].ToString();
                txtFechaNacimiento.Text = reader["FechaNacimiento"].ToString();
                txtNombreEmer.Text = reader["ContactoNombre"].ToString();
                txtTelfEmerg.Text = reader["ContactoTelf"].ToString();
                txtCi.Text = CompartirCi.Ci.ToString();
            }
            reader.Close();
        }

        private void FormHistoria_Load(object sender, EventArgs e)
        {
            CompartirCi2.ci2 = CompartirCi.Ci;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsulta formConsulta = new FormConsulta();
            formConsulta.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OrdenMedica ordenMedica  = new OrdenMedica();
            ordenMedica.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            c.mostrarConsultas(dgConsultas, CompartirCi.Ci);
        }

        private void btnActualizarOrden_Click(object sender, EventArgs e)
        {
            c.mostrarOrdenes(dgOrdenes, CompartirCi.Ci);
        }
    }
}
