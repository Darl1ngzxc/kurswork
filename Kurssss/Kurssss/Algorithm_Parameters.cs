using System;

namespace Kurssss;

/// <summary>
/// ����� ��� �������� ��������� ����������
/// </summary>
public class Algorithm_Parameters
{
    public int Backpack_Capacity { get; set; }
   
    public List<Item> Items { get; set; }

    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="backpack_capacity">����������� �������</param>
    /// <param name="number_of_objects">���������� ��������</param>
    public Algorithm_Parameters(int backpack_capacity, List<Item> items)
    { 
        Backpack_Capacity = backpack_capacity;
        Items = items;  
    }
}