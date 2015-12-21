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
            CreateDataGridViewColumns();
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


        private void CreateDataGridViewColumns()
        {

            List<string> groups = new List<string>();

            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in ReceiverTableAdapter.getInstance().GetDataByDistinctGroups())
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    groups.Add(row.group);
                }
            }

            DataGridViewTextBoxColumn idCol,emailCol,phoneNumberCol,metadataCol;
            DataGridViewComboBoxColumn groupCol;

           
            idCol = new DataGridViewTextBoxColumn();
            idCol.HeaderText = "id";
            idCol.Name = "id";
            dgvReceivers.Columns.Add(idCol);

            
            emailCol = new DataGridViewTextBoxColumn();
            emailCol.HeaderText = "email";
            emailCol.Name = "email";
            dgvReceivers.Columns.Add(emailCol);

            phoneNumberCol = new DataGridViewTextBoxColumn();
            phoneNumberCol.HeaderText = "phone_number";
            phoneNumberCol.Name = "phone_number";
            dgvReceivers.Columns.Add(phoneNumberCol);

            metadataCol = new DataGridViewTextBoxColumn();
            metadataCol.HeaderText = "metadata";
            metadataCol.Name = "metadata";
            dgvReceivers.Columns.Add(metadataCol);


            groupCol = new DataGridViewComboBoxColumn();
            groupCol.HeaderText = "group";
            groupCol.Name = "group";
            groupCol.DataSource = groups;
            dgvReceivers.Columns.Add(groupCol);

            dgvReceivers.Columns["metadata"].Visible = false;

        }

        private void bntSearchReceiver_Click(object sender, EventArgs e)
        {
            searchReceivers();
        }
        public void searchReceivers()
        {
            dgvDetails.Rows.Clear();

            dgvReceivers.Rows.Clear();
            foreach(OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in ReceiverTableAdapter.getInstance().searchReceivers(cbReceiversGroup.SelectedItem.ToString(), tbSearch.Text)){
                dgvReceivers.Rows.Add(new Object[] { row["ID"] , row["email"] , row["phone_number"] , row["metadata"] ,row["group"]});       
            }

            updateMetadataGridView(dgvReceivers.CurrentCell.RowIndex);
        }

        private void dgvReceivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateMetadataGridView(e.RowIndex);
        }

        private void updateMetadataGridView(int rowId)
        {
            // Check if the row index bellows to the data and not the header
            if (rowId >= 0)
            {
                // Clear all the current rows
                dgvDetails.Rows.Clear();

                // Split the metadata string by ';'
                string[] propertyRows = dgvReceivers.Rows[rowId].Cells["metadata"].Value.ToString().Split(';');

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

        private void cbReceiversGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchReceivers();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            searchReceivers();
        }



        private void saveMetaDataChanges_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvReceivers.Rows[dgvReceivers.CurrentCell.RowIndex].Cells[0].Value.ToString());

            
            string metadataString ="";

            foreach (DataGridViewRow row in dgvDetails.Rows)
            {
                if (row.Index == dgvDetails.NewRowIndex)
                    break;
                if (metadataString != "")
                    metadataString += ";";
                
                metadataString += row.Cells[0].Value + "=";
                metadataString += row.Cells[1].Value;
                
            }

            
            ReceiverTableAdapter.getInstance().UpdateMetadata(metadataString,id);

            MessageBox.Show("Metadata of Receiver " + id + " was updated successfuly!"); 
            
            searchReceivers();

        }



    }
}
