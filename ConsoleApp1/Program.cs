using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MyDBContext())
            {
                var usersAndScores = from userScore in context.UserScores.Include("Course")
                                     join profile in context.Profiles.Include("User")
                                     on userScore.ProfileId equals profile.Id
                                     select new { UserEmail = profile.User.Email, CourseName = userScore.Course.Name, userScore.Score };
                foreach (var us in usersAndScores)
                {
                    Console.WriteLine($"{us.UserEmail}的{us.CourseName}成绩是{us.Score}.");
                }
            }
        }
    }
}
