using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserScore> UserScores { get; set; }

        public Course()
        {
            UserScores = new HashSet<UserScore>();
        }
    }
}
