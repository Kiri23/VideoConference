using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class AccessRoleHashes
    {
        public string listener { get; set; }
        public string presenter { get; set; }
        public string host { get; set; }
    }

    public class Settings
    {
        public bool show_on_personal_page { get; set; }
        public bool thank_you_emails_enabled { get; set; }
        public bool connection_tester_enabled { get; set; }
        public bool recorder_autostart_enabled { get; set; }
        public bool room_invite_button_enabled { get; set; }
        public bool social_media_sharing_enabled { get; set; }
        public bool connection_status_enabled { get; set; }
    }

    public class AutologinHashes
    {
        public string host { get; set; }
    }

    public class RootObjectResponse
    {
        public int id { get; set; }
        public string room_type { get; set; }
        public int room_pin { get; set; }
        public string name { get; set; }
        public string name_url { get; set; }
        public int access_type { get; set; }
        public bool lobby_enabled { get; set; }
        public string lobby_description { get; set; }
        public int registration_enabled { get; set; }
        public string status { get; set; }
        public string timezone { get; set; }
        public int timezone_offset { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public bool permanent_room { get; set; }
        public AccessRoleHashes access_role_hashes { get; set; }
        public string room_url { get; set; }
        public int phone_presenter_pin { get; set; }
        public int phone_listener_pin { get; set; }
        public string embed_room_url { get; set; }
        public string widgets_hash { get; set; }
        public List<object> recorder_list { get; set; }
        public Settings settings { get; set; }
        public AutologinHashes autologin_hashes { get; set; }
        public string autologin_hash { get; set; }
    }
}