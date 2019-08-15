using System;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


private static void Nagarro()
        {
            string input = "this_is_c_sharp";
            Console.WriteLine("Input :- {0}\n", input);
            while (input.Contains("_"))
            {
                string toUp;
                int ind = input.IndexOf("_");
                toUp = input[ind + 1].ToString().ToUpper();
                //input = input.Replace(input[ind + 1].ToString(), input[ind + 1].ToString().ToUpper());
                input = input.Remove(ind + 1, 1);
                input = input.Insert(ind + 1, toUp);
                input = input.Remove(ind, 1);
            }
            Console.WriteLine("Output :- {0}\n", input);
            Console.WriteLine();
            Console.WriteLine("Input :- {0}\n", input);
            foreach (Char c in input)
            {
                if (char.IsUpper(c))
                {
                    //int ind = input.IndexOf(c);
                    input = input.Insert(input.IndexOf(c), "_");
                }
            }
            //input = input.Select(c => char.IsUpper(c)? input.Insert(input.IndexOf(c), "_"));
            input = input.ToLower();
            Console.WriteLine("Output :- {0}\n", input);
        }
