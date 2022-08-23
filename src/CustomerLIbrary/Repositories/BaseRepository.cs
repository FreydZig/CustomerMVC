using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLIbrary.Repositories
{
    public class BaseRepository
    {
        public SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CustomerLib_Demin;Integrated Security=True");
        }
    }
}
