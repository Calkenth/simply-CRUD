using System;
using System.Windows.Forms;

namespace zadanieRekrutacyjne
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            Login login = new Login();
            login.ShowDialog();
        }

        private void cmdSHOW_Click(object sender, EventArgs e)
        {
            var Show = new SHOW();
            Show.Show();
        }

        private void cmdNEW_Click(object sender, EventArgs e)
        {
            var New = new NEW();
            New.Show();
        }

        private void cmdUPDATE_Click(object sender, EventArgs e)
        {
            var Upd = new UPDATE();
            Upd.Show();
        }

        private void cmdDELETE_Click(object sender, EventArgs e)
        {
            var Del = new DELETE();
            Del.Show();
        }

        private void newLog_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
