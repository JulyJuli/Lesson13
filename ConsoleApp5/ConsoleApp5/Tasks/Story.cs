using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp5.Tasks;

namespace ConsoleApp5.Tasks
{
    public class Story
    {
        public Story(string name)
        {
            Backlog = new List<TaskBase>();
            Name = name;
        }
        public List<TaskBase> Backlog { get; set; }
        public string  Name { get; set; }
        public int GetTotalEstimation()
        {
            int sum = 0;
            Backlog.ForEach(task => sum += task.GetActualEstimate());
            return sum;
        }
    }
}
