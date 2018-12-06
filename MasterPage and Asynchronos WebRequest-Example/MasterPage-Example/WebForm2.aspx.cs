using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace MasterPage_Example
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MasterPage_Example.HttPagent httPagent = new HttPagent();
            httPagent.GetAsyncHtml("https://gitlab.com/api/v4/projects/9475503/repository/branches?branch=master");

            WebRequestAsync();
            string apiUrl = "https://gitlab.com/api/v4/projects/9475503/repository/branches?branch=master";

            Uri address = new Uri(apiUrl);

            // Create the web request 
            HttpWebRequest request = WebRequest.Create(address) as HttpWebRequest;

            // Set type to POST 
            request.Method = "GET";
            request.ContentType = "text/xml";
            request.Headers.Clear();
            request.Headers.Add("PRIVATE-TOKEN", "upkWzxZXaAoyAhCxXwj_");

            
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                // Get the response stream 
                StreamReader reader = new StreamReader(response.GetResponseStream());

                // Console application output 
                string strOutputXml = reader.ReadToEnd();

            }
        }

        public void WebRequestAsync()
        {
            try
            {

                System.Uri uri = new Uri("https://gitlab.com/api/v4/projects/9475503/repository/branches?branch=master");
                // Create a HttpWebrequest object to the desired URL.
                HttpWebRequest myHttpWebRequest1 = (HttpWebRequest)WebRequest.Create(uri);

                // Create an instance of the RequestState and assign the previous myHttpWebRequest1
                // object to it's request field.  
                //RequestState myRequestState = new RequestState();
                //myRequestState.request = myHttpWebRequest1;


                // Start the asynchronous request.
                IAsyncResult result =
                  (IAsyncResult)myHttpWebRequest1.BeginGetResponse(new AsyncCallback(RespCallback), myHttpWebRequest1);

                //StreamReader reader = new StreamReader(myHttpWebRequest1.GetResponse());

                // Console application output 
                //string strOutputXml = reader.ReadToEnd();

                if(result.IsCompleted)
                {
                    Response.Write("yes completed");
                }


            }
            catch (WebException e)
            {
                Response.Write(e.Message);
            }
            catch (Exception e)
            {
                Response.Write(e.Message);
            }
        }

        private void RespCallback(IAsyncResult ar)
        {
            if(ar.IsCompleted)
            {
                Response.Write("yes done");
            }
            //switch (ar)
            //{
            //    case :

            //    default:
            //        break;
            //}
        }
    }
}