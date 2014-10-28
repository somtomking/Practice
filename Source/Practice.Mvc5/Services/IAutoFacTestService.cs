using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Mvc5.Services
{
    public interface IAutoFacTestService
    {
        int Do();
    }

    public class AutoFacTestService : IAutoFacTestService
    {
        public AutoFacTestService()
        {

        }
        private int Count = 0;
        public int Do()
        {
            Count++;
            return Count;
        }
    }
}
