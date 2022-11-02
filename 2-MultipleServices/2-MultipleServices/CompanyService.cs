using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _2_MultipleServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {
        public string GetConfidentialInformation()
        {
            return "Confidential Information";
        }

        public string GetPublicInformation()
        {
            return "Public Info";
        }
    }
}
