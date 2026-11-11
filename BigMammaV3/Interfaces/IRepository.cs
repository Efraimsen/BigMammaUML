using System;
using System.Collections.Generic;
using System.Text;

namespace BigMammaV3.Interfaces;

public interface IRepository<T>
{
    void Add(T entity);
    void Remove(int id);
    T Get(int id);
    bool Update(int id, T entity);
}
