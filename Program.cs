using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    internal class Program
    {
        static void Main (string[] args)
        {
            Triangle t1 = new Triangle();
            t1.Name = "triangle_1";
            t1.calculateArea(new int[] {100,200});
            t1.getColor();
        }

        static string GetVowels(params string[] input)
        {
            if (input == null || input.Length == 0)
            {
                return string.Empty;
            }

            var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
            return string.Concat(input.SelectMany(word => word.Where(letter => vowels.Contains(char.ToUpper(letter)))));
        }
    }


}
