using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gestor_Historias_clinicas.FormVerHistoria;

namespace Gestor_Historias_clinicas
{
    public partial class OrdenMedica : Form
    {
        public int ciPaciente;
        MedicaOrden medicOrd;
        Conexion con;
        public string rp { get; set; }
        public string fecha { get; set; }
        public OrdenMedica()
        {
            InitializeComponent();
            con = new Conexion();
            ciPaciente = CompartirCi2.ci2;
            con.recuperarNombrePac(tbxPac, ciPaciente);
            con.mostrarDoctor(cmbDoc);
            medicOrd = new MedicaOrden();
            ciPaciente = CompartirCi2.ci2;
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            medicOrd.CiPac = ciPaciente;
            medicOrd.IdDoc = medicOrd.buscarDoc(cmbDoc.SelectedItem.ToString());
            medicOrd.RP = txtRP.Text;
            medicOrd.Fecha = tbxFecha.Text;
            medicOrd.insertar();
        }
    }
}
