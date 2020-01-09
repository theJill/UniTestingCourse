using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using log4net;
using log4net.Config;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace FrameworkLab
{
    public static class Logger
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Logger));

        public static ILog Log
        {
            get { return log; }
        }

        public static void InitLogger()
        {
            var separateIndex = AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin", StringComparison.Ordinal);
            var logConfigPath = AppDomain.CurrentDomain.BaseDirectory.Substring(0, separateIndex) +
                             "ConfigFiles/log4net.config";
            var logConfigFile = new FileInfo(logConfigPath);

            //XmlConfigurator.Configure(logConfigFile);
        }
    }
}
