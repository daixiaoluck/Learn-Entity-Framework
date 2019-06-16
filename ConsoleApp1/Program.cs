using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBContext())
            {
                // You must include whatever you need
                // For example, it is not enough to only include User
                // You still need to include Area
                var dataSet = context.UserScores
                    .Include(us => us.Course)
                    .Include(us => us.User)
                    .Include(us => us.User.Area)
                    .OrderBy(us=>us.User.Id);
                // Test deletion effect on Many To Many relationship
                var course2 = context.Courses
                    .Where(c => c.Name == "Internet Protocols")
                    .FirstOrDefault();
                if(course2 != null)
                {
                    context.Courses.Remove(course2);
                }
                else
                {
                    Console.WriteLine("No tuple can be deleted.");
                    return;
                }
                context.SaveChanges();
                foreach (var d in dataSet)
                {
                    string ordinaryAreaName = Regex.Replace(d.User.Area.HKAD.ToString(), @"_", " ");
                    Console.WriteLine($"住在{ordinaryAreaName}、Id为{d.User.Id}的用户的{d.Course.Name}为{d.Score}");
                }
                Console.ReadLine();
            }
        }
    }
}
