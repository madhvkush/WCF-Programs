using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _3_DataMembers_ComplexHolders_
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {
       

        [OperationContract]
        ComplexInfoHolder GetDataUsingDataContract(ComplexInfoHolder PInfo);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "_3_DataMembers_ComplexHolders_.ContractType".
    [DataContract]
    public class ComplexInfoHolder
    {
        //bool boolValue = true;
        //string stringValue = "Hello ";

        [DataMember] //  this property would be serialized
        public string Email
        {
            get;set;
        }

        [DataMember]//  this property would be serialized
        public string Name
        {
            get;set;
        }
        //  this property would not be serialized because it is not decorated by  [DataMember]
        public string NotSerialized
        {
            get; set;
        }
    }
}
