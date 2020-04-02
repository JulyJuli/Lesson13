using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lesson13_Console.Tasks;

namespace Lesson13_Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var story = new Story("Update Database Schema");
            story.Backlog.AddRange(new List<TaskBase>
            {
                new Bug("Invalid column name", 10, 2, 60),
                new Task("Add column name", 5, 1, 120),
                new TechDebt("Remove exceed column age", 1, 5, 60)
            });

            foreach(var task in story.Backlog)
            {
                Console.WriteLine(task);
            }

            Console.WriteLine($"Total estimation of story {story.Name}: {story.GetTotalEstimation()}");
        }
    }
}
