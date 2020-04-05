using Lesson13.Tasks;
using System;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            var story = new Story("Update Database");

            story.Backlog.Add(new Bug("Invalid column name", 10, 2, 60));
            story.Backlog.Add(new Bug("Add column name", 5, 1, 120));
            story.Backlog.Add(new Bug("Remove column name", 1, 5, 60));

            story.Backlog.ForEach(Console.WriteLine);

            foreach (var item in story.Backlog)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine($"Total estimation of story: {story.Name} is {story.GetTotalEstimation()}");
            Console.ReadKey();

        }
    }
}
