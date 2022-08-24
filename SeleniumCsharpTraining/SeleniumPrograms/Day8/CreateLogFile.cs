using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using log4net.Config;

namespace SeleniumCsharpTraining.SeleniumPrograms.Day8
{
    internal class CreateLogFile
    {
        private static readonly ILog logger =
        LogManager.GetLogger(typeof(CreateLogFile));

        static CreateLogFile()
        {
            XmlConfigurator.Configure();
            
        }

        static void Main(string[] args)
        {
            logger.Debug("Here is a debug log.");
            logger.Info("... and an Info log.");
            logger.Warn("... and a warning.");
            logger.Error("... and an error.");
            logger.Fatal("... and a fatal error.");
            Console.Read();
        }
    }
}
