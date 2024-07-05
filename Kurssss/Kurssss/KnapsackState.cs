using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

/// <summary>
/// Класс, описывающий состояние рюкзака
/// </summary>
public class KnapsackState
{
    public List<Item> SelectedItems { get; set; }
  
    public List<Item> UnSelectedItems { get; set; }

    public int Capacity { get; set; }

    public int SelectedWeight { get; set; }

    /// <summary>
    /// Конструктор состояния
    /// </summary>
    /// <param name="selectedItems"></param>
    /// <param name="totalWeight"></param>
    /// <param name="totalValue"></param>
    public KnapsackState(List<Item> selectedItems, List<Item> unSelectedItems, int capacity, int selectedWeight)
    {
        SelectedItems = selectedItems;
        UnSelectedItems = unSelectedItems;
        Capacity = capacity;
        SelectedWeight = selectedWeight;
    }

    public int GetSelectedValue()
    {
        int SelectedValue = 0;
        foreach(Item item in SelectedItems)
        {
            SelectedValue += item.Value;
        }
        return SelectedValue;
    }
}
