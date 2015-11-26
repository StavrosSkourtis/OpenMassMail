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
    public partial class MessagePreviewForm : Form
    {
        public MessagePreviewForm(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message)
        {
            InitializeComponent();
            setMessage(message);
        }
        public void setMessage(OpenMassSenderCore.OpenMassSenderDBDataSet.MessageRow message)
        {
            this.Text = "Message Preview - " + message.subject;
            this.webBrowser1.DocumentText = message.message;
        }

    }
}
