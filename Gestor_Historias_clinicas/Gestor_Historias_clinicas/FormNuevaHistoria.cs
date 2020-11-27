using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_Historias_clinicas
{
    public partial class FormNuevaHistoria : Form
    {
        Paciente p;


        public FormNuevaHistoria()
        {
            InitializeComponent();
            p = new Paciente();
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void FormNuevaHistoria_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            values_datos_personales();
            
        }


        private void values_datos_personales()
        {
            p.CI = Convert.ToInt32(textBoxCI.Text);
            p.Nombres = textBoxNombre.Text;
            p.Apellidos = textBoxApellidos.Text;
            p.Sexo = textBoxSexo.Text;
            p.Departamento = textBoxDepartamento.Text;
            p.Provincia = textBoxProvincia.Text;
            p.Direccion = textBoxDireccion.Text;
            p.Telefono = textBoxTelefono.Text;
            p.FechaNacimiento = textBoxFechaNacimiento.Text;
            p.ContactoNombre = textBoxContactoNombre.Text;
            p.ContactoTelf = textBoxContactoTelf.Text;
            p.insertar();
        }


    }
}
