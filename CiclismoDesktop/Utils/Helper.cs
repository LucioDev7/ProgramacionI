using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiclismoDesktopPorCodigo.Utils
{
    public class Helper
    {
        public static SqlConnection CrearConexion ()
        {
            string connectionString = "Server=.\\SQLEXPRESS; database=Ciclismo2; user id=sa; password=123; multipleactiveresultsets=true; Encrypt=false";
            SqlConnection conex = new SqlConnection(connectionString);
            conex.Open();
            return conex;
        }
    }
}

//Scaffold-DbContext "server=.\SQLEXPRESS; database=argentina; user id=sa; password=123; multipleactiveresultsets=true; Encrypt=false" Microsoft.EntityFrameworkCore.SqlServer - OutputDir ModelsArg - Context argentinaContext - ContextDir DataContext - DataAnnotations
