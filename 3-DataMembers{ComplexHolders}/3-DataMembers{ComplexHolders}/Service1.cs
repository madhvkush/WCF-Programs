using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _3_DataMembers_ComplexHolders_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MyService : IMyService
    {
        public ComplexInfoHolder GetDataUsingDataContract(ComplexInfoHolder PInfo)
        {
            return new ComplexInfoHolder
            {
                Name = PInfo.Name,
                Email = PInfo.Email
            };
        }
    }
}
