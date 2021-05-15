using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace vaccinTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Vaccin_R.get_vaccin_list();
            list = Vaccin_R.arrayList;

            foreach (CenterInfo ci in list)
            {
                Console.WriteLine("ID: {0}\r\n주소: {1}, 센터 명: {2}", ci.id, ci.address, ci.centerName);
                Console.WriteLine("센터 유형: {0}, 시설명: {1}, 운영기관: {2}", ci.centerType, ci.facilityName, ci.org);
                Console.WriteLine("시/도: {0}, 시/군/구: {1}, 우편번호: {2}", ci.sido, ci.sigungu, ci.zipCode);
                Console.WriteLine("위도: {0}, 경도: {1}", ci.lat, ci.lng);
            }

            Console.ReadLine();
        }
    }
}
