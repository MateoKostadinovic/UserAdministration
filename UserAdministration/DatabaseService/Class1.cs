using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DatabaseService
{
    public class Crud
    {      
        public List<User> GetUsers()
        {
            List<User> lUsers = new List<User>();
            string sSqlConnectionString = ConfigurationManager.AppSettings["ConnectionString"];//Popunjavanje liste iz baze
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT * FROM users";//Komanda za odabir tablice users
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    while (oReader.Read())
                    {
                        lUsers.Add(new User()
                        {
                            nUserID = (int)oReader["USER_ID"],
                            sUserName = (string)oReader["USERNAME"],
                            sUserPassword = (string)oReader["PASSWORD"],
                            sUserFirstName = (string)oReader["NAME"],
                            sUserLastName = (string)oReader["SURNAME"]
                        });
                    }
                }
            }
            return lUsers;//vraca listu lUsers iz databaze
        }

        public void UpdateUser(User oUser)
        {
            Trace.WriteLine(oUser.sUserFirstName);
            string sSqlConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())//nakon ove funkcije memorija se oslobada zbog using
            {
                Trace.WriteLine("UPDATE USERS SET NAME = '" + oUser.sUserFirstName + "', SURNAME = '" + oUser.sUserLastName + "', PASSWORD = '" + oUser.sUserPassword + "'WHERE USER_ID = " + oUser.nUserID);
                oCommand.CommandText = "UPDATE USERS SET NAME = '" + oUser.sUserFirstName +"', SURNAME = '" + oUser.sUserLastName + "', PASSWORD = '" + oUser.sUserPassword + "'WHERE USER_ID = "+oUser.nUserID;
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }

        public void DeleteUser(int nId)
        {
            string sSqlConnectionString = ConfigurationManager.AppSettings["ConnectionString"];
            using (DbConnection oConnection = new SqlConnection(sSqlConnectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())//nakon ove funkcije memorija se oslobada zbog using
            {
                oCommand.CommandText = "DELETE FROM users WHERE USER_ID = '" + nId + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {

                }
            }
        }
    }
}
