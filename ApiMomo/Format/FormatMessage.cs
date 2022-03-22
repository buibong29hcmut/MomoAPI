using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMomo.Format
{
    public class FormatMessage
    {
        public static string ConvertJsonToMessage(string partnerCode,string requestId,string amount, string orderId,string redirectUrl,  string orderInfo,string ipnUrl,string extraData,string requestType,string signature)
        {

            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "signature", signature },
                { "requestType", requestType },
              

            };
            return message.ToString();
        }
    }
}
