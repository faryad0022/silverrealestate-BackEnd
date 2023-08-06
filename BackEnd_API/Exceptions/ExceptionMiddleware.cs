﻿using BackEnd_API.Const;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Net;
using System.Net.Mime;
using System.Text.Json;
using System.Threading.Tasks;

namespace BackEnd_API.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                var statusCode = httpContext.Response.StatusCode;
                if (ex is ArgumentException)
                {
                    statusCode = 200;
                }
                await HandleExceptionAsync(httpContext, statusCode, ex.Message);
            }
            finally
            {
                var statusCode = httpContext.Response.StatusCode;
                var msg = "";
                if (statusCode == 401)
                {
                    msg = "Unauthorize";
                }
                else if (statusCode == 404)
                {
                    msg = "NotFound";
                }
                else if (statusCode == 400)
                {
                    msg = "BadRequest";
                }
                else if (statusCode < 300)
                {
                    msg = "";
                }
                if (!string.IsNullOrWhiteSpace(msg))
                {
                    await HandleExceptionAsync(httpContext, statusCode, msg);
                }
            }
        }
        private static Task HandleExceptionAsync(HttpContext context, int statusCode, string msg)
        {
            var result = JsonConvert.SerializeObject(
                new ErrorDeatils()
                {
                    ErrorMessage = msg,
                    StatusCode = statusCode,
                    ErrorType = statusCode.ToString()
                });
            context.Response.ContentType = "application/json;charset=utf-8";
            context.Response.AddAppError(msg);
            return context.Response.WriteAsync(result);
        }
    }

    public class ErrorDeatils
    {
        public int StatusCode { get; set; }
        public string ErrorType { get; set; }
        public string ErrorMessage { get; set; }
    }
    public static class ErrorHandlingExtensions
    {
        public static IApplicationBuilder UseErrorHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }

}

