using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Account:BaseEntity<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        [Unique]
        public string Phone { get; set; }

        [Unique]
        public string Email { get; set; }


        public string Login
        {
            get
            {
                return this.Email;
            }
            protected set { }
        }
        public bool AccountStatus { get; set; }

        public Account()
        { }
        public Account(string firstname, string lastname, string password, string phone, string email, bool status)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Password = password;
            this.Phone = phone;
            this.Email = email;
            this.AccountStatus = status;
        }
    }
}
