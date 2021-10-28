using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    public static class UsefulMethods
    {
        public static string getConnectionString(string connectionName)
        {
            string output = string.Empty;
            var builder = new ConfigurationBuilder()
                .SetBasePath(@"C:\\C#\\Desktop\\Mail\\Mail")
                .AddJsonFile("appconfig.json");
            var config = builder.Build();
            output = config.GetConnectionString(connectionName);
            return output;
        }
    }
}
