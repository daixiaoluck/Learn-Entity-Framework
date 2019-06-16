using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApp1
{
    public class User
    {
        public int Id { get; set; }
        // One to Many
        public Area Area { get; set; }
    }
}
