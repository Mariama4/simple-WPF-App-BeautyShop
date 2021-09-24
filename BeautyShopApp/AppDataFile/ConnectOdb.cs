using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace BeautyShopApp.AppDataFile
{
    class ConnectOdb
    {

        public static Tuple<DataTable, bool>  Select(string selectSQL)
        {
            DataTable dataTable = new DataTable("dataBase");

            bool status = false;
            try
            {
                MySqlConnection sqlConnection = new MySqlConnection("SERVER=localhost;PORT=3306;database=dbo;uid=root;password=root;");
                
                sqlConnection.Open();
                MySqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = selectSQL;
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                status = true;
                return Tuple.Create(dataTable, status);
            }
            catch (Exception ex)
            {
                MainWindow.RaiseExectionErrorInSQL();
                return Tuple.Create(dataTable, status);
            }
        }

    }
}
