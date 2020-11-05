using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Data.Entities
{
    public class AppUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public List<Cart> Carts { set; get; }
    }
}
