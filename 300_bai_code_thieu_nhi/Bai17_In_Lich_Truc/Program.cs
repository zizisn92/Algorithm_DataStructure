using System;

namespace Bai17_In_Lich_Truc
{
    class Program
    {
        // Kiem tra nam nhuan
        static bool KiemTraNamNhuan(int year)
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }
            return false;
        }

        // Tinh so ngay trong 1 thang nam duong lich
        static int TinhSoNgayTrongThang(int month, int year)
        {
            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                return 31;
            }
            else if (month == 2)
            {
                if (KiemTraNamNhuan(year))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else
            {
                return 30;
            }
        }

        // Tinh thu trong tuan khi truyen vao ngay trong nam (Monday, Tuesday, ... Sunday)
        static int TinhThuTrongTuan(int q, int m, int y)
        {
            if (m == 1) { m = 13; y--; }
            if (m == 2) { m = 14; y--; }
            int k = y % 100;
            int j = y / 100;
            int h = q + (13 * (m + 1)) / 5 + k + k / 4 + j / 4 + 5 * j;
            h = h % 7;
            return h == 0 ? 6 : h - 1;
        }

        // In lich truc nhat trong thang (A,B,C,D,E)
        static void InLichTrucNhatTheoThang(int year, int month)
        {
            char[] peopleArray = new char[] { 'A', 'B', 'C', 'D', 'E' };
            int count = 0;
            int ngayDauTienTrongNam = TinhThuTrongTuan(1, 1, year);
            count = ngayDauTienTrongNam;
            int index = 0;
            for (int i = 0; i <= month - 1; i++)
            {
                for (int k = 1; k <= TinhSoNgayTrongThang(i, year); k++)
                {
                    if (TinhThuTrongTuan(k, i, year) != 0)
                    {
                        index++;
                    }
                    else
                    {
                    }
                    if (index == 4)
                    {
                        index = 0;
                    }
                }
            }
            for (int i = month; i <= month; i++)
            {
                Console.WriteLine("{0,30}", $"Thang {i}");
                Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}{5,-10}{6,-10}", "SUN", "MON", "TUE", "WEN", "THU", "FRI", "SAT");
                int ngayDauTienThang = TinhThuTrongTuan(1, i, year);
                count = ngayDauTienThang;
                for (int j = 0; j < ngayDauTienThang; j++)
                {
                    Console.Write("{0,-10}", " ");
                }
                for (int k = 1; k <= TinhSoNgayTrongThang(i, year); k++)
                {
                    if (i == month)
                    {

                    }
                    if (count % 7 == 0)
                    {
                        Console.WriteLine();
                        count = 0;
                    }
                    if (TinhThuTrongTuan(k, i, year) != 0)
                    {
                        Console.Write("{0,-10}", k.ToString() + "[" + peopleArray[index] + "]");
                        index++;
                    }
                    else
                    {
                        Console.Write("{0,-10}", k.ToString() + "[]");
                    }
                    if (index == 4)
                    {
                        index = 0;
                    }
                    count++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            InLichTrucNhatTheoThang(2006,5);
            Console.ReadKey();
        }
    }
}
