using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;


public class Item
{
    public string Name { get; set; }

    public int Weight { get; set; }

    public int Value { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="name">Название</param>
    /// <param name="weight">Вес</param>
    /// <param name="value">Ценность</param>
    public Item(string name, int weight, int value)
    {
        Name = name;
        Weight = weight;    
        Value = value;
    }
}
