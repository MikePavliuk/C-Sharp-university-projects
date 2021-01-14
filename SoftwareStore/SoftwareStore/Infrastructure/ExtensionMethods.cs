using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoftwareStore.Controllers;

namespace SoftwareStore.Infrastructure
{
    public static class ExtensionMethods
    {
        public static string EmailConfirmationLink(this IUrlHelper urlHelper, string userId, string code, string scheme)
        {
            return urlHelper.Action(
                action: nameof(AccountController.ConfirmEmail),
                controller: "Account",
                values: new { userId, code },
                protocol: scheme);
        }

        public static string CutController(this string str)
        {
            return str.Replace("Controller", "");
        }

        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                ?.GetName();
        }

        public static string TruncateHtmlString(this string str, int maxLength)
        {
            string step1 = string.IsNullOrEmpty(str) ? "" : str.Replace(@"&nbsp;", " ");
            string step2 = Regex.Replace(step1, @"(<[^>]*>)|(&[^;]+?;)", string.Empty);
            if (step2.Length >= maxLength)
            {
                step2 = step2.Substring(0, maxLength) + "...";
            }
            return step2;
        }

        #region HttpContext
        public const string NullIPv6 = "::1";

        public static bool IsLocal(this ConnectionInfo conn)
        {
            if (!conn.RemoteIpAddress.IsSet())
                return true;

            if (conn.LocalIpAddress.IsSet())
                return conn.RemoteIpAddress.Equals(conn.LocalIpAddress);

            return conn.RemoteIpAddress.IsLoopback();
        }

        public static bool IsLocal(this HttpContext ctx)
        {
            return ctx.Connection.IsLocal();
        }

        public static bool IsLocal(this HttpRequest req)
        {
            return req.HttpContext.IsLocal();
        }

        public static bool IsSet(this IPAddress address)
        {
            return address != null && address.ToString() != NullIPv6;
        }

        public static bool IsLoopback(this IPAddress address)
        {
            return IPAddress.IsLoopback(address);
        }

        public static string PathAndQuery(this HttpRequest request) => request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();

        /// <summary>
        /// Метод создания объекта Uri с текущего запроса. Также можно контролировать, какую часть Uri отдать.
        /// </summary>
        /// <param name="request">Текущий объект запроса.</param>
        /// <param name="addPort">Добавить в URI port?</param>
        /// <param name="addPath">Добавить в URI Path?</param>
        /// <param name="addQuery">Добавить в URI QueryString?</param>
        /// <returns>
        /// Метод возвращает объект Uri
        /// </returns>
        public static Uri GetUri(this HttpRequest request, bool addPort = false, bool addPath = true, bool addQuery = true)
        {
            var uriBuilder = new UriBuilder
            {
                Scheme = request.Scheme,
                Host = request.Host.Host,
                Port = addPort ? request.Host.Port.GetValueOrDefault(80) : -1,
                Path = addPath ? request.Path.ToString() : default(string),
                Query = addQuery ? request.QueryString.ToString() : default(string)
            };

            //для localhost принудительно указываем порт вопреки параметрам
            if (request.IsLocal())
                uriBuilder.Port = request.Host.Port.GetValueOrDefault(80);

            return uriBuilder.Uri;
        }
        //
        //
        /// <summary>
        /// Формирует строку на основе объекта Uri, которая содержит только Scheme_Host_Port (без хвостового слеша)
        /// </summary>
        /// <param name="uri">Объект Uri.</param>
        /// <returns>
        /// Метод возвращает значение типа string
        /// </returns>
        public static string GetHostWithNoSlash(this Uri uri)
        {
            return uri.GetComponents(UriComponents.SchemeAndServer, UriFormat.UriEscaped);
        }
        #endregion
    }
}
