using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SeaBattleDB
{
    
    class DataOperational
    {
        DataAccess dataBase;
        public DataOperational(DataAccess dataBase)
        {
            this.dataBase = dataBase;
        }

        public string GetUserData(int ID)
        {
            //int count;
            string userData = null;
            DateTime date = new DateTime(2000, 1, 1);
            string opponent = null;
            bool result;
            string resultString = null;
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = dataBase.connection;
                
                SqlParameter id = new SqlParameter("@ID", System.Data.SqlDbType.Int);;
                id.Value = ID;
                command.Parameters.Add(id);
                command.CommandText = "SELECT * FROM UserStatistics WHERE UserID = @ID";

                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        //count = dataReader.GetInt32(2);
                        date = dataReader.GetDateTime(2);
                        opponent = dataReader.GetString(3);
                        result = dataReader.GetBoolean(4);
                        if (result == true)
                        {
                            resultString = "Win";
                        }
                        else
                        {
                            resultString = "Defeat";
                        }
                    }
                }
            }
            userData = "Date: " + date.ToString("MMMM dd, yyyy") + "\nOpponent: " + opponent + "\nResult: " + resultString;
            return userData;
        }
    }
}
