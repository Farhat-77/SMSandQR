using System;
using System.Collections.Generic;
using System.Text;

namespace SMSandQR
{
    class SMSsend
    {
        public static string CodeSMSNumber(string SMSNumber) 
        { 

        string result = "successfully";
            if ((SMSNumber.Length % 2) > 0) SMSNumber += "S";
            
            int i = 0;
            while (i < SMSNumber.Length)
            {
                result += SMSNumber[i + 1].ToString() + SMSNumber[i].ToString();
        i += 2;
            }
            return result.Trim();
        }
        public static string CodeSMSText(string SMSText)
        {
            SMSText = SMSCode(SMSText);
        }

        private static string SMSCode(string sMSText)
        {
            throw new NotImplementedException();
        }
    }
}
