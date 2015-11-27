using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

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
                tbContent.Enabled = false;
                lblLinkedFile.Text = message.linkedFile;
                btnFileLink.Text = "Unlink file";
            }
        }
        Regex containsHtml = new Regex(@"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>");
        private void tbContent_TextChanged(object sender, EventArgs e)
        {
            if (message.type.Equals("sms"))
            {
                lblTextLengthWarning.Text = (160 - tbContent.Text.Length) + " characters left";
            }
            message.setMessage(tbContent.Text);

            if (containsHtml.IsMatch(message.message))
            {
                btnPreviewHTML.Visible = true;
            }
            else
            {
                btnPreviewHTML.Visible = false;
            }
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
                tbContent.Enabled = true;
                message.linkedFile=null;
                lblLinkedFile.Text = "";
                btnFileLink.Text = "Link file";
            }
            else
            {
                ofd1.ShowDialog();
                if (ofd1.FileName != null && !ofd1.FileName.Equals(""))
                {
                    tbContent.Text = File.ReadAllText(ofd1.FileName);
                    tbContent.Enabled = false;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            btnPreviewHTML.Visible = false;
        }

        private void tbSubject_TextChanged(object sender, EventArgs e)
        {
            message.subject = tbSubject.Text;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }




    }
}
