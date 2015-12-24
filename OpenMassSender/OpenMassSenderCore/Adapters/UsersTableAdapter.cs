using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Data.OleDb;
using OpenMassSenderCore.Utils;
using System.Windows.Forms;

namespace OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters
{
    //<summary>Singleton that contains all the receivers</summary>

        partial class UserTableAdapter
        {
            public string userid=null;
            //<summary>asynchronus method for getting all the user's lists(receivers,jobs,senders),using lamda to notify when ready</summary>
            //<param name="username">the username</param>
            //<param name="password">the password</param>
            //<param name="onLogib">lamda for retung the status of the login once it finsihes
            public void login(string username,string password,Action<LOGIN_STATUS,string> onLogin)
            {
                
                (new Thread(() =>
                {
                    //check if the userame and password maches and if so pass the user's id to the managers, next the managers 
                    //will get their info from the db by using the userid e.g. select * from job where userid=$userid
                    //database things go here

                    /*
                     *  Create the database Connection
                     */
                    try
                    {
                        using (OleDbConnection connection = new OleDbConnection(DatabaseUtils.CONNECTION_STRING))
                        {
                            connection.Open();
                            /*
                             * Create the command
                             */
                            string query = "select `id`,`password` from `user` where username=@username";
                            using (OleDbCommand cmd = new OleDbCommand(query, connection))
                            {
                                cmd.Parameters.AddWithValue("@username", username);

                                OleDbDataReader reader = cmd.ExecuteReader();

                                if (reader.Read())
                                {
                                    string realPasswordHash = reader.GetString(1);

                                    //Check if the password is valid
                                    if (SecurityUtils.SHA256(password).Equals(realPasswordHash))
                                    {
                                        //The password is valid, store the users id
                                        userid = Convert.ToString(reader.GetValue(0));
                                        onLogin(LOGIN_STATUS.SUCCESS, userid);
                                    }
                                    else
                                    {
                                        //The password is not valid
                                        //Login has faild , userid is null
                                        userid = null;
                                        onLogin(LOGIN_STATUS.FAILURE, userid);
                                    }
                                }
                                else
                                {
                                    //Login failed
                                    //Login has faild , userid is null
                                    userid = null;
                                    Console.WriteLine("fail 2");
                                }

                            }

                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Logger.error("error: " + ex.Message);
                        onLogin(LOGIN_STATUS.FAILURE, userid);
                    }
                })).Start();
            }


            /*
             *  Creates a new user.
             */
            public void createUser(string username, string password)
            {
                /*
                 *  TO DO
                 *  check if username and password strings are valid
                 */

                /*
                 *  Open a connection to the dataabase
                 */
                using (OleDbConnection connection = new OleDbConnection(DatabaseUtils.CONNECTION_STRING))
                {

                    //Open the database connection
                    connection.Open();

                    /*
                     *  Checking if a user exists
                     */
                    string userExistsQuery = "select * from `user` where username=@username";

                    using(OleDbCommand cmd = new OleDbCommand(userExistsQuery,connection)){
                       

                        

                        cmd.Parameters.AddWithValue("@username", username);
                        
                        OleDbDataReader reader = cmd.ExecuteReader();

                        /*
                         *  User exists
                         *  Throw exception
                         */
                        if (reader.Read())
                        {
                            throw new UserExistsException("A user with username: "+username+" already exists");
                        }
                      
                        
                    }
                    connection.Close();
                }

                using (OleDbConnection connection = new OleDbConnection(DatabaseUtils.CONNECTION_STRING))
                {
                    connection.Open();
                    /*
                     *  Creating the password hash using SHA256
                     */
                    string hashedPassword = SecurityUtils.SHA256(password);



                    /*  
                     *  Insert the new user in the database
                     */
                    string createUserQuery = "insert into `user` (`username`,`password`) values(@username,@password)";

                    using (OleDbCommand cmd = new OleDbCommand(createUserQuery, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        cmd.ExecuteNonQuery();
                        
                    }
                    connection.Close();
                }
                   
            }

            public OpenMassSenderCore.OpenMassSenderDBDataSet.UserDataTable dataTable = new OpenMassSenderCore.OpenMassSenderDBDataSet.UserDataTable();
            public OpenMassSenderCore.OpenMassSenderDBDataSet.UserRow getNewRow()
            {
                return dataTable.NewUserRow();
            }
            public void submitRow(OpenMassSenderCore.OpenMassSenderDBDataSet.UserRow row)
            {
                dataTable.Rows.Add(row);
                Update(dataTable);
            }

            private static UserTableAdapter instance;
            public static UserTableAdapter getInstance()
            {
                if (instance == null) instance = new UserTableAdapter();
                return instance;
            }
        }

        public enum LOGIN_STATUS { SUCCESS, FAILURE };

        public class UserExistsException : Exception
        {
            public UserExistsException()
            {
            }

            public UserExistsException(string message): base(message)
            {

            }

            public UserExistsException(string message, Exception inner)
                : base(message, inner)
            {
            }
        }
}




