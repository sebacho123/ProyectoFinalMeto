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
    
    class Paciente
    {

        Conexion cn;

        #region datos
        public int CI { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Departamento { get; set; }
        public string Provincia { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string FechaNacimiento { get; set; }
        public string ContactoNombre { get; set; }
        public string ContactoTelf { get; set; }
        #endregion

        public Paciente()
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

            insert = "Insert into Paciente(CI, Nombres, Apellidos, Sexo, Departamento, Provincia, Direccion , Telefono, FechaNacimiento, ContactoNombre, ContactoTelf) " + 
                     "values(" + CI + ",'" + Nombres + "', '" + Apellidos + "', '" + Sexo + "', '" + Departamento + "', '" + Provincia + "', '"+Direccion+"', '" + Telefono + "', '" + FechaNacimiento+"', '"+ContactoNombre + "', '" + ContactoTelf + "')";

            return insert;
        }

        public bool existe(int ci)
        {
           return cn.existe(ci);
        }
    }
}
