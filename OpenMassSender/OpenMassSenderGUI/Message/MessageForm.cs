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
        private AddNewJob formparent = null;

        OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message;
        public MessageForm(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message,Form frm)
        {
            formparent = frm as AddNewJob;

            InitializeComponent();
            this.message = message;
            if (message.linkedFile != null && message.linkedFile!="")
            {
                tbContent.Enabled = false;
                lblLinkedFile.Text = message.linkedFile;
                btnFileLink.Text = "Unlink file";
            }
            this.tbContent.Text = message.message;
            this.tbSubject.Text = message.subject;

        }
        Regex containsHtml = new Regex(@"<\s*([^ >]+)[^>]*>.*?<\s*/\s*\1\s*>");
        private void tbContent_TextChanged(object sender, EventArgs e)
        {
            if (message.type.Equals("sms"))
            {
                lblTextLengthWarning.Text = (160 - tbContent.Text.Length) + " characters left";
            }
            message.setMessage(tbContent.Text);
        }
        private void btnVariables_Click(object sender, EventArgs e)
        {

        }

        private void btnFileLink_Click(object sender, EventArgs e)
        {
            if (btnFileLink.Text.Equals("Unlink file"))
            {
                tbContent.Enabled = true;
                message.linkedFile="";
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
            this.formparent.filepath = tbSubject.Text;
            formparent.Show();
            this.Close();
        }

        private MessagePreviewForm messagePreview = null;
        private void btnPreviewHTML_Click(object sender, EventArgs e)
        {

        }


        private void tbSubject_TextChanged(object sender, EventArgs e)
        {
            message.subject = tbSubject.Text;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbtnPreview_Click(object sender, EventArgs e)
        {
            if (messagePreview == null || messagePreview.IsDisposed)
            {
                messagePreview = new MessagePreviewForm(message);
            }

            messagePreview.Show();
            messagePreview.Focus();
        }

        private void tsbrnVariables_Click(object sender, EventArgs e)
        {
            MessageVariablesForm variablesForm = new MessageVariablesForm(message);
            variablesForm.Show();
        }
    }
}
