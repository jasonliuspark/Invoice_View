using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceView
{
    public static class Common
    {
        /// <summary>
        /// static varibles 
        /// </summary>
        private static string companyName ="";
        private static string contractNum = "";
        private static string issuer = "";
        private static string taxerID = "";
        private static string addressPhone = "";
        private static string accountDetails = "";

        //arrays
        //货物或应税劳务名称
        public static List<string> ItemNames = new List<string>();
        //规格型号
        public static List<string> Model = new List<string>();
        //单位
        public static List<string> Unit = new List<string>();
        //数量
        public static List<string> Quantity = new List<string>();
        //单价
        public static List<string> UnitPrice = new List<string>();
        //金额
        public static List<string> Amount = new List<string>();
        //税率
        public static List<string> TaxRate = new List<string>();
        //税额
        public static List<string> TaxAmount = new List<string>();
       

        public static string CompanyName
        {
            get { return companyName; }
            set { companyName = value; }

        }
        public static string ContractNum
        {
            get { return contractNum; }
            set { contractNum = value; }

        }
        public static string Issuer
        {
            get { return issuer; }
            set { issuer = value; }

        }
        public static string TaxerID
        {
            get { return taxerID; }
            set { taxerID = value; }

        }
        public static string AddressPhone
        {
            get { return addressPhone; }
            set { addressPhone = value; }

        }

        public static string AccountDetails
        {
            get { return accountDetails; }
            set { accountDetails = value; }

        }

    }
}
