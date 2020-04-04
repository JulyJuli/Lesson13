using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Utils;

namespace ConsoleApp5.Tasks
{
    public class TechDebt:TaskBase
    {
        public TechDebt(string name, int priority, int complexity, int estimate) : base(name, priority, complexity, estimate)
        {

        }
        public override TaskType Type => TaskType.TechDebt;


    }
}
