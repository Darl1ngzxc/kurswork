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
    

    private List<KnapsackState> _knapsackStorage;
    public KnapsackStateStorage()
    {

        _knapsackStorage = new List<KnapsackState>();
    }

    public void AddState(KnapsackState state)
    {
        if (state == null)
        {
            return;
        }
        _knapsackStorage.Add(state);
    }

    

    //public List<KnapsackState> GetStates()
    //{
    //    return states;
    //}

    //public void SaveToFile(string fileName)
    //{
    //    using (FileStream fs = new FileStream(fileName, FileMode.Create))
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        formatter.Serialize(fs, states);
    //    }
    //}

    //public void LoadFromFile(string fileName)
    //{
    //    using (FileStream fs = new FileStream(fileName, FileMode.Open))
    //    {
    //        BinaryFormatter formatter = new BinaryFormatter();
    //        states = (List<KnapsackState>)formatter.Deserialize(fs);
    //    }
    //}
}
