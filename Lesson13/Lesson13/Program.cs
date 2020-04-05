
using Lesson13.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            Bug bug = new Bug("Invalid Message", 9, 3, 60);
            Console.WriteLine(bug.UpdateEstimate());
           
            var story = new Story("New Story");
            story.BackLog.AddRange(new List<TaskBase>
                {
                new Bug("Invalid column name",8,5,50),
                new Tasks.Task("rename column name",5, 6,48),
                new TechDebt("asd", 8,9,60)
            });
            story.BackLog.ForEach(Console.WriteLine);
            Console.WriteLine($"Total estimation of story {story.Name} is {  story.GetTotalEstimation() }");
        }
    }
}
