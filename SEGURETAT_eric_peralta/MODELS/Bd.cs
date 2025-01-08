using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGURETAT_eric_peralta.MODELS
{
    internal class Bd
    {
        public static SqlConnection connexió = new SqlConnection("Server=localhost;Database=seguretat;User Id=ericp;Password=1234;");

    }
}
