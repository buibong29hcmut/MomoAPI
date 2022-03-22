using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiMomo.Format
{
    public static class FormatMessageConnection
    {
        public static string ConvertJsonToMessage(string partnerCode,string accesskey, string requestId, string amount, string orderId, string redirectUrl, string partnerClientId, string orderInfo, string ipnUrl, string extraData, string requestType, string signature)
        {

            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "accesskey", accesskey },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderId },
                { "orderInfo", orderInfo },
                { "redirectUrl", redirectUrl },
                {"partnerClientId",partnerClientId},
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }

            };
            return message.ToString();
        }
    }
}
