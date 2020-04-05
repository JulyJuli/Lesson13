using Lesson13.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = Lesson13.Tasks.Task;

namespace Lesson13
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var story = new Story("Update Databas scheme");
            story.BackLog.Add(new Bug("Invalid message", 10, 2, 60));
            story.BackLog.Add(new Task("Add a column", 5, 1, 120));
            story.BackLog.Add(new TechDebt("Remove exceed column", 1, 5, 60));

            story.BackLog.ForEach(task => Console.WriteLine(task));

            Console.WriteLine($"Total estimation of a story {story.Name} is {story.GetTotalEstimation()}");
            
            Console.ReadKey();
        }
    }
}
