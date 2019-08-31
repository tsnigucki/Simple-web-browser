using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_web_browser
{
    public partial class SimpleWebBrowser : Form
    {
        public SimpleWebBrowser()
        {
            InitializeComponent();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            GoWebsite();
        }

        private void websiteAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                GoWebsite();
        }

        void GoWebsite()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(websiteAddress.Text))
                {
                    webBrowser1.Navigate(websiteAddress.Text);
                }
                else
                    webBrowser1.Navigate("http://www.google.pl");
            }
            catch(Exception ex)
            {
                string error = string.Format("problem loading the page:\n{0}\n\n{1}",websiteAddress.Text, ex.Message);
                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
