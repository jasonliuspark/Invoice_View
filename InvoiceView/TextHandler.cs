using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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

                            string num=temp[1].Replace("客户合同号:", "");
                            string issuer = temp[2].Replace("开票方:", "") ;

                            Common.CompanyName = media[2];
                            Common.TaxerID = media[3];
                            Common.AddressPhone = media[4];
                            Common.AccountDetails = media[5];
                            Common.ContractNum = num;
                            Common.Issuer = issuer;

                        }
                        Trace.WriteLine(media.Count());
                        break;
                    default:

                        {
                            media = Spliter(line);
                            //foreach (string im in media)
                            //{
                            //    Trace.WriteLine(im);
                            //}

                        }
                        Trace.WriteLine(media.Count());
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
