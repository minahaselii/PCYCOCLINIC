using System;
namespace PsycoClinic.Domain.Entities.User
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }

        public string Token { get; set; }
        public DateTime tokenExp { get; set; }
        public string Education { get; set; }

        //0:user
        //1:Doctor
        //2:Admin
        public byte UserType { get; set; }
    }
}

