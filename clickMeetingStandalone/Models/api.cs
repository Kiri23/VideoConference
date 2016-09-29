using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using System.IO;
using System.Text;
using System.Collections;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;

namespace clickMeetingStandalone.Models
{
    public class api
    {
        public String url_api = "https://api.clickmeeting.com/v1";
        private String api_key = "usf0dae1141344d638413f5f63edb8edf0ac368ddc";
        public List<Conferences> name { get; set; }
        public String content { get; set; }

        public void getConference(String status)
        {
            var client = new RestClient(url_api);

            var request = new RestRequest("conferences/"+ status, Method.GET);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("X-Api-Key", api_key);


            // IRestResponse response = client.Execute(request);


           

            // codigo de lassarie
             var response = client.Execute<MeetingRoom>(request);

            // codigo mio
            // content = response.Content;

            // verificar en donde esta mal el modelo 
            //var jsonresponse = JsonConvert.DeserializeObject<MeetingRoom>(content);


           // RestResponse<MeetingRoom> response2 = (RestResponse<MeetingRoom>)client.Execute<MeetingRoom>(request)
          // name = response2.Data.active_conferences; 
            //  MeetingRoom td = new JsonDeserializer().Deserialize<MeetingRoom>(response2);






            }


    }
}