﻿using WebApplication2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string html = string.Empty;
            string url = @"https://api.stackexchange.com/2.2/answers?order=desc&sort=activity&site=stackoverflow";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;


            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            return View();
            // return Content(html);

        }
        
        // Estes el Action que funciona y me da un response en formato JSON pero cuando lo deserializo no me lo adjusta al modelo. 
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var jspn = "";
            var jsn = " ";
             
            const string WEBSERVICE_URL = "https://api.clickmeeting.com/v1/conferences/active";
            try
            {
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                if (webRequest != null)
                {
                    webRequest.Method = "GET";
                    webRequest.Timeout = 20000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("X-Api-Key", "usf0dae1141344d638413f5f63edb8edf0ac368ddc");

                   
                    
                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();
                              
                            Console.WriteLine(String.Format("Response: {0}", jsonResponse));
                            jspn += String.Format("Response: {0}", jsonResponse);
                            jsn += jsonResponse;
                             // esta Linea es la que no me funciona no hace el deserialize bien. si lo corres en 
                             // debug Mode la variable jsonresponse contiene un objeto nullo de MeetingRoom 
                             
                            var jsonresponse = JsonConvert.DeserializeObject<List<RootObjectResponse>>(jsonResponse);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            return Content(jsn);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
