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
class KnapsackStateStorage
{
    private List<KnapsackState> states;

    public KnapsackStateStorage()
    {
        states = new List<KnapsackState>();
    }

    public void AddState(KnapsackState state)
    {
        states.Add(state);
    }

    public void Reset()
    {
        states.Clear();
    }

    public List<KnapsackState> GetStates()
    {
        return states;
    }

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
