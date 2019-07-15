using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;
using System.Windows.Forms;

namespace zadanieRekrutacyjne
{
    public partial class UPDATE : Form
    {
        public UPDATE()
        {
            InitializeComponent();
        }

        public void toUpdate_Click(object sender, EventArgs e)
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

                var request = new RestRequest("/{resource}/{id}", Method.GET)
                {
                    RequestFormat = DataFormat.Json
                };
                request.AddUrlSegment("resource", resName);
                request.AddUrlSegment("id", id);

                var execute = client.Execute(request);
                IRestResponse response = execute;
                HttpStatusCode statusCode = response.StatusCode;

                var content = execute.Content;
                if (response.IsSuccessful == true)
                {
                    content = JToken.Parse(content).ToString(Formatting.Indented);
                    JObject json = JObject.Parse(content);
                    var update_ok = new UPDATE_OK();
                    update_ok.currentIdLabel.Text = user_id;
                    update_ok.contentTextBox.Text = content;
                    update_ok.Show();
                    Close();

                }
                else if (statusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Bad request exception." +
                                    "\nFill NAME,PARENT ID and ORDERING ID at least to update category.", "Error", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((int)statusCode == 401) { MessageBox.Show("Authorization error. Go back to LOGin window and enter proper login and password.", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else if ((int)statusCode == 404) { MessageBox.Show("Bad request error.Check if this id exist.", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error); }
                else MessageBox.Show("Error occured.\nError code: " + (int)statusCode);
            }
            catch (FormatException) { MessageBox.Show("Put integer number(id) you want to see or CLOSE update window.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (JsonReaderException) { MessageBox.Show("Chech URL you put while logging in.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
