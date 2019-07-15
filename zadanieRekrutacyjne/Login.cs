using System;
using System.Windows.Forms;

namespace zadanieRekrutacyjne
{
    public partial class Login : Form
    {
        public static string log;
        public static string pass;
        public static string url;
        public static string resource;
        public Login()
        {
            InitializeComponent();
        }

        public void Log_Click(object sender, EventArgs e)
        {
            url = URI.Text;
            resource = resName.Text;
            log = logValue.Text;
            pass = passValue.Text;
            Close();
        }
    }
}
