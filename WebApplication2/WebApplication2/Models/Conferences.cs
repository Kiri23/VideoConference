using System.Collections.Generic;

namespace clickMeetingStandalone.Models
{
    public class Conferences
    {

        public long id { get; set; }
        public string room_type { get; set; }
        public long room_pin { get; set; }
        public string name { get; set; }
        public string name_url { get; set; }
        public int access_type { get; set; } //faltaba una 's'
        public bool lobby_enabled { get; set; }
        public string lobby_description { get; set; }
        public int registration_enabled { get; set; }

        public string status { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public bool permanent_room { get; set; } 
        // hacer array de modelo acces_role_hashes
        public List<access_role_hashes> acces_role_hashes { get; set; }
        public string room_url { get; set; }
        public long phone_presenter_pin { get; set; }
        public long phone_listener_pin { get; set; }
        public string embed_room_url { get; set; }
        public string widgets_hash { get; set; } 
        //array de recorder_list cequiar con que viene cuando venga lleno
        public List<object> recorder_list { get; set; }
        public List<settings> settings { get; set; }
        public List<autologin_hashes> autologin_hashes { get; set; }
        public string autologin_hash { get; set; }
        public string start_at { get; set; }
        public string ends_at { get; set; }
        public string ccc { get; set; }







    }
}