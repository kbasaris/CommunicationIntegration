using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.MsmqIntegration;
using System.Text;
using System.Threading.Tasks;
using HQOrderEntryServiceInterface;
using LocalOrderEntryInterface;
using HelperLib;

namespace HQOrderEntryImplementation
{
    public class HQOrderEntryService : IOrderEntryService
    {
        public void SendOrderEntry(MsmqMessage<HQOrderEntry> orderEntryMsg)
        {
            try
            {
                if (CheckIfOrderIsValid(orderEntryMsg.Body))
                {

                }
                else
                {
                    SendToInvalidOrderQueue(orderEntryMsg);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private bool CheckIfOrderIsValid(HQOrderEntry orderEntry)
        {
            HQProductServiceASMXClient.HQProductServiceASMXSoapClient client;
            client = new HQProductServiceASMXClient.HQProductServiceASMXSoapClient();

            bool orderIsValid = true;

            foreach (var item in orderEntry.OrderOrderedProducts)
            {
                orderIsValid = client.IsProductAvailableForCountry(item.ProductID, orderEntry.OrderCustomer.CustomerCountryCode);
            }
            return orderIsValid;
        }

        private LocalOrderEntry ConvertOrderEntrySchema(HQOrderEntry orderEntry)
        {
            LocalOrderEntry localOrderEntry;
            localOrderEntry = new LocalOrderEntry();

            localOrderEntry.CustomerName =
            orderEntry.OrderCustomer.CustomerName;
            localOrderEntry.CustomerAddressLine1 =
            orderEntry.OrderCustomer.CustomerAddressLine1;
            localOrderEntry.CustomerAddressLine2 =
            orderEntry.OrderCustomer.CustomerAddressLine2;
            localOrderEntry.CustomerCountryCode =
            orderEntry.OrderCustomer.CustomerCountryCode;

            localOrderEntry.OrderOrderedProducts =
            new List<LocalOrderEntryInterface.OrderedProducts>();

            foreach (var item in orderEntry.OrderOrderedProducts)
            {
                string translation;
                translation = TranslateProductDescription(item.ProductID,
                orderEntry.OrderCustomer.CustomerCountryCode);

                localOrderEntry.OrderOrderedProducts.Add(
                new LocalOrderEntryInterface.OrderedProducts
                {
                    ProductID = orderEntry.OrderCustomer.CustomerCountryCode
                + "/"
                + item.ProductID,
                    Quantity = item.Quantity,
                    LocalizedDescription = translation
                });
            }
            return localOrderEntry;
        }

        private void RouteOrderEntry(LocalOrderEntry localOrderEntry)
        {
            //Add code later
        }

        private void SendToInvalidOrderQueue(MsmqMessage<HQOrderEntry> orderEntryMsg)
        {
            //Add code later
        }

        private string TranslateProductDescription(string productID, string languageCode)
        {
            System.Net.HttpWebRequest webrequest;
            webrequest = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(
            string.Format
            (@"http://localhost:8081/HQLocalizationService/TranslateProductDescriptions/{0}/{1}",
            languageCode,
            productID));
            webrequest.ContentLength = 0;

            System.Net.HttpWebResponse webresponse;

            webresponse = (System.Net.HttpWebResponse)webrequest.GetResponse();

            Encoding enc = System.Text.Encoding.GetEncoding(1252);
            System.IO.StreamReader loResponseStream = new
            System.IO.StreamReader(webresponse.GetResponseStream(), enc);

            string response = loResponseStream.ReadToEnd();

            string answer;
            answer = GenericSerializer<string>.DeserializeDC(response);

            return answer;
        }
    }
}
