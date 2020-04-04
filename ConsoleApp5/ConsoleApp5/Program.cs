using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ConsoleApp5.Tasks;
using ConsoleApp5.Utils;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var story = new Story("Update DataBase Schema");
            story.Backlog.Add(new Bug("Invaid column name", 10, 2, 60));
            story.Backlog.Add(new Task("Add column name", 5, 1, 120));
            story.Backlog.Add(new TechDebt("Remove exceed column age",1,5,120));

            story.Backlog.ForEach(Console.WriteLine);
            Console.WriteLine($"Total estimation of story {story.Name} is {story.GetTotalEstimation()}");
               
                
        }
    }
}
