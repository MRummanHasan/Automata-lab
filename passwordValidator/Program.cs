using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lowerLetter = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o' };
            var upperLetter = new[] { 'A', 'B', 'C', 'D', 'E' };
            var specialCharacters = new[] { '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '+' };
            var digits = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            string pass = Console.ReadLine();

            if (pass.Length >= 6)
                if (lowerLetter.Any(x => pass.Contains(x)))                
                    if (upperLetter.Any(X => pass.Contains(X)))
                        if (specialCharacters.Any(sc => pass.Contains(sc)))
                            if (digits.Any(d => pass.Contains(d.ToString())))
                            {
                                Console.WriteLine("VALID Password");
                            }
                            else
                            {
                                Console.WriteLine("Must contain atleast 1 Digit");
                            }
                        else
                            Console.WriteLine("Must contain atleast 1 Special Character");
                    else
                        Console.WriteLine("Must contain atleast 1 Upper letter");
                
                else
                    Console.WriteLine("Must contain atleast 1 Lower letter");
            
            else
                Console.WriteLine("Length must be atleast 6");


            Console.ReadKey();
        }
    }
}