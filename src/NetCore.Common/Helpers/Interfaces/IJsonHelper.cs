namespace CodeBasement.NetCore.Common.Helpers.Interfaces
{
  public interface IJsonHelper
  {
    T DeserializeObject<T>(string value);
    string SerializeObject(object value);
    string SerializeObject(object value, bool formatted);
  }
}
