using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13.Tasks
{
     public class Story
    {
        public Story(string name)
        {
            BackLog = new List<TaskBase>();
            Name = name;
        }

        public List<TaskBase> BackLog { get; set; }
        public string Name { get; set; }
        public int GetTotalEstimation()
        {
            int sum = 0;
            BackLog.ForEach(task => sum += task.UpdateEstimate());
                return sum;
        }
        
    }
}
