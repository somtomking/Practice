using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Mvc5.Models
{
    public class MvcModel
    {
        public class Contact
        {
            public string Name { get; set; }
            public string PhoneNo { get; set; }
            public string Email { get; set; }

        }
        public class Address
        {
            public string Province { get; set; }
        }
    }
}