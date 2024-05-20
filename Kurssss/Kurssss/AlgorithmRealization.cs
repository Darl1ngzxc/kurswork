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
    private List<Item> selectedItems = new List<Item>();
    private int Capacity;

    private KnapsackParameters parameters;
    
    private KnapsackStateStorage stateStorage;

    private KnapsackState currentState;

    private List<Item> items;
    public AlgorithmRealization(int capacity)
    {
        Capacity = capacity;

        items = new List<Item>();
    }

    /// <summary>
    /// Жадный алгоритм
    /// </summary>
    /// <returns></returns>
    public void Solve()
    {
        List<Item> sortedItems = items;
        sortedItems.Sort((x, y) => (y.Value / y.Weight).CompareTo(x.Value / x.Weight));

        int totalWeight = 0;
        int totalValue = 0;

        foreach (Item item in sortedItems)
        {
            if (totalWeight + item.Weight <= parameters.Capacity)
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

    public void AddItem(Item item)
    {
        items.Add(item);
    }


}
