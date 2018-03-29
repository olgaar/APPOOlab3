using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APPOOlab2.Interfaces;
using System.Data.SqlClient;

namespace APPOOlab2
{
    public class CatalogFilePrinter : ICatalogPrintable
    {
        public void PrintClientFields(SqlCommand cmd)
        {
            
            // Create new SqlDataReader object and read data from the command.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // while there is another record present
                while (reader.Read())
                {
                    // write the data on to the screen
                    System.IO.File.WriteAllText(@"C:\samples\Catalog.txt", (String.Format("{0} \t | {1} \t | {2} ",
                    // call the objects from their index
                    reader[0], reader[1], reader[2])));
                }
            }
        }
        public void PrintBooksForManager(SqlCommand cmd)
        {
           
            // Create new SqlDataReader object and read data from the command.
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                // while there is another record present
                while (reader.Read())
                {
                    // write the data on to the screen
                    System.IO.File.WriteAllText(@"C:\samples\Catalog.txt", (String.Format("{0} \t | {1} \t | {2} \t | {3}",
                    // call the objects from their index
                    reader[0], reader[1], reader[2], reader[3])));
                }
            }
        }

    }
}
