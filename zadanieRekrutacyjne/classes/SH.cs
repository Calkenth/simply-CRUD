using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    class SH
    {
        public string show()
        {
            var client = new RestClient(Login.url)
            {
                Authenticator = new HttpBasicAuthenticator(Login.log, Login.pass)
            };

            var request = new RestRequest("/{resource}", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddUrlSegment("resource", Login.resource);

            var ex = client.Execute(request);
            IRestResponse response = ex;
            HttpStatusCode statusCode = response.StatusCode;

            var content = ex.Content;
            content = JToken.Parse(content).ToString(Formatting.Indented);
            if ((int)statusCode == 401)
            {
                MessageBox.Show("Authorization error. Go back to LOGin window and enter proper login and password.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return content;
        }
        public string show(int id)
        {
            var client = new RestClient(Login.url)
            {
                Authenticator = new HttpBasicAuthenticator(Login.log, Login.pass)
            };

            var request = new RestRequest("{resource}/{id}", Method.GET)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddUrlSegment("resource", Login.resource);
            request.AddUrlSegment("id", id);

            var ex = client.Execute(request);
            IRestResponse response = ex;
            HttpStatusCode statusCode = response.StatusCode;

            var content = ex.Content;
            content = JToken.Parse(content).ToString(Formatting.Indented);
            if ((int)statusCode == 401)
            {
                MessageBox.Show("Authorization error. Go back to LOGin window and enter proper login and password.", "ERROR",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return content;
        }
    }
}
