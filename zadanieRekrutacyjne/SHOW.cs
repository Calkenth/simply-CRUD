using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;

namespace zadanieRekrutacyjne
{
    public partial class SHOW : Form
    {
        public SHOW()
        {
            InitializeComponent();
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            try
            {
                string showAll = new SH().show();
                contentTxtBox.Text = showAll;
            }
            catch (JsonReaderException)
            {
                MessageBox.Show("Chech URL you put while logging in.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showOne_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt16(searchCat.Text);
                string showAll = new SH().show(id);
                contentTxtBox.Text = showAll;
            }
            catch (FormatException)
            {
                MessageBox.Show("Put integer number of id you want to see", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (JsonReaderException)
            {
                MessageBox.Show("Chech URL you put while logging in.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
