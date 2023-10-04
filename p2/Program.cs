using System;
using System.Globalization;

namespace p2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("introduceti string-ul");
            var sirul = Console.ReadLine();

            Console.WriteLine($"vocale {GetNoOfVowles(sirul)}");

            Console.WriteLine(GetNormalisedString(sirul));
            Console.WriteLine("introduceti substring-ul");
            var subsirul = Console.ReadLine();
            int pozitia = sirul.IndexOf(subsirul);
            if (pozitia < 0)
            {
                Console.WriteLine("sirul nu a fost gasit");
            }
            else
            {
                Console.WriteLine($"pozitia este {pozitia}");
            }
        }
        static int GetNoOfVowles(string sirul)
        {
            string vocale = "aeiouAEIOU";
            int noOfVowels = 0;

            foreach (var caracter in sirul)
            {
                if (vocale.Contains(caracter))
                {
                    noOfVowels++;
                }
            }
            return noOfVowels;
        }

        static string GetNormalisedWToTitleCase(string sirul)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            return myTI.ToTitleCase(sirul);
        }
        static string GetNormalisedString(string sirul)
        {
            string[] cuvinte = sirul.Split(' ');
            string result = string.Empty;

            for(int i = 0; i < cuvinte.Length; i++)
            {
                var cuvant = cuvinte[i];

                cuvinte[i] = cuvinte[i].ToLowerInvariant();
                cuvinte[i] = char.ToUpper(cuvinte[i][0]) + cuvinte[i].Substring(1);
                result += cuvinte[i] + " ";
            }

            return result;
        }

        static bool EstePalindrom(string sirul)
        { 
            for (var i = 0; i < sirul.Length / 2; i++)
            {
                if (sirul[i] != sirul[sirul.Length - 1 - i])
                    return false;
            }
            
            return true;
        }
        static bool EstePalindrom2(string sirul)
        {
            var left = 0;
            var right = sirul.Length - 1;
            while (left < right)
            {
                if (sirul[left] != sirul[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;            
        }
    }
}
