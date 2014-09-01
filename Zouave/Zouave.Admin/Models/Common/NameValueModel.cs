using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zouave.Admin.Models.Common
{
    public class NameValueModel : ViewModelBase
    {
        public virtual string Name { get; set; }
        public virtual dynamic Value { get; set; }
    }
}