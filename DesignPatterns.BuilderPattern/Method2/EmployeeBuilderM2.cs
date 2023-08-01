using DesignPatterns.BuilderPattern.Method1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Method2
{
    public abstract class EmployeeBuilderM2 : IEmployeeBuilderM2
    {
        protected EmployeeM2 Employee { get; set; }

        public EmployeeBuilderM2()
        {
            Employee = new EmployeeM2();
        }

        public abstract void SetFullname(string fullname);
        public abstract void SetEmailAddress(string email);
        public abstract void SetUsername(string username);
        public EmployeeM2 Build() => Employee;
    }
}
