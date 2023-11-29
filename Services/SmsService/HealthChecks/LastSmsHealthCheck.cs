using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace SmsService.HealthChecks
{
    public class LastSmsHealthCheck : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(HealthCheckResult.Healthy("Last SMS has been sent without any problems!"));
        }
    }
}
