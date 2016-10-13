using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using System.Web.UI;

namespace WebApplication2.Controllers
{
    public class ConferencesController : Controller
    {

        List<RootObjectResponse> re  = new List<RootObjectResponse>();

        RootObjectResponse res = new RootObjectResponse();


        // GET: Conferences
        public ActionResult Index()
        {
            ViewBag.Message = "Your application description page.";
            var sjs1 = "";
            var sjs2 = " ";
            var sjs = " ";
           // List<RootObjectResponse> responsePost  = postCall();

            List<RootObjectResponse> response = new List<RootObjectResponse>();

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
                            
                            // esta Linea es la que no me funciona no hace el deserialize bien. si lo corres en 
                            // debug Mode la variable jsonresponse contiene un objeto nullo de MeetingRoom 

                            var jsonresponse = JsonConvert.DeserializeObject<List<RootObjectResponse>>(jsonResponse);
                            response = jsonresponse;

                            res = response[0];


                            sjs = response[1].name + "\n";
                            sjs1 = response[2].name;
                            sjs2 = response[3].name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());


            }

            

            return View(res);

           //  return Content("Conferencia 2 name--  " + sjs + "\n -------" + 
           //                "Conferencia 3 name-- " + sjs1 + "\n --------" + 
           //                "Conferencia 4 Ultima name -- " + sjs2 + " \n---------" + 
           //                "Conferencia 1 name del Post-- " + response[0].name + "\n"  
                
             //   );

        }


        [HttpPost]
        public ActionResult createConference(string firstname , string lastname)
        {
            postCall(firstname, "webinar", "false", "1");
            return RedirectToAction("Index");
        }


        public List<RootObjectResponse> postCall(string name_re, string room_type_re,string permanent_room_re,string acces_type_re )
        {

            string name = "name="+ name_re + "&";
            string room_type = "room_type="+room_type_re + "&";
            string permanent_room = "permanent_room="+ permanent_room_re + "&";
            string acces_type = "access_type="+acces_type_re ;
            // this is the final url that attached all together in one String 
            string post_url = name + room_type + permanent_room + acces_type ;

            List<RootObjectResponse> response = new List<RootObjectResponse>();


            const string WEBSERVICE_URL = "https://api.clickmeeting.com/v1/conferences?";
            //TODO: Chequiar si se spuede hacer haceer con otra estructura de datos en el que a un objeto le concatene toda la String 
            // Como en Java que se ultiliza el String Builder //TODO: Buscar Ejemplos de C# de StringBuilder ejemplos en dotnetPerls
            string webservice_Post_Url = WEBSERVICE_URL + post_url;

           //  const string WEBSERVICE_URL = "https://api.clickmeeting.com/v1/conferences?name=Csharp5&room_type=webinar&permanent_room=false&access_type=1";
            try
            {
                var webRequest = System.Net.WebRequest.Create(webservice_Post_Url);
                if (webRequest != null)
                {
                    webRequest.Method = "POST";
                    webRequest.Timeout = 20000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("X-Api-Key", "usf0dae1141344d638413f5f63edb8edf0ac368ddc");



                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();

                            Console.WriteLine(String.Format("Response: {0}", jsonResponse));

                            // esta Linea es la que no me funciona no hace el deserialize bien. si lo corres en 
                            // debug Mode la variable jsonresponse contiene un objeto nullo de MeetingRoom 

                            var jsonresponse = JsonConvert.DeserializeObject<List<RootObjectResponse>>(jsonResponse);
                            response = jsonresponse;

                         //   sjs = response[0].name;
                         //   sjs1 = response[1].name;
                         //   sjs2 = response[2].name;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return response;

        }







        public void addParam()
        {
            const string WEBSERVICE_URL = "https://api.clickmeeting.com/v1/conferences?";

            string data = "name=testCsharp&room_type=webinnar&permanent_room=false&acces_type=1";
            byte[] dataStream = Encoding.UTF8.GetBytes(data);

            var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);

            webRequest.Method = "POST";

            webRequest.Timeout = 20000;
            webRequest.Headers.Add("X-Api-Key", "usf0dae1141344d638413f5f63edb8edf0ac368ddc");
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = dataStream.Length;
            Stream newStream = webRequest.GetRequestStream();
            //send the data 
            newStream.Write(dataStream, 0, dataStream.Length);
            newStream.Close();
            WebResponse webResponse = webRequest.GetResponse();
        }



        

        // Hacer uno con param para pasarle los parametros a la web direccion
        public List<RootObjectResponse> callApi(string method)
        {

            List<RootObjectResponse> response = new List<RootObjectResponse>();



            const string WEBSERVICE_URL = "https://api.clickmeeting.com/v1/conferences/";
            try
            {
                var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
                if (webRequest != null)
                {
                    webRequest.Method = method;
                    webRequest.Timeout = 20000;
                    webRequest.ContentType = "application/json";
                    webRequest.Headers.Add("X-Api-Key", "usf0dae1141344d638413f5f63edb8edf0ac368ddc");



                    using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
                    {
                        using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
                        {
                            var jsonResponse = sr.ReadToEnd();

                            Console.WriteLine(String.Format("Response: {0}", jsonResponse));

                            // esta Linea es la que no me funciona no hace el deserialize bien. si lo corres en 
                            // debug Mode la variable jsonresponse contiene un objeto nullo de MeetingRoom 

                            response = JsonConvert.DeserializeObject<List<RootObjectResponse>>(jsonResponse);

                            // re = response;


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return response;

        }


        public List<RootObjectResponse> getConferences()
        {

            List<RootObjectResponse> response = new List<RootObjectResponse>();



            const string WEBSERVICE_URL = "https://api.clickmeeting.com/v1/conferences/inactive";
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

                            // esta Linea es la que no me funciona no hace el deserialize bien. si lo corres en 
                            // debug Mode la variable jsonresponse contiene un objeto nullo de MeetingRoom 

                            response = JsonConvert.DeserializeObject<List<RootObjectResponse>>(jsonResponse);

                            // re = response;


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return response;

        }




    }



    


}