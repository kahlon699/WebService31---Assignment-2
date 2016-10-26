using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService31
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
        [FaultContract (typeof(MyError))]
        List<string> ConvertToArray(string str); 
        [OperationContract]
        String ConvertToUpperCase(string str);
        [OperationContract]
        int LengthOfString(string str);
        [OperationContract]
        List<CustomClass> WordLengths(string str);

       
       

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WebService31.ContractType".
    [DataContract]
   public class CustomClass
    {
        [DataMember]
        public string word { get; set; }
        [DataMember]
        public int length { get; set; }
    }

    public class MyError
    {
        public int Errorcode { get; set; }
        public string ErrorMsg { get; set; }
    }

}
