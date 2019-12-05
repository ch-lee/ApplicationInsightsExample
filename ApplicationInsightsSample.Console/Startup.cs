using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.ApplicationInsights;

namespace ApplicationInsightsSample.Console
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // register services.
            services.AddTransient<IMyService, MyService>();

            // configure app insights for logging
            services.AddLogging(builder =>
            {
                builder.AddApplicationInsights("insert-insights-key-here");
                builder.AddFilter<ApplicationInsightsLoggerProvider>("", LogLevel.Information);
                builder.AddFilter<ApplicationInsightsLoggerProvider>("Microsoft", LogLevel.Error);
            });


            // Add telemetry
            services.AddApplicationInsightsTelemetryWorkerService();
        }
    }
}
