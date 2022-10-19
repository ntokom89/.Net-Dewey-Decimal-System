using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7321_Task_1.Model
{
  
    public class CallNumber
    {
        public static Dictionary<String,String> callNumbersDictionary = new Dictionary<string, string>();
        private string callNum;
        private String callName;
        private String callType;
        private String callNumDescription;

        public CallNumber(string callNum, string callName, string callType, string callNumDescription)
        {
            this.callNum = callNum;
            this.callName = callName;
            this.callType = callType;
            this.callNumDescription = callNumDescription;
        }
        public CallNumber()
        {

        }

        public string CallNum { get; set; }

        public string CallName { get; set; }
        public string CallType { get; set; }
        public string CallNumDescription { get; set; }
        //public int MyProperty { get; set; }

    }
}
