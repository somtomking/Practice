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
            [Display(Name = "姓名")]
            [DataType(DataType.Text)]
            public string Name { get; set; }
            [Display(Name = "电话")]
            [DataType(DataType.PhoneNumber)]
            public string PhoneNo { get; set; }
            [Display(Name = "邮件")]
            [DataType(DataType.EmailAddress)]
            public string Email { get; set; }
            [Display(Name = "地址")]
            public Address Address { get; set; }

        }
        public class Address
        {
            [Display(Name = "省")]
            public string Province { get; set; }
        }
    }
}