using Lesson13.Utils;

namespace Lesson13.Tasks
{
    public class Bug : TaskBase
    {

        public Bug(string name, int priority, int complexity, int estimate) : base(name, priority, complexity, estimate)
        {

        }

        public override TaskType Type => TaskType.Bug;
    }
}
