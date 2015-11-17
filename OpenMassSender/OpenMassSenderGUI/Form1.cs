using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OpenMassSenderGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //----------------->thano edw<------------------------
            //kwdikas gia to anoigma tis add form
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm frm = new loginForm(() => { Console.Write("user logged in"); });
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
