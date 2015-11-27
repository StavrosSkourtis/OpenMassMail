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
    public partial class MessageVariablesForm : Form
    {
        Dictionary<string, string> variables;
        OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message;
        public MessageVariablesForm(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message)
        {
            this.message = message;
            this.variables = message.replacableVariablesMap;
            InitializeComponent();
            foreach (KeyValuePair<string, string> entry in variables)
            {
                string[] row = {entry.Key,entry.Value!=null?"dynamic":entry.Value};
                var listViewItem = new ListViewItem(row);
                lvVariables.Items.Add(listViewItem);
            }
        }


        private void Add_Click(object sender, EventArgs e)
        {
            if (txtReplace.Text.Equals(""))
            {
                errorProv.SetError(txtReplace, "this field can't be empty");
                return;
            }
            if (txtWith.Text.Equals("")) {

                errorProv.SetError(txtWith, "this field can't be empty");
                return;
            }

            variables.Add(!(txtReplace.Text.ToCharArray(0, 1)[0] == '$') ? "$" : "" + txtReplace.Text, txtWith.Text);
            string[] row = { !(txtReplace.Text.ToCharArray(0, 1)[0] == '$') ? "$" : "" + txtReplace.Text, txtWith.Text };
            var listViewItem = new ListViewItem(row);
            lvVariables.Items.Add(listViewItem);

            message.variablesListUpdated();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lvVariables.SelectedIndices.Count != 0)
            {
                foreach (ListViewItem a in lvVariables.SelectedItems)
                {
                    a.Remove();
                    variables.Remove(a.GetSubItemAt(0,a.Index).Text);
                }
            }
            message.variablesListUpdated();
        }

        private void MessageVariablesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
