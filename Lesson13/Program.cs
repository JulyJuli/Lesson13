using System;
using System.Collections.Generic;
using Lesson13.Tasks;

namespace Lesson13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var story = new Story("MyStory");
            
            story.Backlog.AddRange(new List<TaskBase>()
            {
                new Bug("Bug123", 8, 3, 60),
                new Bug("Bug456", 3, 2, 100),
                new Task("Task123", 5, 4, 40),
                new Task("Task456", 6, 1, 60),
                new TechDebt("TechDebt456", 2, 5, 10)
            });

            story.Backlog.ForEach(Console.WriteLine);

            
            Console.WriteLine($"\nTotal estimation = {story.GetTotalEstimation()}");
        }
    }
}