using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Method2
{
    public class InternalEmployeeBuilder : EmployeeBuilderM2
    {
        public override void SetEmailAddress(string email)
        {
            var arr = email.Split('@');

            Employee.EmailAddress = arr[0] + "@company.com";
        }

        public override void SetFullname(string fullname)
        {
            var arr = fullname.Split(' ');
            Employee.Firstname = arr[0];
            Employee.Lastname = arr[1];
        }

        public override void SetUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
