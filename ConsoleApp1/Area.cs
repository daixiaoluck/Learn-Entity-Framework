using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1
{
    public enum HongKongAdministrativeDivision
    {
        New_Territories,
        Kowloon,
        Hong_Kong_Island
    }
    public class Area
    {
        public int Id { get; set; }
        public HongKongAdministrativeDivision HKAD { get; set; }
    }
}
