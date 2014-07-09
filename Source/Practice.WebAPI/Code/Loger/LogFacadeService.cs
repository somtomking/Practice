using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.WebAPI.Code.Loger
{
    public class LogFacadeService:ILogFacadeService
    {
        public void AddServiceLog(string source, int code, string requestParameter, string responseResult)
        {
             
        }

        public void AddErrorLog(string shortMessage, string fullMessage)
        {
            
        }
    }
}