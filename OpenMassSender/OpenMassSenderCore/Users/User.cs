using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenMassSenderCore.Managers;
using System.IO;
using System.Data.OleDb;
using OpenMassSenderCore.Utils;

namespace OpenMassSenderCore.Users
{
    public enum LOGIN_STATUS{SUCCESS,FAILURE};
    public class User
    {
        //<summary>asynchronus method for getting all the user's lists(receivers,jobs,senders),using lamda to notify when ready</summary>
        //<param name="username">the username</param>
        //<param name="password">the password</param>
        //<param name="onLogib">lamda for retung the status of the login once it finsihes
        public void login(string username,string password,Action<LOGIN_STATUS> onLogin)
        {
            (new Thread(() =>
            {
                //check if the userame and password maches and if so pass the user's id to the managers, next the managers 
                //will get their info from the db by using the userid e.g. select * from job where userid=$userid
                string userid="";
                //database things go here

                /*
                 *  Create the database Connection
                 */
                using (OleDbConnection connection = new OleDbConnection(DatabaseUtils.CONNECTION_STRING))
                {
                    connection.Open();
                    /*
                     * Create the command
                     */
                    string query = "select id,password from user where username=@username";
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
                                userid = reader.GetString(0);
                            }
                            else
                            {
                                //The password is not valid
                                // Estw -1 an den egine to login swsta
                                userid = "-1";
                            }
                        }
                        else
                        {
                            //Login failed
                            // Estw -1 an den egine to login swsta
                            userid = "-1";
                        }

                    }

                    connection.Close();
                }

                
                //write the user's id to a file so that the job execution service can know what user is logged in without the desktop
                //project running
                File.WriteAllText("omsloggeduser.dt", userid);
  
                //if login successfull then load the receivers and sender accounts
                ReceiversManager receiversManager = ReceiversManager.getInstance();
                receiversManager.load(userid);

                //the sender account manager
                SenderAccountsManager sendersManager = SenderAccountsManager.getInstance();
                sendersManager.load(userid);

                //the job manager,used only to see info about the jobs and add new,the executing is handled by the 
                //job executionaire service
                JobsManager jobsManager = JobsManager.getInstance();
                jobsManager.load(userid);

                onLogin(LOGIN_STATUS.SUCCESS);

                //else if login unsuccesfull
                //onLogin(LOGIN_STATUS.FAILURE);
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
                string userExistsQuery = "select * from user where username=@username";

                using(OleDbCommand cmd = new OleDbCommand(userExistsQuery,connection)){
                    cmd.Parameters.AddWithValue("@username" , username);

                    int result = (int)cmd.ExecuteScalar();

                    /*
                     *  User exists
                     *  Throw exception
                     */
                    if(result == 1){
                        connection.Close();
                        throw new UserExistsException("A user with username: "+username+" already exists");
                    }
                }


                /*
                 *  Creating the password hash using SHA256
                 */
                string hashedPassword = SecurityUtils.SHA256(password);

               

                /*  
                 *  Insert the new user in the database
                 */
                string createUserQuery = "insert into user (username,password) values(@username,@password)"

                using( OleDbCommand cmd = new OleDbCommand(createUserQuery,connection)){
                    cmd.Parameters.AddWithValue("@username",username);
                    cmd.Parameters.AddWithValue("@password",hashedPassword);

                    cmd.ExecuteNonQuery();
                }

                //Close the database Connection
                connection.Close();
            }
               
        }

        private static User instance;
        private User() { }
        public static User getInstance()
        {
            if (instance == null) instance = new User();
            return instance;
        }
    }
    
}
