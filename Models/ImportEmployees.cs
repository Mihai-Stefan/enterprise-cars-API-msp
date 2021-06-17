using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace cardata_api_v3.Models
{
    public class ImportEmployees
    {
        public static void CsvImportEmployees()
        {
            var lineNumber = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;; Integrated Security= true"))
            {
                conn.Open();
                // clear data from table:
                //var msql = "DELETE FROM ImportCSVTestDb.dbo.Products";

                //var mcmd = new SqlCommand();
                //mcmd.CommandText = msql;
                //mcmd.CommandType = System.Data.CommandType.Text;
                //mcmd.Connection = conn;
                //mcmd.ExecuteNonQuery();


                //Put your file location here:
                using (StreamReader reader = new StreamReader(@"C:\___CODE\_c_Sharp_cc_projects\a6_car_enterprise\cardata_api_v3\wwwroot\\employees1.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        if (lineNumber != 0)
                        {
                            var values = line.Split(',');

                            var sql = "INSERT INTO CarsDb.dbo.Employees (FirstName, LastName, PhoneNumber) VALUES ('" + values[1] + "','" + values[2] + "','" + values[3] + "')";

                            var cmd = new SqlCommand();
                            cmd.CommandText = sql;
                            cmd.CommandType = System.Data.CommandType.Text;
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                        }
                        lineNumber++;
                    }
                }
                conn.Close();
            }
            Console.WriteLine("Employees Import Complete");
            //Console.ReadLine();
        }
    }
}

