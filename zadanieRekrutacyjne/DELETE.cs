using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using System.Windows.Forms;

namespace zadanieRekrutacyjne
{
    public partial class DELETE : Form
    {
        public DELETE()
        {
            InitializeComponent();
        }

        private void toDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string user_id = searchCatName.Text;
                int id = Convert.ToInt16(user_id);
                string name = Login.log;
                string pas = Login.pass;
                string url = Login.url;
                string resName = Login.resource;

                var client = new RestClient(url)
                {
                    Authenticator = new HttpBasicAuthenticator(name, pas)
                };

                var request = new RestRequest("/{resource}/{id}", Method.DELETE);
                request.AddUrlSegment("resource", resName);
                request.AddUrlSegment("id", id);
                
                client.ExecuteAsync(request, response =>
                {
                    HttpStatusCode statusCode = response.StatusCode;
                    if (response.IsSuccessful == true) { MessageBox.Show("Category " + user_id + " deleted."); }
                    else if ((int)statusCode == 401)
                    {
                        MessageBox.Show("Authorization error. Go back to LOGin window and enter proper login and password.", "ERROR",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if ((int)statusCode == 404)
                    {
                        MessageBox.Show("Bad request error.Check if this id exist.", "ERROR",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Error occured.\nError code: " + (int)statusCode);

                });
            }
            catch (FormatException) { MessageBox.Show("Put integer number of id you want to see", "ERROR", 
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
