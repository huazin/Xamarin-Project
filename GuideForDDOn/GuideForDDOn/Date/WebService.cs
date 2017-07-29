using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace GuideForDDOn.Date
{
    static public class WebService
    {
        static private string Url = "http://wsddon.us-east-2.elasticbeanstalk.com/api/";
        static private HttpClient client;
        static private string Controller;
        static private string Arguments;
        static private string Resultado;


        static public string Get(string control, string Argu)
        {
            Controller = control;
            Arguments = Argu;

            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;

            string resul = GetRes().Result;
            return resul;
        }
        static private async Task<string> GetRes()
        {
            var uri = new Uri(string.Format(Url + "/" + Controller + "/" + Arguments, string.Empty));
            var response = await client.GetAsync(uri).ConfigureAwait(continueOnCapturedContext: false);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return content;
            }
            return string.Empty;
        }
    }
}
