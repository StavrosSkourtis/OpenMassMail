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
    public partial class ViewReceiversForm : Form
    {

        public ViewReceiversForm()
        {
            InitializeComponent();
        }

        private void ViewReceiversForm_Load(object sender, EventArgs e)
        {
            // Fill the Group Combo Box
            // This method will cause an SelectedIndexChangeEvent wich will update the ListView
            UpdateGroupComboBox();

        }


        /*
         *  Updates the values of the group ComboBox
         */
        private void UpdateGroupComboBox()
        {

            cbReceiversGroup.Items.Clear();
            /*
             *  Loop through all the receivers and add the rows to the table
             */
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in ReceiverTableAdapter.getInstance().GetDataByDistinctGroups())
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    cbReceiversGroup.Items.Add(row.group);
                }
            }
            // IF there is at least on item in te combo box set the first one as the selected
            if(cbReceiversGroup.Items.Count>0)
                cbReceiversGroup.SelectedIndex = 0;
        }

        private void bntSearchReceiver_Click(object sender, EventArgs e)
        {

            
            dgvReceivers.DataSource = ReceiverTableAdapter.getInstance().searchReceivers(cbReceiversGroup.SelectedItem.ToString(), tbSearch.Text); ;
            dgvReceivers.Columns["user"].Visible = false;
            dgvReceivers.Columns["UserRow"].Visible = false;
            dgvReceivers.Columns["HasErrors"].Visible = false;
            dgvReceivers.Columns["RowError"].Visible = false;
            dgvReceivers.Columns["RowState"].Visible = false;
            dgvReceivers.Columns["Table"].Visible = false;
            dgvReceivers.Columns["metadata"].Visible = false;

        }

        private void dgvReceivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
           
            // Check if the row index bellows to the data and not the header
            if ( e.RowIndex >= 0 )
            {
                // Clear all the current rows
                dgvDetails.Rows.Clear();

                // Split the metadata string by ';'
                string[] propertyRows = dgvReceivers.Rows[e.RowIndex].Cells["metadata"].Value.ToString().Split(';');

                // Loop through every pair of metadata
                foreach (string propertyRow in propertyRows)
                {   
                    // Split the pair of data by '='
                    string[] propertyData = propertyRow.Split('=');

                    // Add the data to a new Row
                    dgvDetails.Rows.Add(propertyData[0], propertyData[1]);

                }

            }
            
        }

    }
}
