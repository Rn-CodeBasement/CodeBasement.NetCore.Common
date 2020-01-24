using System.Timers;

namespace CodeBasement.NetCore.Common.Wrappers.Interfaces
{
  public interface ITimer
  {
    event ElapsedEventHandler Elapsed;

    void Start();
    void Stop();
  }
}
