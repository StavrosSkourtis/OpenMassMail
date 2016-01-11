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
        int numberOfRows;

        public ManageS()
        {
            InitializeComponent();
            numberOfRows = Convert.ToInt32(SenderAccountTableAdapter.getInstance().ScalarQuery1());

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddSendertoolStripButton_Click(object sender, EventArgs e)
        {

            AddNewSender frm = new AddNewSender(numberOfRows);
            frm.Show();
            temp = 1;

        }
        private void loaddata()
        {
            createcolumns();

            try
            {

                foreach (OpenMassSenderCore.OpenMassSenderDBDataSet.SenderAccountRow row in SenderAccountTableAdapter.getInstance().GetDataByUserID(Int32.Parse(UserTableAdapter.getInstance().userid)))
                {
                    if (row.RowState != DataRowState.Deleted)
                    {
                        dt.Rows.Add(row.ID, row.email, row.first_name, row.last_name, row.host, row.userid, row.type);
                        senderdataGridView.DataSource = dt;
                        DataGridViewColumn id = senderdataGridView.Columns[0];
                        id.Width = 50;
                        DataGridViewColumn email = senderdataGridView.Columns[1];
                        email.Width = 180;
                        DataGridViewColumn fn = senderdataGridView.Columns[2];
                        fn.Width = 100;
                        DataGridViewColumn ln = senderdataGridView.Columns[3];
                        ln.Width = 100;
                        DataGridViewColumn host = senderdataGridView.Columns[4];
                        host.Width = 85;
                        DataGridViewColumn user = senderdataGridView.Columns[5];
                        host.Width = 150;
                        DataGridViewColumn type = senderdataGridView.Columns[6];
                        host.Width = 150;


                    }
                }
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
                numberOfRows = Convert.ToInt32(SenderAccountTableAdapter.getInstance().ScalarQuery1());
            }
            else
            {
                e.Cancel = true;
            }
        }

        
       
        DataTable dt = new DataTable();
        private void createcolumns()
        {

            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Host", typeof(string));
            dt.Columns.Add("User", typeof(int));
            dt.Columns.Add("Type", typeof(string));
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New sender was updated successfuly!");
            this.Close();
        }

        private void ManageS_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void ManageS_Activated(object sender, EventArgs e)
        {
            if (temp == 1)
            {
                dt.Rows.Clear();
                dt.Columns.Clear();
                loaddata();

                temp = 0;
                ++numberOfRows;
            }
        }




    }
}

