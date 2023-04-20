using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.WebhookCase.Interface
{
    public interface IAuthorizationStrategy
    {
        Task<HttpResponseMessage> Sender(object message, object webHook);
    }
}
