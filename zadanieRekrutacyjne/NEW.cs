using System;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace zadanieRekrutacyjne
{
    public partial class NEW : Form
    {
        public NEW()
        {
            InitializeComponent();
        }
        private void newCat_Click(object sender, EventArgs e)
        {
            try
            {
                int newPid = Convert.ToInt32(newParentId.Text);
                int newOid = Convert.ToInt32(newOrderId.Text);
                string newN = newName.Text;
                string newD = newDescription.Text;
                bool newV = newVis.Checked;

                var post = new create(newN, newPid, newV, newOid, newD, newName.Text);
                
            }
            catch (FormatException) { MessageBox.Show("Enter proper values.\nIds are integers, others are what you want.", "ERROR", 
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
