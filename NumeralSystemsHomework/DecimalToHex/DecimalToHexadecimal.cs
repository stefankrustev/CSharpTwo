﻿/*Problem 3. Decimal to hexadecimal
Write a program to convert decimal numbers to their hexadecimal representation.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DecimalToHexadecimal
{
    class DecToHexadec
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter some number: ");
            int number = int.Parse(Console.ReadLine());
            int hex;
            string str = "";
            while (number != 0)
            {
                hex = number & 15;
                switch (hex)
                {
                    case 10:
                        {
                            str = "A" + str;
                            break;
                        }
                    case 11:
                        {
                            str = "B" + str;
                            break;
                        }
                    case 12:
                        {
                            str = "C" + str;
                            break;
                        }
                    case 13:
                        {
                            str = "D" + str;
                            break;
                        }
                    case 14:
                        {
                            str = "E" + str;
                            break;
                        }
                    case 15:
                        {
                            str = "F" + str;
                            break;
                        }
                    default:
                        str = hex.ToString() + str;
                        break;
                }
                number = number >> 4;
            }
            Console.WriteLine("In Hexadecimal: " + str);
        }
    }
}

