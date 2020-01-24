using System.Timers;
using CodeBasement.NetCore.Common.Wrappers.Interfaces;

namespace CodeBasement.NetCore.Common.Wrappers
{
  public class TimerWrapper : ITimer
  {
    public event ElapsedEventHandler Elapsed
    {
      add => _timer.Elapsed += value;
      remove => _timer.Elapsed -= value;
    }

    private readonly Timer _timer;

    public TimerWrapper(double interval)
    {
      _timer = new Timer(interval);
    }

    public void Start()
    {
      _timer.Start();
    }

    public void Stop()
    {
      _timer.Stop();
    }
  }
}
