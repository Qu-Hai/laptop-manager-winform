using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer_DTO
    {
        private string _id;
        private string _last_name;
        private string _firt_name;
        private string _city;
        private string _gender;
        private string _date_of_birth;
        private string _phone_number;
        private string _email;
        private bool _state;

        public string Id { get => _id; set => _id = value; }
        public string Last_name { get => _last_name; set => _last_name = value; }
        public string Firt_name { get => _firt_name; set => _firt_name = value; }
        public string City { get => _city; set => _city = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Date_of_birth { get => _date_of_birth; set => _date_of_birth = value; }
        public string Phone_number { get => _phone_number; set => _phone_number = value; }
        public string Email { get => _email; set => _email = value; }
        public bool State { get => _state; set => _state = value; }
    }
}
