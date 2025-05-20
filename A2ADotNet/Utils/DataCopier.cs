using System;
using Newtonsoft.Json;

namespace A2ADotNet.Utils
{
    internal static class DataCopier
    {
        internal static T Copy<T>(T source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source), "Source object cannot be null.");
            }
            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source));
        }
    }
}
