using System;
using Microsoft.Extensions.Logging;

namespace CodeBasement.NetCore.Common.Logging
{
  public class LoggerAdapter<T> : ILoggerAdapter<T>
  {
    private readonly ILogger<T> _logger;

    public LoggerAdapter(ILogger<T> logger)
    {
      _logger = logger;
    }

    public void LogTrace(string message, params object[] args)
    {
      _logger.LogTrace(message, args);
    }

    public void LogInformation(string message, params object[] args)
    {
      _logger.LogInformation(message, args);
    }

    public void LogError(Exception ex, string message, params object[] args)
    {
      _logger.LogError(ex, message, args);
    }
  }
}
