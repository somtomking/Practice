using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Mvc5.Models
{
    public class IdAndName
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ProvinceModel : IdAndName
    {
        public ProvinceModel()
        {

        }
        public IList<CityModel> Cities { get; set; }
    }

    public class CityModel : IdAndName
    {

    }
}