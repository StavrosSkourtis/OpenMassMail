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
    public partial class receiversWindow : Form
    {
        public receiversWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click_1(object sender, EventArgs e)
        {
            //apla gia na kanw testing to emailMessageEdit form, den tha kanei load apo dw kanonika
            emailMessageEdit frm = new emailMessageEdit();
            frm.Show();
        }
    }
}
