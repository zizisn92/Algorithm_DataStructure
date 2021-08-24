using System;
using System.Collections.Generic;

namespace Bai21_XetTuyen
{
    class Program
    {
        static void KiemTraKetQuaXetTuyen()
        {
            double tongDiem = 0;
            Dictionary<char, double> dicKhuVuc = new Dictionary<char, double>();
            dicKhuVuc.Add('A', 2);
            dicKhuVuc.Add('B', 1);
            dicKhuVuc.Add('C', 0.5);
            dicKhuVuc.Add('X', 0);
            Dictionary<int, double> dicDoiTuong = new Dictionary<int, double>();
            dicDoiTuong.Add(1, 2.5);
            dicDoiTuong.Add(2, 1.5);
            dicDoiTuong.Add(3, 1);
            dicDoiTuong.Add(0, 0);
            Console.WriteLine("Nhap diem chuan:");
            double diemChuan = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin hoc sinh");
            Console.WriteLine("Nhap diem 3 mon thi");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Diem mon thi thu {i+1} la:");
                double diem = double.Parse(Console.ReadLine());
                tongDiem += diem;
            }
            Console.WriteLine("Nhap khu vuc:");
            char khuVuc = char.Parse(Console.ReadLine());
            foreach (KeyValuePair<char,double> item in dicKhuVuc)
            {
                if(item.Key==khuVuc)
                {
                    tongDiem += item.Value;
                }
            }
            Console.WriteLine("Nhap doi tuong");
            int doiTuong = Int32.Parse(Console.ReadLine());
            foreach (KeyValuePair<int, double> item in dicDoiTuong)
            {
                if (item.Key == doiTuong)
                {
                    tongDiem += item.Value;
                }
            }
            if(tongDiem<=diemChuan)
            {
                Console.WriteLine($"Rot [{tongDiem}]");
            }
            else
            {
                Console.WriteLine($"Dau [{tongDiem}]");
            }
        }
        static void Main(string[] args)
        {
            KiemTraKetQuaXetTuyen();
            Console.ReadKey();
        }
    }
}
