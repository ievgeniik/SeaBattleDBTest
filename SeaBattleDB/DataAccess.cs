using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattleDB
{
    public class DataAccess
    {
        public int UserID
        {
            private set;
            get;
        }
        SqlConnectionStringBuilder stringBuilder;
        public SqlConnection connection
        {
            private set;
            get;
        }

        public void setupConnection()
        {
            stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = @"10.70.63.190\SQLEXPRESS";
            stringBuilder.IntegratedSecurity = false;
            stringBuilder.InitialCatalog = "SeaBattleTest";
            stringBuilder.UserID = "sa";
            stringBuilder.Password = "Q1w2e3r4";
            connection = new SqlConnection(stringBuilder.ToString());
            
        }


        public bool Login(string userName, string userPassword)
        {
            connection.Open();
            using (SqlCommand command = new SqlCommand())
            {
                //int UserID = 0;
                command.Connection = connection;

                SqlParameter nameParam = new SqlParameter("@Name", System.Data.SqlDbType.NVarChar);
                SqlParameter passwordParam = new SqlParameter("@Password", System.Data.SqlDbType.NVarChar);
                nameParam.Value = userName;
                passwordParam.Value = userPassword;
                command.Parameters.Add(nameParam);
                command.Parameters.Add(passwordParam);
                command.CommandText = "SELECT * FROM Users WHERE UserName = @Name AND UserPassword = @Password";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        UserID = dataReader.GetInt32(0);
                        return true;
                    }
                }
                return false;
            }
        }



    }
}
