using Strategy.WebhookCase.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strategy.WebhookCase
{
    public class AuthorizationContext
    {
        private IAuthorizationStrategy _authorizationStrategy;
        protected static readonly HttpClient _client = new HttpClient();

        public AuthorizationContext()
        {
        }

        public void SetAuthorizationContext(IAuthorizationStrategy authorizationStrategy)
        {
            _authorizationStrategy = authorizationStrategy;
        }


        protected virtual async Task<HttpResponseMessage> Sender(WebHookMessage<WebHookModelView> message, WebHookModelView webHook, HttpRequestMessage httpRequest)
        {
            _client.DefaultRequestHeaders.Clear();

            SetHttpMethod(httpRequest, message, webHook);

            httpRequest.RequestHeaders(webHook.Headers);

            return await _client.SendAsync(httpRequest, CancellationToken.None);

        }

        private void SetHttpMethod(HttpRequestMessage httpRequest, WebHookMessage<WebHookModelView> message, WebHookModelView webHook)
        {
            var webhookContent = GetWebhookContent(message, webHook);

            httpRequest.Method = webHook.Method.ToHttpMethod();



            if (webHook.Method == Method.Get || webHook.Method == Method.Head)
                httpRequest.RequestUri = new Uri(webHook.Url + (webHook.Url.IndexOf('?') < 0 ? '?' : '&') + webhookContent);
            else
            {
                httpRequest.Content = new StringContent(webhookContent);
                httpRequest.RequestUri = new Uri(webHook.Url);
            }
        }

        private string GetWebhookContent(WebHookMessage<WebHookModelView> message, WebHookModelView webHook)
        {
            var webhookContent = webHook.Payload;

            //check if is a event webhook
            if (
                webhookContent.Contains("JourneyId", StringComparison.CurrentCultureIgnoreCase) &&
                webhookContent.Contains("EventType", StringComparison.CurrentCultureIgnoreCase) &&
                Utils.TenantIsProxyEvent(message.Header.TenantId)
               )
            {
                webhookContent = Parse.ParseEventFromJourneyToAppD1(webHook.Payload);
            }

            return webhookContent;
        }
    }
}
