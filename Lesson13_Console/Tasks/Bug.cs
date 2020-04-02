using Lesson13_Console.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_Console.Tasks
{
    public class Bug : TaskBase
    {
        public Bug(string name, int priority, int complexity, int estimate) :
            base(name, priority, complexity, estimate)
        {

        }

        public override TaskType Type => TaskType.Bug;
    }
}
