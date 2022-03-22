using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMomo.Format
{
    public static class FormatSignatureRequesPaymentApi
    {
        public static string FormatSignatureRequesPaymentApiString(string accessKey,string amount,string extraData,string ipnUrl,string orderId,
            string orderInfo,string partnerCode,string redirectUrl,string requestId,string requestType)
        {
            return "accessKey=" + accessKey +
                "&amount=" + amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType
                ;
        }
    }
}
