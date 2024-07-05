using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

public class Manager
{
    
    private AlgorithmRealization solver;
    private KnapsackStateStorage storage;
    public KnapsackStateStorage GetStorage() { return storage; }

    public Manager(KnapsackParameters parameters)
    {
        solver = new AlgorithmRealization(parameters.Capacity);
        storage = new KnapsackStateStorage();
        KnapsackState state = solver.SaveKnapsackState();
        storage.AddState(state);
    }

    public KnapsackStateStorage AddItem(string name, int weight, int value)
    {
        Item item = new Item(name, weight, value);
        solver.AddItem(item);
        KnapsackState state = solver.SaveKnapsackState();
        storage.AddState(state);
        return storage;
    }

    public KnapsackStateStorage ResultSolve(int currentStep)
    {   
        List<Item> items = new List<Item>(storage.GetState(currentStep).UnSelectedItems);
        items.Sort((x, y) => (y.Value / y.Weight).CompareTo(x.Value / x.Weight));
        while (storage.GetState(currentStep).SelectedWeight + items[0].Weight 
            <= storage.GetState(currentStep).Capacity)
        {
            
            currentStep++;
            solver.StepSolve();
            KnapsackState state = solver.SaveKnapsackState();
            storage.AddState(state);
            items.RemoveAt(0);
            if (storage.GetState(currentStep).UnSelectedItems.Count == 0)
            {
                break;
            }
            
        }
        return storage;
    }
}
