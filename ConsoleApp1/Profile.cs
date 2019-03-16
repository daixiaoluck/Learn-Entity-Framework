using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Profile
    {
        public enum EducationLevel
        {
            Bachelor,
            Master,
            Doctor
        }
        [ForeignKey("User")]
        public int Id { get; set; }
        public int Location { get; set; }
        public User User { get; set; }
        public Area Area { get; set; }
        public EducationLevel Education { get; set; }
        public ICollection<UserScore> UserScores { get; set; }

        public Profile()
        {
            UserScores = new HashSet<UserScore>();
        }
    }
}
