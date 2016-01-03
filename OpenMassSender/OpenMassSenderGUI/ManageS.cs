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
    public partial class ManageS : Form
    {
        int temp = 0;
        int numberOfRow = 0;
        public ManageS()
        {
            InitializeComponent();
             numberOfRow = Convert.ToInt32(SenderAccountTableAdapter.getInstance().ScalarQuery());
             loaddata();
             

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSendertoolStripButton_Click(object sender, EventArgs e)
        {

            AddNewSender frm = new AddNewSender(numberOfRow);
            frm.Show();
           
            temp = 1;
            loaddata();
        }
        private void loaddata()
        {
            

            try
            {

                foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow row in SenderAccountTableAdapter.getInstance().GetDataByUserID(Int32.Parse(UserTableAdapter.getInstance().userid)))
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        dt.Rows.Add(row.ID , row.email, row.first_name, row.last_name, row.host);
                        senderdataGridView.DataSource = dt;
                        

                    }
                }
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("First Name", typeof(string));
                dt.Columns.Add("Last Name", typeof(string));
                dt.Columns.Add("Host", typeof(string));

                DataGridViewColumn id = senderdataGridView.Columns[0];
                id.Width = 50;
                DataGridViewColumn email = senderdataGridView.Columns[1];
                email.Width = 160;
                DataGridViewColumn fn = senderdataGridView.Columns[2];
                fn.Width = 100;
                DataGridViewColumn ln = senderdataGridView.Columns[3];
                ln.Width = 100;
                DataGridViewColumn host = senderdataGridView.Columns[4];
                host.Width = 85;
                       
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void senderdataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this sender?", "Deleting Sender Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                SenderAccountTableAdapter.getInstance().DeleteSenderById(Convert.ToInt32(e.Row.Cells["ID"].Value.ToString()));
            }
            else
            {
                e.Cancel = true;
            }
        }
        DataTable dt = new DataTable();


        

        
        private void Savebutton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(senderdataGridView.Rows[senderdataGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
            string email=senderdataGridView.Rows[senderdataGridView.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string fname=senderdataGridView.Rows[senderdataGridView.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string lname=senderdataGridView.Rows[senderdataGridView.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string host=senderdataGridView.Rows[senderdataGridView.CurrentCell.RowIndex].Cells[4].Value.ToString();
            int user=UserTableAdapter.getInstance().userid ;
            foreach (DataGridViewRow row in senderdataGridView.Rows )
            {
                if (row.Index == senderdataGridView.NewRowIndex) break;
                
            }
            //SenderAccountTableAdapter.getInstance().Update(id,)
            MessageBox.Show("Metadata of Receiver " + " was updated successfuly!"); 
        }

       
       


    }
}
