using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DatabaseService.HealthChecks
{
    public class ConsistencyHealthCheck : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            var isHealthy = await IsDbCostintentAsync();
            return isHealthy
                ? HealthCheckResult.Healthy("Database consistency is OK!")
                : HealthCheckResult.Unhealthy("Database consistency is BAD!");
        }
        private Task<bool> IsDbCostintentAsync()
        {
            return Task.FromResult(true);
        }

    }
}
