using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balaban_Müzik
{
    public partial class hakkinda : Form
    {
        public hakkinda()
        {
            InitializeComponent();
            
            labelProductName.Text = Application.ProductName;
            labelVersion.Text = String.Format("Version: {0}", Application.ProductVersion);
            this.Text = String.Format("Hakkında {0}", Application.ProductName);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public string Url
        {
            get { return linkLabelWebsite.Text; }
            set { linkLabelWebsite.Text = value; }
        }


        public string Email
        {
            get { return linkLabelFeedback.Text; }
            set { linkLabelFeedback.Text = value; }
        }


        public string Copyright
        {
            get { return labelCopyright.Text; }
            set { labelCopyright.Text = value; }
        }

        private void linkLabelFeedback_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:" + linkLabelFeedback.Text);
        }

        private void linkLabelWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(linkLabelWebsite.Text);
        }

        private void hakkinda_Load(object sender, EventArgs e)
        {

        }
    }
}
