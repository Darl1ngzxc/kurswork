using System;

namespace Kurssss;

/// <summary>
/// ����� ��� �������� ��������� ����������
/// </summary>
public class KnapsackParameters
{
    public int Capacity { get; set; }

   

    /// <summary>
    /// �����������
    /// </summary>
    /// <param name="backpack_capacity">����������� �������</param>
    /// <param name="number_of_objects">���������� ��������</param>\

    public KnapsackParameters(int capacity)
    {
        Capacity = capacity;
        
    }
}