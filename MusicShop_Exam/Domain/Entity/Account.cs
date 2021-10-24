using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Account
    {
        [Unique]
        public string Login { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public bool Status { get; set; }

        public Account() { }

        public Account(string login, string pass,
            string phone, string email, bool status)
        {
            this.Login = login;
            this.Password = pass;
            this.Phone = phone;
            this.Email = email;
            this.Status = status;
        }
    }
}
