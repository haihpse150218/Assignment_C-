using System;
using System.ComponentModel.DataAnnotations;

namespace BusinessObject
{
    public class MemberObject
    {
        public int id { get; set; }
        [Required()]
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string city { get; set; }
        public string country {get; set;}
    }
}
