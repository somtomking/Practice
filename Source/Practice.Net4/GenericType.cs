using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Net4
{
    class GenericType
    {
        static void Main(string[] args)
        {
            G g = new G();
            
        }
    }

    public class Generic007<G> where G : Generic007<G>
    {

        public void Save()
        {

        }
    }

    public class G : Generic007<G>
    {
        public string Name { get; set; }

    }
}
