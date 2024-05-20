using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

class Manager
{
    private KnapsackParameters parameters;
    private AlgorithmRealization solver;
    private KnapsackStateStorage storage;


    public Manager(KnapsackParameters parameters)
    {
        solver = new AlgorithmRealization(parameters.Capacity);
        storage = new KnapsackStateStorage();
    }

    public KnapsackStateStorage AddItem(string name, int weight, int value)
    {
        Item item = new Item(name, weight, value);
        solver.AddItem(item);

    }

}
