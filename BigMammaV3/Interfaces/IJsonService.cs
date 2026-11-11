using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaV3.Interfaces;

public interface IJsonService
{
    T? Read<T>(string filepath);
    void Write<T>(string filepath, T data);
}
