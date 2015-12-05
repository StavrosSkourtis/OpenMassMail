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

            cbReceiversGroup.Items.Add("All");
            cbReceiversGroup.SelectedIndex = 0;
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
            
        }


        /* 
         *  Updates the data in the list view by the group parameter.
         *  If group is "All" the List View will be populated by all the receivers
         */
        private void UpdateListViewData(string group)
        {
            /*
             *  Clear the list view
             */
            listViewReceivers.Items.Clear();

            // Define the ReceiverDataTable object
            OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverDataTable receiverTable;

            // Create the DataTable and fill by group, if group is "All" get all the receivers
            if( group == "All")
                receiverTable = ReceiverTableAdapter.getInstance().GetData();
            else
                receiverTable = ReceiverTableAdapter.getInstance().GetDataByGroupOnly(group);
            
            /*
             *  Loop through all the receivers and add the rows to the table
             */
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in receiverTable)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    ListViewItem item = new ListViewItem(row.ID.ToString());
                    item.SubItems.Add(row.email.ToString());
                    item.SubItems.Add(row.phone_number.ToString());
                    item.SubItems.Add(row.metadata.ToString());
                    item.SubItems.Add(row.group.ToString());

                    listViewReceivers.Items.Add(item);
                }
            }
        }

        private void cbReceiversGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Update the ListBox by selected group
            UpdateListViewData(cbReceiversGroup.SelectedItem.ToString());
        }

        private void bntSearchReceiver_Click(object sender, EventArgs e)
        {


            
            //Clear the list view
            listViewReceivers.Items.Clear();

            // Loop through all the receivers and add the rows to the table
             
            foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.ReceiverRow row in ReceiverTableAdapter.getInstance().searchReceivers(cbReceiversGroup.SelectedItem.ToString(), tbSearch.Text))
            {
                Console.WriteLine("asd:" + row.ID);
                if (row.RowState != DataRowState.Deleted)
                {
                    ListViewItem item = new ListViewItem(row.ID.ToString());
                    item.SubItems.Add(row.email.ToString());
                    item.SubItems.Add(row.phone_number.ToString());
                    item.SubItems.Add(row.metadata.ToString());
                    item.SubItems.Add(row.group.ToString());

                    listViewReceivers.Items.Add(item);
                }
            }

           
        }



    }
}
