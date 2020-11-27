using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Historias_clinicas
{
    class MedicaOrden
    {
        Conexion cn;
        public string RP { get; set; }
        public string Fecha { get; set; }
        public int CiPac { get; set; }
        public int IdDoc { get; set; }

        public MedicaOrden()
        {
            cn = new Conexion();
        }
        public string stringInsert()
        {
            string insert;

            insert = "Insert into OrdenMedica(RP, Fecha, IdDoctor,  CiPaciente) " +
                     "values('" + RP + "','" + Fecha + "', '" + IdDoc + "', '" + CiPac + "')";

            return insert;
        }

        public void insertar()
        {
            cn.insertar(stringInsert());
        }

        public int buscarDoc(string doc)
        {
            return cn.buscarDoc(doc);
        }
    }
}
