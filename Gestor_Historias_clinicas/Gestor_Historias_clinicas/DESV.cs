using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Historias_clinicas
{
    class DESV
    {
        Conexion cn;
        
        public string Edad { get; set; }
        public string Estatura { get; set; }
        public string PresionArterial { get; set; }
        public string GrpSanguineo { get; set; }
        public string Temperatura { get; set; }
        public string Peso { get; set; }
        public int IdConsulta { get; set; }

        public DESV()
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

            insert = "Insert into Desv(Edad, Estatura, PresionArterial, GrpSanguineo, Temperatura, Peso, IdConsulta) " +
                     "values(" + Edad + ",'" + Estatura + "', '" + PresionArterial + "', '" + GrpSanguineo + "', '" + Temperatura + "', '" + Peso + "', '" + IdConsulta +"')";

            return insert;
        }
    }
}
