using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApplication.Tools
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value) where T : class
        {
            if (value == null)
            {
                session.Remove(key);
                return;
            }

            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T Get<T>(this ISession session, string key) where T : class
        {
            if (!session.Keys.Contains(key))
                return null;

            string value = session.GetString(key);

            if (String.IsNullOrEmpty(value))
                return null;

            return JsonSerializer.Deserialize<T>(value);
        }
    }
}
