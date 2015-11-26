using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OpenMassSenderGUI
{
    public partial class MessageForm : Form
    { 
        OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message;
        public MessageForm(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message)
        {
            InitializeComponent();
            this.message = message;
            if (message.linkedFile != null)
            {
                tbMessageContent.Enabled = false;
                lblLinkedFile.Text = message.linkedFile;
                btnFileLink.Text = "Unlink file";
            }
        }

        private void tbMessageContent_TextChanged(object sender, EventArgs e)
        {
            if (message.type.Equals("sms"))
            {
                lblTextLengthWarning.Text = (160 - tbMessageContent.Text.Length) + " characters left";
            }
            message.message = tbMessageContent.Text;
        }

        private void btnVariables_Click(object sender, EventArgs e)
        {
            MessageVariablesForm variablesForm = new MessageVariablesForm(message);
            variablesForm.Show();
        }

        private void btnFileLink_Click(object sender, EventArgs e)
        {
            if (btnFileLink.Text.Equals("Unlink file"))
            {
                tbMessageContent.Enabled = true;
                message.linkedFile=null;
                lblLinkedFile.Text = "";
                btnFileLink.Text = "Link file";
            }
            else
            {
                ofd1.ShowDialog();
                if (ofd1.FileName != null && !ofd1.FileName.Equals(""))
                {
                    tbMessageContent.Text = File.ReadAllText(ofd1.FileName);
                    tbMessageContent.Enabled = false;
                    lblLinkedFile.Text = ofd1.FileName;
                    message.linkedFile = ofd1.FileName;
                    btnFileLink.Text = "Unlink file";
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private MessagePreviewForm messagePreview = null;
        private void btnPreviewHTML_Click(object sender, EventArgs e)
        {
            if (messagePreview == null || messagePreview.IsDisposed || messagePreview.IsAccessible == false)
            {
                messagePreview = new MessagePreviewForm(message);
            }

            messagePreview.Show();
            messagePreview.Focus();
        }


    }
}
