using System;

namespace Bai28_Mo_Phong_Ham_Round_Excel
{
    class Program
    {
        static void LamTronSoThuc(double number, int accuracy)
        {
            string kq = "";
            string[] arr = number.ToString().Split('.');
            int phanNguyen = Int32.Parse(arr[0]);
            int phanThapPhan = Int32.Parse(arr[1]);
            if (accuracy > 0)
            {
                int count = 0;

                // Tim phan thap phan co n(accuracy) chu so +1
                while (count < arr[1].Length - accuracy - 1)
                {
                    phanThapPhan /= 10;
                    count++;
                }
                // Tim so ben phai gan nhat sau so thap phan can lam tron, neu so do >=5 thi so thap phan +1, nguoc lai giu nguyen
                if (phanThapPhan % 10 >= 5)
                {
                    phanThapPhan /= 10;
                    phanThapPhan += 1;
                }
                else
                {
                    phanThapPhan /= 10;
                }
                kq = phanNguyen.ToString() + '.' + phanThapPhan.ToString();
            }
            else if (accuracy == 0)
            {
                int x = 1;

                // Tim so lan nhat lam tron sau dau phay VD:932 --> 1000, 12 --> 100
                for (int i = 0; i < arr[1].Length; i++)
                {
                    x *= 10;
                }

                // So sanh phan thap phan voi so da tim tren / 2 VD: 932 >1000/2 thi phan nguyen them 1 don vi
                if (phanThapPhan >= x / 2)
                {
                    if (phanNguyen < 0)
                    {
                        phanNguyen -= 1;
                    }
                    else
                    {
                        phanNguyen += 1;
                    }
                }
                kq = phanNguyen.ToString();
            }
            else
            {
                int x = 1;
                // Dua do chinh xac tach tiep phan nguyen 
                for (int i = 0; i < accuracy * (-1); i++)
                {
                    x *= 10;
                }
                double y = (double)phanNguyen / x;
                string[] arrSub = y.ToString().Split('.');
                int phanNguyenSub = Int32.Parse(arrSub[0]);
                int phanThapPhanSub = Int32.Parse(arrSub[1]);
                // So sanh phan thap phan voi so da tim tren / 2 VD: 53 >100/2 thi phan nguyen them 1 don vi
                if (phanThapPhanSub >= x / 2)
                {
                    if (phanNguyenSub < 0)
                    {
                        phanNguyenSub -= 1;
                    }
                    else
                    {
                        phanNguyenSub += 1;
                    }
                }
                kq = phanNguyenSub.ToString();

                // Them ky tu 0 vao sau so nguyen tren ra kq lam tron
                while (x / 10 > 0)
                {
                    kq += '0';
                    x /= 10;
                }
            }
            Console.WriteLine($"Kq lam tron la: {kq}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so thu:");
            double soThuc = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap do chinh xac:");
            int doChinhXac = Int32.Parse(Console.ReadLine());
            LamTronSoThuc(soThuc, doChinhXac);
            Console.ReadKey();
        }
    }
}
