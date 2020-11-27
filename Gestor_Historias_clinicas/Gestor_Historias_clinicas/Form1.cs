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
    public partial class HistoryMed : Form
    {
        Paciente paciente;

        public static class CompartirCi
        {
            public static int Ci;
        }
            

        public HistoryMed()
        {
            InitializeComponent();
            //Conexion conex = new Conexion();
            paciente = new Paciente();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Close();
            //hola luis
            if (paciente.existe(Convert.ToInt32(tBxInicioCI.Text)))
            {
                CompartirCi.Ci = Convert.ToInt32(tBxInicioCI.Text);
                FormVerHistoria formVerHistoria = new FormVerHistoria();
                formVerHistoria.criterioBusqueda = Convert.ToInt32(tBxInicioCI.Text);
                formVerHistoria.ShowDialog();
            }
            else
            {
                MessageBox.Show("El Paciente no se encuentra registrado, Porfavor ingresar Nuevamente");
            }
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNuevaHistoria formNuevaHistoria = new FormNuevaHistoria();
            formNuevaHistoria.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
