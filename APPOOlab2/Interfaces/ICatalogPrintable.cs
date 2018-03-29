using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using APPOOlab2.Interfaces;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPOOlab2
{
    public interface ICatalogPrintable
    {
         void PrintClientFields(SqlCommand cmd);
         void PrintBooksForManager(SqlCommand cmd);
     }
}
