using System;
using BugTracker.BugDataContext;
using BugTracker.BugDataModel;

namespace BugTracker.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //using( var db= new BugContext(n))
            //{
            //    var priority1 = new Priority() { Name = "High", LevelOfPriority = 1 };
            //    var priority2 = new Priority() { Name = "Medium", LevelOfPriority = 1 };
            //    var priority3 = new Priority() { Name = "Low", LevelOfPriority = 1 };
            //    db.Priorities.AddRange(priority1, priority2, priority3);
            //    Console.WriteLine("adding priorities");

            //    db.SaveChanges();
            //    Console.WriteLine("done");

            //}
            Console.WriteLine("Hello World!");
        }
    }
}
