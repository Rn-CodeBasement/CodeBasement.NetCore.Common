using CodeBasement.NetCore.Common.Wrappers.Interfaces;

namespace CodeBasement.NetCore.Common.Factories.Interfaces
{
  public interface ITimerFactory
  {
    ITimer CreateTimer(double interval);
  }
}
