﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

public class Manager
{
    private KnapsackParameters parameters;
    private AlgorithmRealization solver;
    private KnapsackStateStorage storage;


    public Manager(KnapsackParameters parameters)
    {
        solver = new AlgorithmRealization(parameters.Capacity);
        storage = new KnapsackStateStorage();
    }

    public KnapsackStateStorage AddItem(Item item)
    {
        solver.AddItem(item);
        KnapsackState state = solver.SaveKnapsackState();
        return storage;
    }

}
