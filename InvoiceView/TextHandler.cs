using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Diagnostics;

namespace InvoiceView
{
    class TextHandler
    {

        public string TextHandler_line( string path )
        {
            string[] retrieve = new string[] { };
            string line="";
            List<string> media = new List<string>();
            StreamReader sr = new StreamReader(path, Encoding.Default);


            for (int i = 1; (line = sr.ReadLine()) != null; i++)

            {
                switch (i)
                {
                    case 1:
                        //line
                        { media = Spliter(line);
                            foreach (string im in media)
                            {
                                Trace.WriteLine(im);
                            }

                        }
                        Trace.WriteLine(media.Count());
                        break;
                    case 2:
                        {
                            media = Spliter(line);
                            //foreach (string im in media)
                            //{
                            //    Trace.WriteLine(im);
                            //}
                            List<string> temp = new List<string>();
                            temp = EnterSpliter(media[6]);
                            
                            
                            //    string num = temp[1].Replace("客户合同号:", "");
                            //    string issuer = temp[2].Replace("开票方:", "");
                            
                            Common.InvoiceSerial = media[0];
                            Common.CompanyName = media[2];
                            Common.TaxerID = media[3];
                            Common.AddressPhone = media[4];
                            Common.AccountDetails = media[5];
                          //  Common.ContractNum = num;
                          //  Common.Issuer = issuer;
                            Common.Notes = media[6];
                        }
                        Trace.WriteLine(media.Count());
                        break;
                    default:

                        {
                            if (line != ""&&line!=" ")
                            {
                                double q, u, a, t, ta;
                                media = Spliter(line);
                                Trace.WriteLine(line);
                                //foreach (string im in media)
                                //{
                                //    Trace.WriteLine(im);
                                //}
                                //UpdateDataTable();


                                double.TryParse(media[3], out q);
                                double.TryParse(media[4], out u);
                                a = q * u;
                               // double.TryParse(media[5], out a);
                                double.TryParse(media[5], out t);
                                double.TryParse(media[8], out ta);
                                Common.dt.Rows.Add(AddRow(Common.dt, media[0], media[2], media[1], q, u, a, t, ta));
                            }

                        }
                       // Trace.WriteLine(media.Count());
                        break;

                }

            }
            
            //while ((line = sr.ReadLine()) != null)
            //{
            //    //Trace.WriteLine(line);
            //    retrieve=Spliter(line);
            //    foreach (string i in retrieve)
            //    {
            //        //Trace.WriteLine(i);
                    
            //    }
            //    //Trace.WriteLine(retrieve.Count());
            //}            
            return line;
        }

        private DataRow AddRow(DataTable dt, string Item_Name, string Item_Model,string Unit, double Quantity, double Unit_Price,double Amount, double Tax_Rate,double Tax_Amount)
        {
            DataRow dr = dt.NewRow();

            dr["ItemNames"] = Item_Name;
            dr["Model"] = Item_Model;
            dr["Unit"] = Unit;
            dr["Quantity"] = Quantity;

            dr["UnitPrice"] = Unit_Price;
            dr["Amount"] = Amount;
            dr["TaxRate"] = Tax_Rate;
            dr["TaxAmount"] = Tax_Amount;

            return dr;


        }


        private List<string> EnterSpliter(string input)
        {

            List<string> media = new List<string>();
            // string[] result = new string[] { };
            List<string> result = new List<string>();

            media = input.Split(new char[2] { '\\', 'n' }).ToList();

            media.ForEach((s) =>
            {
                if (!string.IsNullOrEmpty(s))
                {
                    result.Add(s);

                }
            }

            );
            return result;

        }


        private List<string> Spliter(string input)
        {
            List<string> media=new List<string>();
            // string[] result = new string[] { };
            List<string> result = new List<string>();

            media = input.Split(new char[2] { '~','~'}).ToList();

            media.ForEach((s)=>
            {
                if (!string.IsNullOrEmpty(s))
                {
                    result.Add(s);

                }
            }
            
            );
            return result;
        }


    }
}
