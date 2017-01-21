using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OrderEntryApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage(GetXMLForOrderEntry());
        }

        private static void SendMessage(String data)
        {
            MessageQueue messageQueue;
            messageQueue = new MessageQueue(@".\Private$\OrderEntryQueue");

            System.Messaging.Message message;
            message = new System.Messaging.Message();

            System.Xml.XmlDocument xmlDocument;
            xmlDocument = new XmlDocument();

            xmlDocument.InnerXml = data;

            message.Body = xmlDocument;
            messageQueue.Send(message);
        }
        private static string GetXMLForOrderEntry()
        {
            string tmp;

            HQOrderEntryServiceInterface.HQOrderEntry test;
            test = new HQOrderEntryServiceInterface.HQOrderEntry();

            test.OrderEntryID = "00000001";
            test.OrderEntryDate = System.DateTime.Now;
            test.OrderCustomer = new HQOrderEntryServiceInterface.Customer();
            test.OrderCustomer.CustomerName = "WROX";
            test.OrderCustomer.CustomerAddressLine1 = "CustomerAddressLine1";
            test.OrderCustomer.CustomerAddressLine2 = "CustomerAddressLine2";
            test.OrderCustomer.CustomerCountryCode = "BE";
            test.OrderOrderedProducts =
            new List<HQOrderEntryServiceInterface.OrderedProducts>();
            test.OrderOrderedProducts.Add(
            new HQOrderEntryServiceInterface.OrderedProducts()
            );
            test.OrderOrderedProducts[0].ProductID = "P08872";
            test.OrderOrderedProducts[0].Quantity = 5;
            test.OrderOrderedProducts[0].ProductName = "Car";
            test.OrderOrderedProducts.Add(
            new HQOrderEntryServiceInterface.OrderedProducts()
            );
            test.OrderOrderedProducts[1].ProductID = "P02287";
            test.OrderOrderedProducts[1].ProductName = "Bike";
            test.OrderOrderedProducts[1].Quantity = 5;

            tmp = HelperLib.GenericSerializer<HQOrderEntryServiceInterface.HQOrderEntry>
            .Serialize(test);

            return tmp;
        }
    }
}
