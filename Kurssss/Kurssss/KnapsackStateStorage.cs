using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

/// <summary>
/// Класс-Хранилище
/// </summary>
public class KnapsackStateStorage
{


    private List<KnapsackState> _storage;
    public KnapsackStateStorage()
    {
        _storage = new List<KnapsackState>();
    }

    public void AddState(KnapsackState state)
    {
        if (state == null)
        {
            return;
        }
        if (_storage.Count > 0 && _storage.Last().Equals(state))
        {
            _storage.RemoveAt(_storage.Count - 1);
        }
        _storage.Add(state);
    }

    public KnapsackState GetState(int index)
    {
        if (_storage[index] == null || index < 0)
        {
            throw new IndexOutOfRangeException();
        }
        return _storage[index];
    }

    public int GetStorageLenght()
    {
        return _storage.Count;
    }
}
