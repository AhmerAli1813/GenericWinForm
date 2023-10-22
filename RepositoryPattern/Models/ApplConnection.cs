using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Models
{
    public static class ApplConnection
    {
        public static string Connection => ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
    }
}
