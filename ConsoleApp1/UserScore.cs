using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class UserScore
    {
        [Key]
        [Column(Order = 0)]
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Profile")]
        public int ProfileId { get; set; }
        [Range(0,100)]
        public decimal Score { get; set; }
        public Course Course { get; set; }
        public Profile Profile { get; set; }
    }
}
