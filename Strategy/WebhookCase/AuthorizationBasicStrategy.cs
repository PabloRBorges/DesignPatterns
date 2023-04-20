using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Strategy.WebhookCase.Interface;

namespace Strategy.WebhookCase
{
    public class AuthorizationBasicStrategy
    {
    }
    public override Task<HttpResponseMessage> Sender(WebHookMessage<WebHookModelView> message, WebHookModelView webHook)
    {
        var httpRequest = new HttpRequestMessage();
        var webhook = message.Body;
        var textToEncode = $"{webhook.Authorization.Basic.User}:{webhook.Authorization.Basic.Password}";
        httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Basic", $"{textToEncode.Base64Encode()}");

        return Sender(message, webhook, httpRequest);
    }
}
