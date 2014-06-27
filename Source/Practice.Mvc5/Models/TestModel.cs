using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace Practice.Mvc5.Models
{
    public class TestModel
    {
        [DisplayName("名称")]
        
        public string Name { get; set; }
        [DisplayName("数量")]
        public int Quantity { get; set; }
        [DisplayName("价格")]
        public decimal Price { get; set; }
        [DisplayName("是否激活")]
        public bool IsActive { get; set; }
        [DisplayName("描述")]
        public string Desc { get; set; }
    }
}