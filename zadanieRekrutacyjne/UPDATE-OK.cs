using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using System.Windows.Forms;

namespace zadanieRekrutacyjne
{
    public partial class UPDATE_OK : Form
    {
        public UPDATE_OK()
        {
            InitializeComponent();
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int updPid = Convert.ToInt32(updParentId.Text);
                int updOid = Convert.ToInt32(updOrderId.Text);
                string updN = updName.Text;
                string updD = updDescription.Text;
                bool updV = updVis.Checked;
                
                string name = Login.log;
                string pas = Login.pass;
                string url = Login.url;
                string resName = Login.resource;

                string currentId = currentIdLabel.Text;

                var client = new RestClient(url)
                {
                    Authenticator = new HttpBasicAuthenticator(name, pas)
                };

                var request = new RestRequest("/{resource}/{id}", Method.PUT);
                request.AddUrlSegment("resource", resName);
                request.AddUrlSegment("id", Convert.ToInt16(currentIdLabel.Text));

                CatJson cat = new CatJson
                {
                    category = new Category(updN,
                    updPid,
                    updV,
                    updOid,
                    updD,
                    string.Empty)
                };
                request.AddJsonBody(cat);

                string json = JsonConvert.SerializeObject(cat);
                client.ExecuteAsync(request, response =>
                {
                    HttpStatusCode statusCode = response.StatusCode;
                    if (response.IsSuccessful == true) { MessageBox.Show("Category with id " + currentId + " was edited."); }
                    else MessageBox.Show("Error occured.\nError code: " + (int)statusCode);

                });
                Close();
            }
            catch (FormatException) { MessageBox.Show("Enter proper values.", "ERROR", 
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (JsonReaderException) { MessageBox.Show("Chech URL you put while logging in.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
