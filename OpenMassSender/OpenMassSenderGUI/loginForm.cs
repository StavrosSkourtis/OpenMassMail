using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using System.Text.RegularExpressions;
using OpenMassSenderCore;

namespace OpenMassSenderGUI
{
    public partial class LoginForm : Form
    {
        bool loggingIn = false;
        Action<string,string,string> callBackListener;
        public LoginForm(Action<string, string, string> callBackListener)
        {
            this.callBackListener = callBackListener;
            InitializeComponent();
            btnCreateAccount.Visible = false;
            btnCreateAccount.Enabled = false;

            TextBox.CheckForIllegalCrossThreadCalls = false;
            Label.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           // callBackListener("testname", "testpassword", "1");
            //this.Close();
            if (txtPassword.Text.Equals("") || txtUsername.Text.Equals(""))
            {
                lblNotice.Text = "You need to fill all the fields";
                return;
            }
            UserTableAdapter.getInstance().login(txtUsername.Text, txtPassword.Text, (status,userid) =>
            {
                if (callBackListener != null && status == LOGIN_STATUS.SUCCESS)
                {
                    loggingIn = true;
                    Logger.log("user " + txtUsername.Text + " logged in successful");
                    callBackListener(txtUsername.Text, txtPassword.Text, userid);
                }
                else
                {
                    Logger.log("error durring singin, wrong credentials?");
                    lblNotice.Text = "Something went wrong during login(wrong password?)";
                }      
            });
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("") || txtUsername.Text.Equals(""))
            {
                lblNotice.Text = "You need to fill all the fields";
                return;
            }
            try
            {
                UserTableAdapter.getInstance().createUser(txtUsername.Text, txtPassword.Text);
                UserTableAdapter.getInstance().login(txtUsername.Text, txtPassword.Text, (status,userid) =>
                {
                    if (callBackListener != null && status == LOGIN_STATUS.SUCCESS)
                    {
                        loggingIn = true;
                        Logger.log("user " + txtUsername.Text + " logged in successful");
                        callBackListener(txtUsername.Text, txtPassword.Text, userid);
                    }
                    else
                    {
                        Logger.log("error durring singin, wrong credentials?");
                        lblNotice.Text = "Something went wrong during login";
                    }
                });
            }
            catch (UserExistsException ex)
            {
                Logger.log(ex.Message);
                lblNotice.Text = "Username already exists";
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lblRegister.Text.Equals ("Don't have an account?")){
                lblRegister.Text="Already have an account?";
                this.Name = "Register";
            }else{
                lblRegister.Text="Don't have an account?";
                this.Name = "Loggin";
            }
           
            btnLogin.Visible = !btnLogin.Visible;
            btnLogin.Enabled = !btnLogin.Enabled;
            btnCreateAccount.Visible = !btnCreateAccount.Visible;
            btnCreateAccount.Enabled = !btnCreateAccount.Enabled;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("omsloggeduser.dt"))
            {
                String[] user=File.ReadAllText("omsloggeduser.dt").Split('|');
                txtUsername.Text = user[0];
                txtPassword.Text = user[1];
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loggingIn == false)
            {
                Environment.Exit(Environment.ExitCode);
            }


        }
    }
}
