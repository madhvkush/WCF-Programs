using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _4_KnownTypes
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        Person GetPerson(Person person);

    }



    #region DataContracts
    [KnownType(typeof(Employee))] // EmpCode would be Serialize with Person
    [KnownType(typeof(EndUser))] // Mobile  would be serilize with Person 
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name { get; set; }
    }
    [DataContract]
    public class Employee:Person
    {
        [DataMember]
        public string EmpCode { get; set; }
    }
    [DataContract]
    public class EndUser:Person
    {
        [DataMember]
        public string Mobile { get; set; }
    }
    #endregion
}
