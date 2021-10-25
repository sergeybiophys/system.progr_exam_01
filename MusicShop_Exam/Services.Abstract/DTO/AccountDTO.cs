using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract.DTO
{
    public class AccountDTO
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }

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

    }
}

