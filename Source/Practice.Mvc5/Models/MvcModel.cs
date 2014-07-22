using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice.Mvc5.Models
{
    public class MvcModel
    {
        public class Contact
        {
            [DataType(DataType.Text)]
            public string Name { get; set; }
            [DataType(DataType.PhoneNumber)]
            public string PhoneNo { get; set; }
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }

        }
        public class Address
        {
            public string Province { get; set; }
        }
    }
}