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

        public CallNumber()
        {

        }

        public CallNumber(string callNum, int callNumInt, string callNumDescription)
        {
            CallNum = callNum;
            CallNumInt = callNumInt;
            CallNumDescription = callNumDescription;
        }

        public string CallNum { get; set; }

        public string CallName { get; set; }
        public string CallType { get; set; }
        public string CallNumDescription { get; set; }

        public int CallNumInt { get; set; }
        //public int MyProperty { get; set; }

    }
}
