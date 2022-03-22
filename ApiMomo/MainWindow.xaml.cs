using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ApiMomo.CallApi;
using ApiMomo.Format;
using Newtonsoft.Json.Linq;
namespace ApiMomo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string endpoint = txtEndPoint.Text.Equals("") ? "https://test-payment.momo.vn/v2/gateway/api/create" : txtEndPoint.Text;
            string partnerCode = txtPartnerCode.Text;
            string accessKey = txtAcessKey.Text;
            string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            string orderInfo = txtOrderInfo.Text;
            string redirectUrl = txtRedirectUrl.Text;
            string ipnUrl = txtIpnUrl.Text;
            string requestType = "captureWallet";
            string amount = txtAmount.Text;
            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";
            string rawHash = FormatSignatureRequesPaymentApi.FormatSignatureRequesPaymentApiString(accessKey, amount,extraData, ipnUrl, orderId, orderInfo,
                partnerCode, redirectUrl, requestId, requestType);
            string signature = Securerity.Sha256Helper.signSHA256(rawHash, serectkey);
            string message = FormatMessage.ConvertJsonToMessage(partnerCode, requestId, amount, orderId,redirectUrl, orderInfo,
                ipnUrl, extraData, requestType, signature);
            RequestPayMent requestPayMent = new RequestPayMent(endpoint);
            string responseFromMomo = await requestPayMent.SendPayMentReques(message);
            JObject jmessage = JObject.Parse(responseFromMomo);

            MessageBoxResult result = MessageBox.Show(responseFromMomo, "Open in browser", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                   string url= jmessage.GetValue("payUrl").ToString();
                //yes...
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = url;
                System.Diagnostics.Process.Start(psi);
            }
            else if (result == MessageBoxResult.No)
            {

            }
        }

        private async void btn1_Click(object sender, RoutedEventArgs e)
        {
            string endpoint = txtEndPoint.Text.Equals("") ? "https://test-payment.momo.vn/v2/gateway/api/create" : txtEndPoint.Text;
            string partnerCode = txtPartnerCode.Text;
            string accessKey = txtAcessKey.Text;
            string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            string orderInfo = txtOrderInfo.Text;
            string redirectUrl = txtRedirectUrl.Text;
            string partnerClientId = "youmustdie2912@gmail.com";
            string ipnUrl = txtIpnUrl.Text;
            string requestType = "linkWallet";
            string amount = txtAmount.Text;
            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";
            string rawHash = FormatRequesPayMentConnection.FormatSignatureRequesPaymentApiConnectionString(accessKey, amount, extraData, 
                ipnUrl, orderId, orderInfo,partnerClientId,
                partnerCode, redirectUrl, requestId, requestType);
            string signature = Securerity.Sha256Helper.signSHA256(rawHash, serectkey);
            string message = FormatMessageConnection.ConvertJsonToMessage(partnerCode,accessKey, requestId, amount, orderId, redirectUrl,partnerClientId, orderInfo,
                ipnUrl, extraData, requestType, signature);
            RequestPayMent requestPayMent = new RequestPayMent(endpoint);
            string responseFromMomo = await requestPayMent.SendPayMentReques(message);
            JObject jmessage = JObject.Parse(responseFromMomo);

            MessageBoxResult result = MessageBox.Show(responseFromMomo, "Open in browser", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                string url = jmessage.GetValue("payUrl").ToString();
                //yes...
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = url;
                System.Diagnostics.Process.Start(psi);
            }
            else if (result == MessageBoxResult.No)
            {

            }

        }

        private async void btnQueryStatus_Click(object sender, RoutedEventArgs e)
        {
            string endpoint = txtEndPoint.Text.Equals("") ? "https://test-payment.momo.vn/v2/gateway/api/create" : txtEndPoint.Text;
            string partnerCode = txtPartnerCode.Text;
            string accessKey = txtAcessKey.Text;
            string serectkey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            string orderInfo = txtOrderInfo.Text;
            string redirectUrl = txtRedirectUrl.Text;
            string ipnUrl = txtIpnUrl.Text;
            string requestType = "payWithATM";
            string amount = txtAmount.Text;
            string orderId = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";
            string rawHash = FormatSignatureRequesPaymentApi.FormatSignatureRequesPaymentApiString(accessKey, amount, extraData, ipnUrl, orderId, orderInfo,
                partnerCode, redirectUrl, requestId, requestType);
            string signature = Securerity.Sha256Helper.signSHA256(rawHash, serectkey);
            string message = FormatMessage.ConvertJsonToMessage(partnerCode, requestId, amount, orderId, redirectUrl, orderInfo,
                ipnUrl, extraData, requestType, signature);
            RequestPayMent requestPayMent = new RequestPayMent(endpoint);
            string responseFromMomo = await requestPayMent.SendPayMentReques(message);
            JObject jmessage = JObject.Parse(responseFromMomo);

            MessageBoxResult result = MessageBox.Show(responseFromMomo, "Open in browser", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                string url = jmessage.GetValue("payUrl").ToString();
                //yes...
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = url;
                System.Diagnostics.Process.Start(psi);
            }
            else if (result == MessageBoxResult.No)
            {

            }

        }
    }
}
