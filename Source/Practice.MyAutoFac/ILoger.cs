using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.MyAutoFac
{
    public interface ILoger
    {
        void Debug(string msg);

    }

    public interface INullObj { }

    public sealed class NullLoger : ILoger, INullObj
    {

        public void Debug(string msg)
        {
            Console.WriteLine(this.GetType().FullName + "" + msg);
        }


    }


    public class DefaultLoger : ILoger
    {
        public void Debug(string msg)
        {
            Console.WriteLine(this.GetType().FullName + "" + msg);
        }


    }

}
