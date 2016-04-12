using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA
{
    class JobshopGA
    {
        double crossoverRate = 0.7;
        double mutationRate = 0.05;
        int iterationLimit = 10000;
        int populationSize = 100;
        int crossSize; //memory used
        int mutationSize;

        public virtual void crossoverOperation()
        {}
        public virtual void mutationOperation()
        { }
        public virtual void selectionOperation() { }
    }
}
