using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabsV06.Extensions
{
    public static class RequestExtensions
    {
        public static bool IsAxaxRequest(this HttpRequest request)
        {
            return request.Headers["x-requested-with"]
                        .ToString().ToLower().Equals("xmlhttprequest");
        }
    }
}
