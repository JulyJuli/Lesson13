using Lesson13.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Tasks
{
    public class Task : TaskBase
    {
        public Task(string name, int priority, int complexity, int estimate) 
            : base(name, priority, complexity, estimate)
        {
        }

        public override TaskType Type => TaskType.Task;
    }
}
