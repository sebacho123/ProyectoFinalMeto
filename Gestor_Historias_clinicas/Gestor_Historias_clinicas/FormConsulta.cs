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
    public partial class FormConsulta : Form
    {
        public int ciPaciente;
        Consulta consul;
        DESV desv;
        Ginecoobstetricos ginecoobstetricos;
        Conexion con = new Conexion();
        public static class CompartirIdConsulta
        {
            public static int idCon;
        }
        public FormConsulta()
        {
            InitializeComponent();
            con.mostrarDoctor(cmbDoctor);
            consul = new Consulta();
            desv = new DESV();
            ginecoobstetricos = new Ginecoobstetricos();
            ciPaciente = CompartirCi2.ci2;
            if (consul.EsMujer(ciPaciente))
            {
                grpGineco.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            consul.NroSala = Convert.ToInt32(txtNroSala.Text);
            consul.Doctor = cmbDoctor.SelectedItem.ToString();
            consul.Fecha = txtFecha.Text;
            consul.ProxCita = txtPCita.Text;
            consul.Sintomas = txtSintomas.Text;
            consul.DiagPrelim = txtDiag.Text;
            consul.Hospital = txtHospital.Text;
            consul.CiPac = ciPaciente;
            consul.IdDoc = consul.buscarDoc(cmbDoctor.SelectedItem.ToString());
            consul.insertar();

            desv.Edad = txtEdad.Text;
            desv.Estatura = txtEstatura.Text;
            desv.PresionArterial = txtPresArterial.Text;
            desv.GrpSanguineo = txtGrpSan.Text;
            desv.Temperatura = txtTemperatura.Text;
            desv.Peso = txtPeso.Text;
            desv.IdConsulta = consul.retornarIdConsulta();
            desv.insertar();

            if (consul.EsMujer(ciPaciente))
            {
                ginecoobstetricos.FechaParto = txtFechaParto.Text;
                ginecoobstetricos.CicloMenstrual = txtCicloMens.Text;
                ginecoobstetricos.UltimaMenstruacion = txtUltAct.Text;
                ginecoobstetricos.IncVidaSexual = txtVSA.Text;
                ginecoobstetricos.PlanificacionFamiliar = txtPlanFam.Text;
                ginecoobstetricos.Menopausia = txtMeno.Text;
                ginecoobstetricos.Gestas = txtGestas.Text;
                ginecoobstetricos.Partos = txtPartos.Text;
                ginecoobstetricos.Abortos = txtAbortos.Text;
                ginecoobstetricos.Cesareas = txtCesarea.Text;
                ginecoobstetricos.CI = ciPaciente;
                ginecoobstetricos.insertar();
            }          
        }

        private void cmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
           // txtFecha.Text= cmbDoctor.SelectedItem.ToString();
           //txtPCita.Text=consul.buscarDoc(cmbDoctor.SelectedItem.ToString()).ToString();
        }
    }
}
