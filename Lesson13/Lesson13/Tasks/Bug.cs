using Lesson13.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Tasks
{
    public class Bug : TaskBase
    {
        public Bug(string name, int priority, int complexity, int estimate)
            : base(name, priority, complexity, estimate)
        {
        }

        public override TaskTypes Type { get => TaskTypes.Bug;}


    }
}
