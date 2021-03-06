﻿using System;

namespace CodeBasement.NetCore.Common.Logging
{
  public interface ILoggerAdapter<T>
  {
    void LogTrace(string message, params object[] args);
    void LogInformation(string message, params object[] args);
    void LogError(Exception ex, string message, params object[] args);
  }
}