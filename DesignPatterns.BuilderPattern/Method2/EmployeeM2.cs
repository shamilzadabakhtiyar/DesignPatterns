using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Method2
{
    public class EmployeeM2
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }

        public override string ToString()
        {
            return $"{Firstname} {Lastname} {Username}";
        }
    }
}
