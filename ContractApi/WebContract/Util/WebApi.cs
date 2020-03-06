using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebContract.Util
{
    public class WebApi
    {
        
        public static string RequestGET()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://localhost:5343/api/Contracts/v1.0");
            var response = (HttpWebResponse)request.GetResponse();
            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
            return responseString;
        }

    }
}
