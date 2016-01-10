﻿using Newtonsoft.Json;

namespace Campr.Server.Lib.Helpers
{
    public interface IJsonHelpers
    {
        string ToJsonString(object obj);
        string ToJsonStringUnescaped(object obj);
        T FromJsonString<T>(string src);
        T TryFromJsonString<T>(string src);
        
        JsonSerializer GetSerializer();
    }
}