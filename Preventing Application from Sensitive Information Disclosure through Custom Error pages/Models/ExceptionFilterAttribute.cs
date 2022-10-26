using System.Web;
using System;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Web.Http.Filters;
using ExceptionFilterAttribute = System.Web.Http.Filters.ExceptionFilterAttribute;

namespace ErrorHandlingApp.Models
{
    public class NotImpExceptionFilterAttribute:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if(context.Exception != null)
            {
                var exception = context.Exception;
                var message = context.Exception.Message;
                var innerMessage = context.Exception.InnerException;
                var path = context.Request.RequestUri.AbsolutePath;
            }
        }
    }
}
