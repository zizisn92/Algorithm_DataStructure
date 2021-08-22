using System;

namespace Bai11_Tro_choi_bao_da_keo
{
    class Program
    {
        static void Game()
        {
            // b-d-k
            int scoreHuman = 0;
            int scoreComputer = 0;
            char[] lstInput = new char[] { 'b', 'd', 'k' };
           
            while(true)
            {
                Console.Write("Nhap ky tu (b-d-k), ky tu khac de thoat:");
                char inputHuman = Char.Parse(Console.ReadLine());
                if(inputHuman!='b'&& inputHuman!='d'&& inputHuman!='k')
                {
                    break;
                }
                Random rd = new Random();
                int index = rd.Next(0, lstInput.Length );
                char inputComputer = lstInput[index];
                Console.WriteLine($"Computer:{inputComputer}");
                if (inputHuman == 'b')
                {
                    if (inputComputer == 'k')
                    {
                        scoreHuman++;
                    }
                    else if (inputComputer == 'd')
                    {
                        scoreComputer++;
                    }
                }
                if (inputHuman == 'k')
                {
                    if (inputComputer == 'd')
                    {
                        scoreHuman++;
                    }
                    else if (inputComputer == 'b')
                    {
                        scoreComputer++;
                    }
                }
                if (inputHuman == 'd')
                {
                    if (inputComputer == 'b')
                    {
                        scoreHuman++;
                    }
                    else if (inputComputer == 'k')
                    {
                        scoreComputer++;
                    }
                }
                Console.WriteLine($"Ti so human - computer: {scoreHuman} - {scoreComputer}");
            }
           
        }

        static void Main(string[] args)
        {
            Game();
            //Console.ReadKey();
           Console.WriteLine("End");
        }
    }
}
