using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMomo.Format
{
    public static class FormatRequesPayMentConnection
    {
        public static string FormatSignatureRequesPaymentApiConnectionString(string accessKey, string amount, string extraData, string ipnUrl, string orderId,
           string orderInfo,string partnerClientId, string partnerCode, string redirectUrl, string requestId, string requestType)
        {
            return "accessKey=" + accessKey +
                "&amount=" + amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderId +
                "&orderInfo=" + orderInfo +
                "&partnerClientId=" +partnerClientId+
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + redirectUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType
                ;
        }
    }
}
