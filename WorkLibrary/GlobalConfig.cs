﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WorkLibrary
{
    public static class GlobalConfig
    {
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
        public static string FullFilePath(this string fileName)
        {
            return $@"{ ConfigurationManager.AppSettings["filePath"] }\{fileName}";
        }
    }
}
