using System;
using System.Configuration;

namespace Utils.Wrappers
{
    public class ConfigurationWrapper
    {
        public virtual T GetSettingValue<T>(string key)
        {
            try
            {
                var value = ConfigurationManager.AppSettings[key];
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }

        public virtual string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
