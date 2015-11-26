using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OpenMassSenderCore.OpenMassSenderDBDataSetTableAdapters;

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
            this.Close();
        }

        private void btnSearchReceiver_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void receiversWindow_Load(object sender, EventArgs e)
        {
            cbReceiverGroups.DataSource = ReceiverTableAdapter.getInstance().GetGroups(Int32.Parse(ReceiverTableAdapter.getInstance().userid));
            cbReceiverGroups.DisplayMember = "group";
            cbReceiverGroups.ValueMember = "group";
        }

        public void refreshData()
        {
  

    
        }

        private void tbSearchQuery_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void ComboBoxReceiversGroup_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxReceiversGroup_TextChanged(object sender, EventArgs e)
        {
            refreshData();
        }
    }
}
