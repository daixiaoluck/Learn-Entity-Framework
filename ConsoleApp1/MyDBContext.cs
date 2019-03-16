using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApp1
{
    public class MyDBContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserScore> UserScores { get; set; }

        public MyDBContext():base("DefaultConnection")
        {
            Database.SetInitializer(new MyDBInitializer());
        }
    }
}
