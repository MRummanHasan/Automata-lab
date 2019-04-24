using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringCombinationGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            String alphabet;
            int maxLength;

            //Console.ReadLine

            Console.WriteLine("Enter the set of alphabet: ");
            alphabet = Console.ReadLine();

            Console.WriteLine("Enter the maximum Length of Strings to generate: ");
            maxLength = Convert.ToInt32(Console.ReadLine());

            String[] generatedStrings = new String[(int)Math.Pow(alphabet.Length, maxLength)];

            for (int i = 0; i < alphabet.Length; i++)
            {
                generatedStrings[i] = alphabet[i].ToString();
            }

            int newStringsCounter = alphabet.Length;
            int j;
            for (int i = 0; i < generatedStrings.Length; i++)
            {
                for (j = 0; j < generatedStrings.Length - newStringsCounter && ((generatedStrings[i] + generatedStrings[j]).ToString().Length <= maxLength); j++)
                        generatedStrings[j + newStringsCounter] = generatedStrings[i] + generatedStrings[j];

                newStringsCounter += j;
            }

            /*//Converting to List to sort
            List<String> generatedStringsToList = new ArrayList(generatedStrings.Length);
            Collections.addAll( generatedStringsToList, generatedStrings );
            Collections.sort(generatedStringsToList);

            for (String string: generatedStringsToList)
            {
                System.out.println(string);
            }
            */

            Console.WriteLine(generatedStrings.Length + " Strings generated");
            for (int i = 0; i < generatedStrings.Length; i++)
                Console.WriteLine("{0} {1}", i + 1, generatedStrings[i]);

            Console.ReadKey();

        }
    }
}
