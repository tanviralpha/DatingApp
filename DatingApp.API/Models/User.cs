using System;
using System.Collections.Generic;

namespace DatingApp.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string  Gender { get; set; }
        public DateTime DOB { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string NomineeName { get; set; }
        public string NID { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public ICollection<Photo> Photos { get; set; }


    }
}