using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1
{
    public class MyDBInitializer:DropCreateDatabaseIfModelChanges<MyDBContext>
    {
        protected override void Seed(MyDBContext context)
        {
            var u1 = new User { Email = "1@qq.com" };
            var p1 = new Profile { User = u1, Education = Profile.EducationLevel.Master };
            var a1 = new Area { Text = "New Territories", Profiles = new HashSet<Profile> { p1 } };
            var a2 = new Area { Text = "Kowloon" };
            var a3 = new Area { Text = "Hong Kong Island" };
            var c1 = new Course { Name = "Internet Security Practice and Principles" };
            var c2 = new Course { Name = "E-Commerce Fundamentals and Development" };
            var us1 = new UserScore { Course = c1, Profile = p1, Score = 80 };
            var us2 = new UserScore { Course = c2, Profile = p1, Score = 70 };

            context.Users.Add(u1);
            context.Profiles.Add(p1);
            context.Areas.AddRange(new List<Area> { a1, a1, a3 });
            context.Courses.AddRange(new List<Course> { c1, c2 });
            context.UserScores.AddRange(new List<UserScore> { us1, us2 });
            context.SaveChanges();
        }
    }
}
