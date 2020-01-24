using CodeBasement.NetCore.Common.Helpers.Interfaces;
using Newtonsoft.Json;

namespace CodeBasement.NetCore.Common.Helpers
{
  public class JsonHelper : IJsonHelper
  {
    public string SerializeObject(object value)
    {
      return SerializeObject(value, false);
    }

    public string SerializeObject(object value, bool formatted)
    {
      return formatted
        ? JsonConvert.SerializeObject(value, Formatting.Indented)
        : JsonConvert.SerializeObject(value);
    }

    public T DeserializeObject<T>(string value)
    {
      return JsonConvert.DeserializeObject<T>(value);
    }
  }
}
