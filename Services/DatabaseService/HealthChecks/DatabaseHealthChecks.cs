using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DatabaseService.HealthChecks
{
    public class DatabaseHealthChecks : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            bool isHealthy = await IsDatabaseConnectionOkAsync();
            return isHealthy 
                ? HealthCheckResult.Healthy("Database connection is OK!") 
                : HealthCheckResult.Unhealthy("Database connection is BAD!");
        }
        private Task<bool> IsDatabaseConnectionOkAsync()
        {
            return Task.FromResult(DateTime.Now.Microsecond % 2 == 0);
        }
    }
}
