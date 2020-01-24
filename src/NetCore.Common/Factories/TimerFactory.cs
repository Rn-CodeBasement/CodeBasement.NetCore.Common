using CodeBasement.NetCore.Common.Factories.Interfaces;
using CodeBasement.NetCore.Common.Wrappers;
using CodeBasement.NetCore.Common.Wrappers.Interfaces;

namespace CodeBasement.NetCore.Common.Factories
{
  public class TimerFactory : ITimerFactory
  {
    public ITimer CreateTimer(double interval)
    {
      return new TimerWrapper(interval);
    }
  }
}
