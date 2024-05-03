using System.ComponentModel;

namespace Chat.Utilities;

public static class EnvironmentAccessor
{
    public static T? GetVar<T>(string key)
    {
        var value = Environment.GetEnvironmentVariable(key);
        if (string.IsNullOrEmpty(value))
        {
            return default;
        }

        var converter = TypeDescriptor.GetConverter(typeof(T));
        if (converter == null)
        {
            return default;
        }

        try
        {
            return (T?)converter.ConvertFromString(value);
        }
        catch (System.Exception)
        {
            return default;
        }
    }
}
