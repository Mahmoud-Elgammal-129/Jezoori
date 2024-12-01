using Serilog;

namespace Jezoori.Extensions
{
    public static class SerilogExtension
    {
        public static void SerilogConfiguration(this WebApplicationBuilder builder)
        {
            // Make the LogConfigration.json file optional
            builder.Configuration.AddJsonFile("LogConfigration.json", optional: true, reloadOnChange: true);

            var logger = new LoggerConfiguration()
                                .ReadFrom.Configuration(builder.Configuration)
                                .CreateLogger();
            try
            {
                builder.Logging.AddSerilog(logger);
                logger.Information("Application Starting");

            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "The application failed to start");
                logger.Error(ex, "Exception occurred: {Message}", ex.Message);
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
    }
}
