using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
namespace Gestor_Historias_clinicas
{
    class Consulta
    {
        Conexion cn;

        public int NroSala { get; set; }
        public string Doctor { get; set; }
        public string Fecha { get; set; }
        public string ProxCita { get; set; }
        public string Sintomas { get; set; }
        public string DiagPrelim { get; set; }
        public string Hospital { get; set; }
        public int CiPac { get; set; }
        public int IdDoc { get; set; }

        public Consulta()
        {
            cn = new Conexion();
        }

        public void insertar()
        {
            cn.insertar(stringInsert());
        }

        public int buscarDoc(string doc)
        {
            return cn.buscarDoc(doc);
        }

        public int retornarIdConsulta()
        {
            return cn.retornarIdConsulta();
        }

        public string stringInsert()
        {
            string insert;

            insert = "Insert into Consulta(NumeroSala, Doctor, Fecha, ProximaCita, Sintomas, DiacnosticoPreliminar, Hospital , CiPaciente, IdDoctor) " +
                     "values(" + NroSala + ",'" + Doctor + "', '"+Fecha+ "', '" + ProxCita + "', '" + Sintomas + "', '" + DiagPrelim + "', '" + Hospital + "', '" +CiPac+ "', '" + IdDoc + "')";

            return insert;
        }
        public bool EsMujer(int ci)
        {
            return cn.EsMujer(ci);
        }

    }
}
