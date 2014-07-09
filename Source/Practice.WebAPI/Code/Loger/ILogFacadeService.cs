using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.WebAPI.Code.Loger
{
  public  interface ILogFacadeService
    {
        void AddServiceLog(string source, int code, string requestParameter, string responseResult);
        void AddErrorLog(string shortMessage, string fullMessage);
    }
}
