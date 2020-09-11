﻿using System;
namespace commercetools.Api.Serialization
{
    public interface ISerializerService
    {
        string Serialize<T>(T input);

        T Deserialize<T>(string input);
    }
}
