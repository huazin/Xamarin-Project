﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net;

namespace GuideForDDOn.Date
{
    static public class WebService
    {
        static private string Url = "http://guideforddon.com/api";
        static private HttpClient client;
        static private string Controller;
        static private string Arguments;


        static public string Get(string control, string Argu)
        {
            Controller = control;
            Arguments = Argu;

            client = new HttpClient()
            {
                MaxResponseContentBufferSize = 256000
            };
            return GetRes().Result;
        }
        static private async Task<string> GetRes()
        {
            try
            {
                var uri = new Uri(string.Format(Url + "/" + Controller + "/" + Arguments, string.Empty));
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                var response = await client.GetAsync(uri).ConfigureAwait(continueOnCapturedContext: false);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    return content;
                }
                return string.Empty;
            }
            catch (Exception e)
            {
                return null;       
            }
        }
    }
}
