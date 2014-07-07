using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Practice.WebAPI.MessageHandlers
{
    public class CustomMessageHandler : DelegatingHandler
    {
        protected override System.Threading.Tasks.Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, System.Threading.CancellationToken cancellationToken)
        {
            int matchHeaderCount = request.Headers.Count((item) =>
            {

                if ("key".Equals(item.Key))
                {

                    foreach (var str in item.Value)
                    {

                        if ("11234".Equals(str))
                        {

                            return true;

                        }

                    }

                }

                return false;

            });

            if (matchHeaderCount > 0)
            {

                return base.SendAsync(request, cancellationToken);

            }
            return Task.Factory.StartNew<HttpResponseMessage>(() =>
            {
                return new HttpResponseMessage(HttpStatusCode.Forbidden);
                return new HttpResponseMessage(HttpStatusCode.Forbidden) { Content = new StringContent("没有经过验证的消息", Encoding.UTF8, "text/html") };
            });
        }
    }
}