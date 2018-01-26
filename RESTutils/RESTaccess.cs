using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RESTutils
{
    public class RESTaccess
    {
        private string baseUrl;

        public RESTaccess(string _baseUrl)
        {
            baseUrl = _baseUrl;
        }

        public string getRESTData(string url)
        {

            // connect to the API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + url);
            try
            {
                WebResponse response = request.GetResponse();

                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException we)
            {
                // Something goes wrong, get the error response, then do something with it
                WebResponse err = we.Response;
                using (Stream responseStream = err.GetResponseStream())
                {
                    StreamReader r = new StreamReader(responseStream, Encoding.UTF8);
                    string errorText = r.ReadToEnd();
                    // display or log error
                    Console.WriteLine(errorText);
                }
                throw;
            }

        } // end getRESTData

    }
}
