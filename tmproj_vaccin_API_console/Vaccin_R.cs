using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Collections;


namespace tmproj_vaccin_API_console
{
    class Vaccin_R
    {
        static private string targetURL = "https://api.odcloud.kr/api/15077586/v1/centers?page=1&perPage=100&serviceKey=hNrhpOpmlEEcb2No90JY%2BT%2BKwUkh9sBgRdzjQVtOxyJ49%2B18bcg%2FMPohoMZSROew5dX%2FLnDICmqglg8zgGvdXA%3D%3D";
        static public ArrayList arrayList;

        public static string callWebClient()
        {
            string result = string.Empty;
            try
            {
                WebClient client = new WebClient();

                using (Stream data = client.OpenRead(targetURL))
                {
                    using (StreamReader reader = new StreamReader(data))
                    {
                        string s = reader.ReadToEnd();
                        result = s;

                        reader.Close();
                        data.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return result;
        }
        public static string callWebRequest()
        {
            string responseFromServer = string.Empty;

            try
            {
                WebRequest request = WebRequest.Create(targetURL);
                request.Method = "GET";
                request.ContentType = "application/json";

                using (WebResponse response = request.GetResponse())
                using (Stream dataSream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(dataSream))
                {
                    responseFromServer = reader.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            return responseFromServer;
        }

        public static void get_vaccin_list()
        {
            string webClientResult = callWebClient();
            var read = JObject.Parse(webClientResult);
            var list = read["data"];
            arrayList = new ArrayList();    // arrayList 초기화.

            if (list != null)
            {
                foreach (var o in list)
                {
                    arrayList.Add(o);
                }
            }
            /*
             * Console.WriteLine(r);
             * if (list != null)
             * {
             *     foreach (var o in list)
             *     {
             *         Console.WriteLine(string.Format("{0} : {1}", "ID       ", o["id"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "주소     ", o["address"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "센터 명  ", o["centerName"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "센터 유형", o["centerType"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "시설명   ", o["facilityName"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "운영기관 ", o["org"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "시/도    ", o["sido"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "시/군/구 ", o["sigungu"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "우편번호 ", o["zipCode"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "위도     ", o["lat"]));
             *         Console.WriteLine(string.Format("{0} : {1}", "경도     ", o["lng"]));
             *         Console.WriteLine("**********************************************");
             *     }
             * }
             * Console.ReadLine();
             */
        }
    }
}
