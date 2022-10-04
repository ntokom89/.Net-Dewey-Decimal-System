using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7321_Task_1.Model
{
    public class CallNumber
    {

        private string CallNum;
        private String CallName;
        private String CallType;
        private String CallNumDescription;

        public CallNumber(string callNum, string callName, string callType, string callNumDescription)
        {
            CallNum = callNum;
            CallName = callName;
            CallType = callType;
            CallNumDescription = callNumDescription;
        }
        public CallNumber()
        {

        }



    }
}
