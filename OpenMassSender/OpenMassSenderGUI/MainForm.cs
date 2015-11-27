using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;
using System.IO;


namespace OpenMassSenderGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Logger.logWindow = new LoggerForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (UserTableAdapter.getInstance().userid == null || UserTableAdapter.getInstance().userid.Equals(""))
            {
                showLoginForm();
            }  
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //----------------->thano edw<------------------------
            //kwdikas gia to anoigma tis add form
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showLoginForm();
        }

        public void showLoginForm()
        {
            this.Hide();
            LoginForm loginForm = null;
            loginForm=new LoginForm((username,password,userid)=>{
                //write the user's id to a file so that the job execution service can know what user is logged in without the desktop
                //project running
                File.WriteAllText("omsloggeduser.dt", username + "|" + password + "|" + userid);

                ReceiverTableAdapter.getInstance().setUserID(userid) ;
                SenderAccountTableAdapter.getInstance().setUserID(userid);
                JobTableAdapter.getInstance().setUserID(userid);
                JobScheduleTableAdapter.getInstance().setUserID(userid);
                MessageTableAdapter.getInstance().setUserID(userid);
                SenderAccountTableAdapter.getInstance().setUserID(userid);

                loginForm.Close();
            });
            loginForm.TopMost = true;
            loginForm.ShowDialog();
        }

        private void manageSendersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //----------------->thano edw<------------------------
            //kwdikas gia to anoigma tis manage senders form
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //apla gia na kanw testing to receiversWindow, den tha kanei load apo dw kanonika
            receiversWindow frm = new receiversWindow();
            frm.Show();
        }

        private void btnShowNotReady_Click(object sender, EventArgs e)
        {

        }
    }
}
