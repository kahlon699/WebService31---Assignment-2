using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Text.RegularExpressions;


namespace WebService31
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<string> ConvertToArray(string str)
        {
            ChannelDispatcher dispatcher = OperationContext.Current.Host.ChannelDispatchers[0] as ChannelDispatcher;
            ServiceThrottle throttle = dispatcher.ServiceThrottle;

            Trace.WriteLine(String.Format("MaxConcurrentCalls = {0}",
                throttle.MaxConcurrentCalls));
            Trace.WriteLine(String.Format("MaxConcurrentSessions = {0}",
                throttle.MaxConcurrentSessions));
            Trace.WriteLine(String.Format("MaxConcurrentInstances = {0}",
                throttle.MaxConcurrentInstances));
            if (string.IsNullOrWhiteSpace(str))
            {
                throw new FaultException<MyError>(new MyError() { Errorcode = 101, ErrorMsg = "String cannot be Empty" });
            }

            if (str.Trim().Length==1)
            {
                throw new FaultException<MyError>(new MyError() { Errorcode = 102, ErrorMsg = "String cannot contain single character" });
            }
            return  Regex.Split(str, @"\s+").Where(s => s != string.Empty).ToList();

            
        }

        public string ConvertToUpperCase(string str)
        {
            return str.ToUpper();
        }

        

        

        public int LengthOfString(string str)
        {
            return str.Length;
        }

        public List<CustomClass> WordLengths(string str)
        {
           
            List<string> ListStr= Regex.Split(str, @"\s+").Where(s => s != string.Empty).ToList();
            List<CustomClass> list=new List<CustomClass>(); 
              
            foreach(string wo in ListStr)
            {
                CustomClass cus = new CustomClass();
                cus.word = wo;
                cus.length = wo.Length;
                list.Add(cus);

                
            }
            return list;
        }
    }
}
