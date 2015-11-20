using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore;
using OpenMassSenderCore.Users;

namespace OpenMassSenderGUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (UsersManager.getInstance().userid.Equals("") || UsersManager.getInstance().userid == null)
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
            loginForm frm = new loginForm(() =>
            {
                Invoke(new Action(() => connectToolStripMenuItem.Text = "Change account"));
                Logger.log("user logged in with id" + UsersManager.getInstance().userid);
            });
            frm.TopMost = true;
            frm.Show();
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
    }
}
