using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace ApplicationInsightsSample.Console
{
    public interface IMyService
    {
        void WriteSomethingToLog();
    }

    public class MyService : IMyService
    {
        private readonly ILogger<MyService> _logger;

        public MyService(ILogger<MyService> logger)
        {
            _logger = logger;
        }

        public void WriteSomethingToLog()
        {
            _logger.LogInformation("This is a test info log statement.");
        }
    }
}
