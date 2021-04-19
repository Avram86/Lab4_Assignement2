using System;
using System.Collections.Generic;

namespace Assignement2
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignement2();
        }
        public static void Assignement2()
        {
            //assignment2
            Console.WriteLine("Please write a number: ");
            string input = Console.ReadLine();
            bool x = int.TryParse(input, out int k);
            if (x == true)
            {
                List<string> cuvintele = new List<string>();
                for (int i = 0; i < k; i++)
                {
                    Here:
                    
                    Console.WriteLine("Please write three words separated by '|' ");
                    var input2 = Console.ReadLine();

                    if (!input2.Contains('|'))
                    {
                        Console.WriteLine("The text was in a wrong format!");
                        break;
                    }
                    else
                    {
                        string[] words = input2.Split('|');
                        if (words.Length>3) 
                        {
                            Console.WriteLine("Please enter only three words per line! Thank you!");
                            goto Here;
                        }
                        else 
                        {
                            cuvintele.Add(input2.Substring(0, input2.IndexOf('|')));
                            do
                            {
                                input2 = input2.Substring(input2.IndexOf('|') + 1);
                                if (input2.Contains('|') == false)
                                {
                                    cuvintele.Add(input2.Substring(0));
                                    break;
                                }
                                else
                                {
                                    cuvintele.Add(input2.Substring(0, input2.IndexOf('|')));
                                }
                            } while (input2 != null);
                        }
                    }
                }
                //Console.Write(string.Format($"{cuvintele[0]}\t{cuvintele[1]}\t{cuvintele[2]}\n"));
                //Console.Write(string.Format($"{cuvintele[3]}\t{cuvintele[4]}\t{cuvintele[5]}\n"));
                //Console.Write(string.Format($"{cuvintele[6]}\t{cuvintele[7]}\t{cuvintele[8]}\n"));

                Console.WriteLine(string.Format($"{cuvintele[0].PadRight(10)} {cuvintele[1].PadRight(10)} {cuvintele[2].PadRight(10)}"));
                Console.WriteLine(string.Format($"{cuvintele[3].PadRight(10)} {cuvintele[4].PadRight(10)} {cuvintele[5].PadRight(10)}"));
                Console.WriteLine(string.Format($"{cuvintele[6].PadRight(10)} {cuvintele[7].PadRight(10)} {cuvintele[8].PadRight(10)}"));

                //???? cu PadRight
                /*output
                 aaa     bbb     ccc
                ddd     eee     fff
                ggg     hhh     iii*/
            }
            else
            {
                Console.WriteLine("The text you just typed is not a number!");
            }


            

        }

    }
}
