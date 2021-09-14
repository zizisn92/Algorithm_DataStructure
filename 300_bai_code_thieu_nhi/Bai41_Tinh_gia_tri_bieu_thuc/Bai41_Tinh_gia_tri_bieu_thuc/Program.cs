using System;
using System.Collections;
using System.Collections.Generic;

namespace Bai41_Tinh_gia_tri_bieu_thuc
{
    class Program
    {
        static List<string> TinhGiaTriBieuThuc(int kq)
        {
            List<string> lstKq = new List<string>();
            // ((((1 ? 2) ? 3) ? 4) ? 5) ? 6
            char[] toanHang = new char[] { '+', '-', '*', '/' };
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        for (int m = 0; m < 4; m++)
                        {
                            for (int n = 0; n < 4; n++)
                            {
                                string infix = $"((((1{toanHang[i]}2){toanHang[j]}3){toanHang[k]}4){toanHang[m]}5){toanHang[n]}6";
                                string postfix = InfixToPostfix(infix);
                                if(Postfix(postfix)==kq)
                                {
                                    lstKq.Add(infix+=$"={kq}");
                                }
                            }
                        }
                    }
                }
            }
            return lstKq;
        }
        static int ProrityChar(char input)
        {
            if (input == '+' || input == '-')
            {
                return 1;
            }
            else if (input == '*' || input == '/')
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
       

        // Convert Infix --> Prefix (Chuyen bieu thuc trung to sang tien to)
        static string InfixToPrefix(string infix)
        {
            string input = "";
            for (int i = infix.Length-1; i >=0; i--)
            {
                input += infix[i];
            }
            Stack st = new Stack();
            string prefix = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ')')
                {
                    st.Push(input[i]);
                }
                else if (input[i] == '(')
                {

                    while ((Char)(st.Peek()) != ')')
                    {
                        prefix += st.Peek();
                        st.Pop();
                    }
                    st.Pop();
                }
                else if (input[i] == '+' || input[i] == '-' || input[i] == '*' || input[i] == '/')
                {
                    if (st.Count != 0)
                    {
                        while (st.Count != 0 && ProrityChar((Char)(st.Peek())) > ProrityChar(input[i]))
                        {
                            prefix += st.Peek();
                            st.Pop();
                        }
                    }
                    st.Push(input[i]);
                }
                else
                {
                    prefix += input[i];
                }
            }
            while (st.Count > 0)
            {
                prefix += st.Pop();
            }
            string output = "";
            for (int i = prefix.Length-1; i>=0; i--)
            {
                output += prefix[i];
            }
            return output;
        }


        // Convert Infix --> Posfix (Chuyen bieu thuc trung to sang hau to)
        static string InfixToPostfix(string infix)
        {
            Stack st = new Stack();
            string postfix = "";
            for (int i = 0; i < infix.Length; i++)
            {
                if (infix[i] == '(')
                {
                    st.Push(infix[i]);
                }
                else if (infix[i] == ')')
                {

                    while ((Char)(st.Peek()) != '(')
                    {
                        postfix += st.Peek();
                        st.Pop();
                    }
                    st.Pop();
                }
                else if (infix[i] == '+' || infix[i] == '-' || infix[i] == '*' || infix[i] == '/')
                {
                    if (st.Count != 0)
                    {
                        while (st.Count != 0 && ProrityChar((Char)(st.Peek())) >= ProrityChar(infix[i]))
                        {
                            postfix += st.Peek();
                            st.Pop();
                        }
                    }
                    st.Push(infix[i]);
                }
                else
                {
                    postfix += infix[i];
                }
            }
            while (st.Count > 0)
            {
                postfix += st.Pop();
            }
            return postfix;
        }

        // Tinh bieu thuc hau to Posfix
        static double Postfix(string poxfix)
        {
            Stack st = new Stack();
            for (int i = 0; i < poxfix.Length; i++)
            {
                if (poxfix[i] == '+' || poxfix[i] == '-' || poxfix[i] == '*' || poxfix[i] == '/')
                {
                    double number1 = Convert.ToDouble(st.Pop());
                    double number2 = Convert.ToDouble(st.Pop());
                    double kq;
                    if (poxfix[i] == '+')
                    {
                        kq = number2 + number1;
                    }
                    else if (poxfix[i] == '-')
                    {
                        kq = number2 - number1;
                    }
                    else if (poxfix[i] == '*')
                    {
                        kq = number2 * number1;
                    }
                    else
                    {
                        kq = number2 / number1;
                    }

                    st.Push(kq);
                }
                else
                {
                    st.Push(poxfix[i]-'0');
                }
            }

            return (Double)(st.Pop());
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(InfixToPostfix("A*B+C*((D-E)+F)/G"));
            Console.WriteLine(InfixToPostfix("x+(y-z)"));
            Console.WriteLine(InfixToPrefix("x+(y-z)"));
            Console.WriteLine(Postfix(InfixToPostfix("((((1+2)+3)/4)+5)*6")));
            var kq=TinhGiaTriBieuThuc(36);
            for (int i = 0; i < kq.Count; i++)
            {
                Console.WriteLine(kq[i]);
            }
            Console.ReadKey();
            //Console.WriteLine("Hello World!");
        }
    }
}
