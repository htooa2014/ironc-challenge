using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IronCSharpChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine ("Hello Mono World");
            string testing = string.Empty;
            testing = OldPhonePad("8 88777444666*664#");
            Console.WriteLine(testing);

            //33#   ->  E
            //227*#  -> B
            //4433555 555666#   -> HELLO
        }

        public static string OldPhonePad(string inputt)
        {
            string temp = string.Empty;
            for (int i = 0;
                    i < inputt.Length - 1; i++)
            {

                // Counting occurrences of s[i]
                int count = 1;
                while (inputt[i] == inputt[i + 1])
                {
                    i++;
                    count++;
                    if (i + 1 == inputt.Length)
                        break;
                }


                //Console.Write(inputt[i] + "" + count + " ");


                temp += convertCharacter(inputt[i].ToString(), count);
            }


            return temp;
        }

        public static string convertCharacter(string input, int count)
        {
            string temp = string.Empty;
            switch (input)
            {
                case "1":
                    if (count == 1) temp = "&";
                    else if (count == 2) temp = "'";
                    else temp = "(";
                    break;
                case "2":
                    if (count == 1) temp = "A";
                    else if (count == 2) temp = "B";
                    else temp = "C";
                    break;
                case "3":
                    if (count == 1) temp = "D";
                    else if (count == 2) temp = "E";
                    else temp = "F";
                    break;
                case "4":
                    if (count == 1) temp = "G";
                    else if (count == 2) temp = "H";
                    else temp = "I";
                    break;
                case "5":
                    if (count == 1) temp = "J";
                    else if (count == 2) temp = "K";
                    else temp = "L";
                    break;
                case "6":
                    if (count == 1) temp = "M";
                    else if (count == 2) temp = "N";
                    else temp = "O";
                    break;
                case "7":
                    if (count == 1) temp = "P";
                    else if (count == 2) temp = "Q";
                    else if (count == 3) temp = "R";
                    else temp = "S";
                    break;
                case "8":
                    if (count == 1) temp = "T";
                    else if (count == 2) temp = "U";
                    else temp = "V";
                    break;
                case "9":
                    if (count == 1) temp = "W";
                    else if (count == 2) temp = "X";
                    else if (count == 3) temp = "Y";
                    else temp = "Z";
                    break;
                   
                default:
                    temp = "";
                    break;
            }

            return temp;
        }
    }
}
