using System;
using System.Collections.Generic;
using System.Text;

namespace SMSandQR
{
    class QRCode
    {
        QRCode QREncode = new QRCode();

        string strRUS = "Оплачено";
        string QRtext = QRText;

        public static string QRText { get; private set; }
    }
    public void QREncode(object sender, QREncode args)
    {
        object QREncodeSend = null;
        var handler = QREncodeSend;
        if (handler != null)
        {
            handler(this, args);
        }
    }
}
  

