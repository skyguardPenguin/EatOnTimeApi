using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace EatOnTimeApi.App_Start
{
    public class Cors : Attribute, ICorsPolicyProvider
    {
        public async Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var corsRequestContext = request.GetCorsRequestContext();
            var originRequested = corsRequestContext.Origin;

            if (await IsOriginFromCustomer(originRequested))
            {
                var policy = new CorsPolicy
                {
                    AllowAnyHeader = true,
                    AllowAnyMethod = true,
                    AllowAnyOrigin = true
                };

                policy.Origins.Add(originRequested);
                policy.Origins.Add("*");

                //IP ESPECIFICA
                //policy.Origins.Add("https://cors-test.codehappy.dev/");
                return policy;
            }
            return null;
        }

        private async Task<bool> IsOriginFromCustomer(string originRequested)
        {
            return true;
        }
    }
}