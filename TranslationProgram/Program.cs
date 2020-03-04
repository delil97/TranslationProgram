using System;
using System.Collections;
using System.Collections.Generic;

namespace TranslationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper().ToLower();
            List<string> allAlphabetsAndSymbols = new List<string>();//sorting all alphabets in a list
             char[] word = input.ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                switch (word[i])
                {  
                    case 'a':
                        allAlphabetsAndSymbols.Add("@");
                        break;
                    case 'b':
                        allAlphabetsAndSymbols.Add("8");
                        break;
                    case 'c':
                        allAlphabetsAndSymbols.Add("(");
                        break;
                    case 'd':
                        allAlphabetsAndSymbols.Add("|)");
                        break;
                    case 'e':
                        allAlphabetsAndSymbols.Add("3");
                        break;
                    case 'f':
                        allAlphabetsAndSymbols.Add("#");
                        break;
                    case 'g':
                        allAlphabetsAndSymbols.Add("6");
                        break;
                    case 'h':
                        allAlphabetsAndSymbols.Add("[-]");
                        break;
                    case 'i':
                        allAlphabetsAndSymbols.Add("|");
                        break;
                    case 'j':
                        allAlphabetsAndSymbols.Add("_|");
                        break;
                    case 'k':
                        allAlphabetsAndSymbols.Add("|<");
                        break;
                    case 'l':
                        allAlphabetsAndSymbols.Add("1");
                        break;
                    case 'm':
                        allAlphabetsAndSymbols.Add(@"[]\/[]");
                        break;
                    case 'n':
                        allAlphabetsAndSymbols.Add(@"[]\[]");
                        break;
                    case 'o':
                        allAlphabetsAndSymbols.Add("0");
                        break;
                    case 'p':
                        allAlphabetsAndSymbols.Add("|D");
                        break;
                    case 'q':
                        allAlphabetsAndSymbols.Add("(,)");
                        break;
                    case 'r':
                        allAlphabetsAndSymbols.Add("|Z");
                        break;
                    case 's':
                        allAlphabetsAndSymbols.Add("$");
                        break;
                    case 't':
                        allAlphabetsAndSymbols.Add("']['");
                        break;
                    case 'u':
                        allAlphabetsAndSymbols.Add("|_|");
                        break;
                    case 'v':
                        allAlphabetsAndSymbols.Add(@"\/");
                        break;
                    case 'w':
                        allAlphabetsAndSymbols.Add(@"\/\/");
                        break;
                    case 'x':
                        allAlphabetsAndSymbols.Add("}{");
                        break;
                    case 'y':
                        allAlphabetsAndSymbols.Add("`/");
                        break;
                    case 'z':
                        allAlphabetsAndSymbols.Add("2");
                        break;
                    default:
                        allAlphabetsAndSymbols.Add(word[i].ToString());
                        break;
                }
            }
            for (int i = 0; i < allAlphabetsAndSymbols.Count; i++) //looping through the list 
            {
                Console.Write(allAlphabetsAndSymbols[i]);
            }

        }
    }
}
