using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore.Users;
using System.IO;

namespace OpenMassSenderGUI
{
    public partial class loginForm : Form
    {
        Action callBackListener;
        public loginForm(Action callBackListener)
        {
            this.callBackListener = callBackListener;
            InitializeComponent();
            btnCreateAccount.Visible = false;
            btnCreateAccount.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("") || txtUsername.Text.Equals(""))
            {
                lblNotice.Text = "You need to fill all the fields";
                Console.Write("asd");
                return;
            }
            User.getInstance().login(txtUsername.Text, txtPassword.Text, (status) =>
            {
                if (status == LOGIN_STATUS.SUCCESS)callBackListener();
                else lblNotice.Text = "Something went wrong during login";           
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
                User.getInstance().createUser(txtUsername.Text, txtPassword.Text);
                User.getInstance().login(txtUsername.Text, txtPassword.Text, (status) =>
                {
                    if (status == LOGIN_STATUS.SUCCESS) callBackListener();
                    else lblNotice.Text = "Something went wrong during login";
                });
            }
            catch (UserExistsException ex)
            {
                lblNotice.Text = "Username already exists";
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lblRegister.Text.Equals ("Don't have an account?")){
                lblRegister.Text="Already have an account?";
            }else{
                lblRegister.Text="Don't have an account?";
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
    }
}
