using Lesson13.Tasks;
using System;

namespace Lesson13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var story = new Story("Update Database Shema");
            story.Backlog.Add(new Bug("Invalid column name", 10, 2, 60));
            story.Backlog.Add(new Task("Add column name", 5, 1, 120));
            story.Backlog.Add(new TechDebt("Remove exceed colum ", 1, 5, 60));

            story.Backlog.ForEach(Console.WriteLine);

            Console.WriteLine($"Total estimation of story {story.Name}, is {story.GetTotalEstimation()}");

            Console.ReadLine();
        }
    }
}
