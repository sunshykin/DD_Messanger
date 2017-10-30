using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using NLog;

namespace ChatterBox.Api
{
    public class ControllerHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var Log = LogManager.GetCurrentClassLogger();
            Log.Debug("Запрос пришел на сервер.");
            var response = await base.SendAsync(request, cancellationToken);
            if (response.IsSuccessStatusCode)
                Log.Debug("Ответ ушел клиенту.");
            else
                Log.Error($"Ошибка \'{response.ReasonPhrase}\' - \"{response.Content.ReadAsStringAsync().Result}\"");
            return response;
        }
    }
}