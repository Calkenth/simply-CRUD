using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanieRekrutacyjne
{
    class create
    {
        public create(string newN,int newPid,bool newV,int newOid, string newD,string newCatName)
        {
            var client = new RestClient(Login.url);
            client.Authenticator = new HttpBasicAuthenticator(Login.log, Login.pass);

            var request = new RestRequest("/{resource}/", Method.POST)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddUrlSegment("resource", Login.resource);

            CatJson cat = new CatJson
            {
                category = new Category(newN,
                newPid,
                newV,
                newOid,
                newD,
                string.Empty)
            };
            request.AddJsonBody(cat);

            string json = JsonConvert.SerializeObject(cat);
            client.ExecuteAsync(request, response =>
            {
                HttpStatusCode statusCode = response.StatusCode;
                if (response.IsSuccessful == true)
                {
                    MessageBox.Show("New category created.\nCategory name: " + newCatName);
                }
                else if (statusCode == HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Bad request exception." +
                                    "\nCreate new category with filled NAME,PARENT ID and ORDERING ID at least", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((int)statusCode == 404)
                {
                    MessageBox.Show("Bad request error.Did you enter proper values?", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if ((int)statusCode == 401)
                {
                    MessageBox.Show("Authorization error. Go back to LOGin window and enter proper login and password.", "ERROR",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Error occured.\nError code: " + (int)statusCode);
            });
        }
    }
}
