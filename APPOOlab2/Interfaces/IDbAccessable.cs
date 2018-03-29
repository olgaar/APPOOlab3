using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2.Interfaces
{
    public interface IDbAccessable
    {
        SqlConnection OpenConnection();
        SqlCommand ExecuteQuery(String query, SqlConnection conn);
        List<Book> ReturnBooks(SqlCommand cmd);
        void CloseConnection(SqlConnection conn);


    }
}
