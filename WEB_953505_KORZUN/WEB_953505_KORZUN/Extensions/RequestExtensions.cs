﻿using System;
using Microsoft.AspNetCore.Http;

namespace WEB_953505_KORZUN.Extensions
{
    public static class RequestExtensions
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            return request.Headers["x-requested-with"].Equals("XMLHttpRequest");
        }
    }
}
