using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace curso.web.mvc.Handles
{
    public class BearerTokenMessageHandler : DelegatingHandler
    {
        private readonly IHttpContextAccessor httpContextAccessor;

        public BearerTokenMessageHandler(IHttpContextAccessor _httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancelToken)
        {
            if (request?.Headers?.Authorization != null)
            {
                var token = _httpContextAccessor.HttpContext.User.FindFirst("token").Value;
                request.Headers.Authorization = new AuthenticationHeaderValue(request.Headers.Authorization.Scheme,token);
            }

            return await base.SendAsync(request, cancelToken);
        }
    }
}
