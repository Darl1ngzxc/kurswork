using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

/// <summary>
/// Класс, реализующий алгоритм
/// </summary>
public class AlgorithmRealization
{
    private Algorithm_Parameters parameters;
    
    private KnapsackStateStorage stateStorage;

    private KnapsackState currentState;
    public AlgorithmRealization(Algorithm_Parameters parameters)
    {
        this.parameters = parameters;
    }

    /// <summary>
    /// Жадный алгоритм
    /// </summary>
    /// <returns></returns>
    public void Solve()
    {
        List<Item> sortedItems = parameters.Items;
        sortedItems.Sort((x, y) => (y.Value / y.Weight).CompareTo(x.Value / x.Weight));

        List<Item> selectedItems = new List<Item>();
        int totalWeight = 0;
        int totalValue = 0;

        foreach (Item item in sortedItems)
        {
            if (totalWeight + item.Weight <= parameters.Backpack_Capacity)
            {
                selectedItems.Add(item);
                totalWeight += item.Weight;
                totalValue += item.Value;
            }
        }
    }

    public void AddState(List<Item> selectedItems, int totalWeight, int totalValue)
    {
        currentState = new KnapsackState(selectedItems, totalWeight, totalValue);
    }

    public List<KnapsackState> GetStates()      
    {
        return states;
    }


}
