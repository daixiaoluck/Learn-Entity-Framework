using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public class Area
    {
        [Key]
        public int Value { get; set; }
        public string Text { get; set; }
        [ForeignKey("Location")]
        public ICollection<Profile> Profiles { get; set; }

        public Area()
        {
            Profiles = new HashSet<Profile>();
        }
    }
}
