using Lesson13.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson13.Tasks
{
    public class TechDebt : TaskBase
    {
        public TechDebt(string name, int priority, int complexity, int estimate)
             : base(name, priority, complexity, estimate)
        { }
        public override TaskTypes Type => TaskTypes.TechDebt;
    }
}
