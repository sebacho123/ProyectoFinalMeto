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
    class Doctor
    {
        Conexion cn;

        //datos
        public string ID { get; set; }
        public string Nombre { get; set; }
        public string Especialidad { get; set; }
        public string Ci { get; set; }

        public Doctor()
        {
            cn = new Conexion();
        }
        public void insertar()
        {
            cn.insertar(stringInsert());
        }


        public string stringInsert()
        {
            string insert;

            insert = "Insert into Doctor(nombre, Especialidad, CI) " +
                     "values(" + Nombre + "', '" + Especialidad + "', '" + Ci + "')";

            return insert;
        }
       
    }
}
