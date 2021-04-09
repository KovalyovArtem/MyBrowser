using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            webBrowser1.Url = new Uri("http://google.com");
        }

        void Proverka()
        {
            if (webBrowser1.CanGoForward == false)
            {
                btnGoForward.Enabled = false;
                btnGoForward.BackgroundImage = Properties.Resources.arrow_right_unActive;
            }
            else //  if (webBrowser1.CanGoForward == true)
            {
                btnGoForward.Enabled = true;
                btnGoForward.BackgroundImage = Properties.Resources.arrow_right;
            }

            if (webBrowser1.CanGoBack == false)
            {
                btnGoBack.Enabled = false;
                btnGoBack.BackgroundImage = Properties.Resources.arrow_left_unActive;
            }
            else //  if (webBrowser1.CanGoBack == true)
            {
                btnGoBack.Enabled = true;
                btnGoBack.BackgroundImage = Properties.Resources.arrow_left;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tbxSearch.Text);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnGoForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void tbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSearch_Click(sender, e);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                btnReload_Click(sender, e);
            if (e.KeyCode == Keys.XButton1)
                btnGoForward_Click(sender, e);
            if (e.KeyCode == Keys.XButton2)
                btnGoBack_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Proverka();
        }
    }
}
