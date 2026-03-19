using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace KutuphaneWinForm;
internal class DbConnection
{
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(
            "Data Source=AKINCENGIZ;Initial Catalog=KutuphaneDb;Integrated Security=True;");
    }
}
