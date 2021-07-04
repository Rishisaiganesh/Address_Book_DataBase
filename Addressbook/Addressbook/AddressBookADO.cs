using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.

namespace Addressbook
{
    class AddressBookADO
    {
        //connecting string Throw dataBase
        public static string connectionString = @"Data Source=DESKTOP-77TPKFS;Initial Catalog = AddressBookService; Integrated Security = True;";

        SqlConnection Connection = new SqlConnection(connectionString);

        public void DSConnection()
        {
            try
            {
                DateTime now = DateTime.Now;
                //opening connection throw database
                Connection.Open();

                using (Connection)
                {
                    Console.WriteLine(now + " Connection is created sucessfully");

                }
                Connection.Close();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
