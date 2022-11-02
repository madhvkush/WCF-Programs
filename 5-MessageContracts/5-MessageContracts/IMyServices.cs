using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _5_MessageContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMyServices
    {
        [OperationContract]
        EmployeeInfo GetEmployeeInfo();

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "_5_MessageContracts.ContractType".
    [MessageContract]
    public class EmployeeInfo
    {
        string _VerificationKey = "12345";
        string _Name = "John ";

        [MessageHeader]
        public string VerificationKey
        {
            get { return _VerificationKey; }
            set { _VerificationKey = value; }
        }

        [MessageBodyMember]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
    }
}
