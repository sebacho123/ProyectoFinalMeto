using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Gestor_Historias_clinicas
{
    class Ginecoobstetricos
    {
        Conexion cn;

        #region datos
        public string FechaParto { get; set; }
        public string CicloMenstrual { get; set; }
        public string UltimaMenstruacion { get; set; }
        public string IncVidaSexual { get; set; }
        public string PlanificacionFamiliar { get; set; }
        public string Menopausia { get; set; }
        public string Gestas { get; set; }
        public string Partos { get; set; }
        public string Abortos { get; set; }
        public string Cesareas { get; set; }
        public int CI { get; set; }
        #endregion

        public Ginecoobstetricos()
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

            insert = "Insert into Ginecoobstetricos(FechaParto, CicloMenstrual, UltimaMenstruacion, IncVidaSexual, PlanificacionFamiliar, Menopausia, Gestas , Partos, Abortos,Cesareas,Ci) " +
                     "values(" + FechaParto + ",'" + CicloMenstrual + "', '" + UltimaMenstruacion + "', '" + IncVidaSexual + "', '" + PlanificacionFamiliar + "', '" + Menopausia + "', '" + Gestas + "', '" + Partos + "', '" + Abortos + "','" + Cesareas + "','" + CI + "')";

            return insert;
        }



    }
}
