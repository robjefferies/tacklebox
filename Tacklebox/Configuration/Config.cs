using System;
using System.Configuration;
using Tacklebox.Extensions;

namespace Tacklebox.Configuration
{
    public class Config
    {
        public static string Get(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }

        public static int GetInt32(string key)
        {
            return Get(key).ToInt32();
        }

        public static DateTime GetDateTime(string key)
        {
            return Get(key).ToDateTime();
        }

        public static bool GetBoolean(string key)
        {
            return Get(key).ToBool();
        }

    }
}