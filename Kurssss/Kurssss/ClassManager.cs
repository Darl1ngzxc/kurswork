using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurssss;

class ClassManager
{
    private Algorithm_Parameters parameters;
    private AlgorithmRealization solver;
    private KnapsackStateStorage storage;


    public ClassManager(Algorithm_Parameters parameters)
    {
        this.parameters = parameters;
        solver = new AlgorithmRealization(parameters);
        storage = new KnapsackStateStorage();
    }

}
