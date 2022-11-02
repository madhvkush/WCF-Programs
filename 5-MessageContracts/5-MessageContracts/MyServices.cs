using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _5_MessageContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyServices : IMyServices
    {
        public EmployeeInfo GetEmployeeInfo()
        {
            return new EmployeeInfo { Name = "John", VerificationKey = "12345" };
        }
    }
}
