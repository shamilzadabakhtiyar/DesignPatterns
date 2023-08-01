using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BuilderPattern.Method2
{
    public class ExternalEmployeeBuilder : EmployeeBuilderM2
    {
        public override void SetEmailAddress(string email)
        {
            throw new NotImplementedException();
        }

        public override void SetFullname(string fullname)
        {
            throw new NotImplementedException();
        }

        public override void SetUsername(string username)
        {
            throw new NotImplementedException();
        }
    }
}
