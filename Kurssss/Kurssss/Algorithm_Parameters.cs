using System;

namespace Kurssss;

/// <summary>
/// Класс для передачи начальных параметров
/// </summary>
public class Algorithm_Parameters
{
    public int Backpack_Capacity { get; set; }
   
    public List<Item> Items { get; set; }

    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="backpack_capacity">Вместимость рюкзака</param>
    /// <param name="number_of_objects">Количество объектов</param>
    public Algorithm_Parameters(int backpack_capacity, List<Item> items)
    { 
        Backpack_Capacity = backpack_capacity;
        Items = items;  
    }
}