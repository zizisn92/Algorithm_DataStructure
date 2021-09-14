using System;

namespace Bai139_Nen_run_length
{
    class Program
    {
        static string NenChuoi(string chuoi)
        {
            int count = 0;
            string output = "";
            int end = 0;
            for (int i = 0; i < chuoi.Length - 1; i++)
            {
                count++;
                // Kiem tra 2 phan tu canh nhau khac nhau thi dung lai
                if (chuoi[i] != chuoi[i + 1])
                {
                    if (count != 1)
                    {
                        output += count.ToString() + chuoi[i];
                    }
                    else
                    {
                        output += chuoi[i];
                    }
                    // Vi tri cuoi cung cua 2 phan tu canh nhau khac nhau trong chuoi
                    end = i + 1;
                    count = 0;
                }

            }
            // Them kq chuoi con lai tinh tu vi tri end
            if (chuoi.Length - end != 1)
            {
                output += (chuoi.Length - end).ToString() + chuoi[end];
            }
            else
            {
                output += chuoi[end];
            }
            return output;
        }

        static string GiaiNenChuoi(string chuoi)
        {
            string output = "";
            for (int i = 0; i < chuoi.Length - 1; i++)
            {
                // Kiem tra phan tu trong day co phai la so khong?
                if (Char.IsNumber(chuoi[i]))
                {
                    // Neu so o vi tri thu 2 thi cong them phan tu dau tien vao chuoi ket qua
                    if(i==1)
                    {
                        output += chuoi[0];
                    }
                    var length = "";
                    // Vong Lap tinh so ky tu chuoi - Truong hop chuoi co > 10 ky tu - VD aa12abc
                    while (Char.IsNumber(chuoi[i]))
                    {
                        length += chuoi[i];
                        i++;
                    }
                    // Vong lap cong so ky tu nhan duoc vao ket qua cuoi cung
                    for (int j = 0; j < Int32.Parse(length); j++)
                    {
                        output += chuoi[i];
                    }
                    // Neu doan chuoi cuoi cung
                    //i--;
                }
                // Xac dinh chuoi cuoi cung co > 1 phan tu VD: b3c / chi check khi 2 phan tu cuoi cung trong chuoi khac nhau VD: 3abc
                if(i<chuoi.Length-1)
                {
                    // Kiem tra 2 phan tu canh nhau deu khong phai la so
                    if (Char.IsNumber(chuoi[i]) == false && Char.IsNumber(chuoi[i + 1]) == false)
                    {
                        // Neu phan tu dau tien va thu 2 khong la so + them phan tu dau tien vao kq
                        if (i == 0)
                        {
                            output += chuoi[i];
                        }
                        output += chuoi[i + 1];
                    }
                }
        
            }
            return output;
        }
        static void Main(string[] args)
        {
            string chuoi = "aaabccccddddeeeeeeeeeeeefghhhhhhiiiiaaaabbbbbbccc";
            Console.WriteLine($"Chuoi goc: {chuoi}");
            var nenChuoi = NenChuoi(chuoi);
            double tiLe = (double)nenChuoi.Length / (double)chuoi.Length * 100;
            Console.WriteLine($"Nen chuoi: {nenChuoi}" + " [" + Math.Round(tiLe, 1) + "%]");
            var giaiNenChuoi = GiaiNenChuoi(nenChuoi);
            Console.WriteLine($"Giai nen Chuoi: {giaiNenChuoi}");
            Console.ReadKey();
        }
    }
}
