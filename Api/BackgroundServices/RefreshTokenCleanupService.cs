using GearForgeXI.Services;

namespace GearForgeXI.BackgroundServices;

public class RefreshTokenCleanupService : BackgroundService
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<RefreshTokenCleanupService> _logger;
    private readonly TimeSpan _cleanupInterval = TimeSpan.FromHours(24); // Run daily

    public RefreshTokenCleanupService(
        IServiceProvider serviceProvider,
        ILogger<RefreshTokenCleanupService> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = _serviceProvider.CreateScope();
                var refreshTokenService = scope.ServiceProvider.GetRequiredService<RefreshTokenService>();

                await refreshTokenService.CleanupExpiredTokensAsync();
                _logger.LogInformation("Expired refresh tokens cleanup completed at {Time}", DateTime.UtcNow);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred during refresh token cleanup");
            }

            await Task.Delay(_cleanupInterval, stoppingToken);
        }
    }
}
