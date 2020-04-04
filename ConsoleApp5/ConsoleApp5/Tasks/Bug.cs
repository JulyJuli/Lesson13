using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Utils;
using ConsoleApp5.Tasks;

namespace ConsoleApp5.Tasks
{
    public class Bug:TaskBase
    {
        public override TaskType Type => TaskType.Bug;

       
            public Bug(string name,int priority, int complexity, int estimate) : base(name, priority, complexity, estimate)
            {

            }
    }
}
