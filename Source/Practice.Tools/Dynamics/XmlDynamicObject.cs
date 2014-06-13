using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Tools.Dynamics
{
    public class XmlDynamicObject : DynamicObject
    {
        public XmlDynamicObject()
        {
            
            
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            return base.TryGetMember(binder, out result);
        }
        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            return base.TrySetMember(binder, value);
        }
    }
}
