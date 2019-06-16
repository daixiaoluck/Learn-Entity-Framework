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
            var a1 = new Area { HKAD = HongKongAdministrativeDivision.Hong_Kong_Island };
            var a2 = new Area { HKAD = HongKongAdministrativeDivision.Kowloon };
            var a3 = new Area { HKAD = HongKongAdministrativeDivision.New_Territories };

            var u1 = new User { Area = a1 };
            var u2 = new User { Area = a2 };
            var u3 = new User { Area = a3 };
            
            var c1 = new Course { Name = "Database" };
            var c2 = new Course { Name = "Internet Protocols" };

            var us1 = new UserScore { User = u1, Course = c1, Score = 75 };
            var us2 = new UserScore { User = u1, Course = c2, Score = 75 };
            var us3 = new UserScore { User = u2, Course = c1, Score = 70 };
            var us4 = new UserScore { User = u2, Course = c2, Score = 70 };
            var us5 = new UserScore { User = u3, Course = c1, Score = 65 };
            var us6 = new UserScore { User = u3, Course = c2, Score = 65 };

            context.Users.AddRange(new List<User> { u1, u2, u3 });
            context.Areas.AddRange(new List<Area> { a1, a2, a3 });
            context.Courses.AddRange(new List<Course> { c1, c2 });
            context.UserScores.AddRange(new List<UserScore> { us1, us2, us3, us4, us5, us6 });
            context.SaveChanges();
        }
    }
}
