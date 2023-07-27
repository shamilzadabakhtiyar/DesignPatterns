using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Method1
{
    public class EmployeeBuilderM1
    {
        private EmployeeM1 employee { get; set; }

        public EmployeeBuilderM1()
        {
            employee = new EmployeeM1();
        }

        public EmployeeBuilderM1 SetFullname(string fullname)
        {
            var arr = fullname.Split(' ');
            employee.Firstname = arr[0];
            employee.Lastname = arr[1];
            return this;
        }

        public EmployeeBuilderM1 SetEmailAddress(string email)
        {
            employee.EmailAddress = email;
            return this;
        }

        public EmployeeBuilderM1 SetUsername(string username)
        {
            employee.Username = username;
            return this;
        }

        public EmployeeM1 Build()
        {
            return employee;
        }
    }
}
