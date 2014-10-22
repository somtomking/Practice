using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.EF.CodeFirst
{
    public class ATable
    {
        public int Id { get; set; }
        public string Name { get; set; }
         
        public virtual BTable B { get; set; }
    }

    public class BTable
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
