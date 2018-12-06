using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;

namespace MasterPage_Example
{
    public class AsyncWebRequestMethod
    {

    }

    public class RequestState
    {
        public string _urlHtml = "";
        public bool isCompleted = false;

        // This class stores the State of the request.
        const int BUFFER_SIZE = 1024;
        public StringBuilder requestData;
        public byte[] BufferRead;
        public HttpWebRequest request;
        public HttpWebResponse response;
        public Stream streamResponse;

        public RequestState()
        {
            BufferRead = new byte[BUFFER_SIZE];
            requestData = new StringBuilder("");
            request = null;
            streamResponse = null;
        }
    }

    public class HttPagent
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);
        const int BUFFER_SIZE = 1024;
        
        public void GetAsyncHtml(string url)
        {
            try
            {
                var uri = new Uri(url);

                // Create a HttpWebrequest object to the desired URL.
                var myHttpWebRequest1 = (HttpWebRequest)WebRequest.Create(uri);

                // Create an instance of the RequestState and assign the previous myHttpWebRequest1
                // object to it's request field.  
                var myRequestState = new RequestState();
                myRequestState.request = myHttpWebRequest1;

                // Start the asynchronous request.
                IAsyncResult result =
                  myHttpWebRequest1.BeginGetResponse(RespCallback, myRequestState);

                result.AsyncWaitHandle.WaitOne();

                for (int i = 0; i < 10000; i++)
                {

                }

            }
            catch (WebException e1)
            {
                //_urlHtml = "MZon-GetDataERROR" + e1.Message;
                //isCompleted = true;
            }
            catch (Exception e2)
            {
                //_urlHtml = "MZon-GetDataERROR" + e2.Message;
                //isCompleted = true;
            }
        }

        private void RespCallback(IAsyncResult asynchronousResult)
        {
            try
            {
                // State of request is asynchronous.
                RequestState myRequestState = (RequestState)asynchronousResult.AsyncState;
                HttpWebRequest myHttpWebRequest2 = myRequestState.request;
                myRequestState.response = (HttpWebResponse)myHttpWebRequest2.EndGetResponse(asynchronousResult);

                // Read the response into a Stream object.
                Stream responseStream = myRequestState.response.GetResponseStream();
                myRequestState.streamResponse = responseStream;

                StreamReader streamReader = new StreamReader(responseStream);
                string strOutputXml=streamReader.ReadToEnd();
                
                // Begin the Reading of the contents of the HTML page and print it to the console.
                //if (responseStream != null)
                //{
                //    IAsyncResult asynchronousInputRead = responseStream.BeginRead(myRequestState.BufferRead, 0,
                //                                                                  BUFFER_SIZE,
                //                                                                  new AsyncCallback(ReadCallBack),
                //                                                                  myRequestState);
                //}

                //responseStream.Read()

                // Console application output 
                //string strOutputXml = reader.ReadToEnd();
            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
                //isCompleted = true;
            }
        }

        //Read html callback
        private void ReadCallBack(IAsyncResult asyncResult)
        {
            try
            {
                RequestState myRequestState = (RequestState)asyncResult.AsyncState;
                Stream responseStream = myRequestState.streamResponse;
                int read = responseStream.EndRead(asyncResult);

                // Read the HTML page and then do something with it
                if (read > 0)
                {
                    myRequestState.requestData.Append(Encoding.UTF8.GetString(myRequestState.BufferRead, 0, read));
                    IAsyncResult asynchronousResult = responseStream.BeginRead(myRequestState.BufferRead, 0, BUFFER_SIZE,
                                                                               new AsyncCallback(ReadCallBack),
                                                                               myRequestState);
                }
                else
                {
                    if (myRequestState.requestData.Length > 1)
                    {
                        string stringContent;
                        stringContent = myRequestState.requestData.ToString();
                        //_urlHtml = stringContent;
                    }

                    responseStream.Close();
                    allDone.Set();
                    //isCompleted = true;
                }

            }
            catch (WebException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}