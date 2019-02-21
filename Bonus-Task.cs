using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the text!");
            string text = Console.ReadLine();
            string boldOpening = "<b>";
            string boldClosing = "</b>";

            int[,] array = new int[2, 2];

            Console.WriteLine("Enter the index from where to start bolding the first text part!");
            array[0, 0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length for the first bolded text part!");
            array[0, 1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the index from where to start bolding the second text part!");
            array[1, 0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length for the second bolded text part!");
            array[1, 1] = Convert.ToInt32(Console.ReadLine());

            string result = text.Insert(array[0, 0], boldOpening);
            result = result.Insert(array[0, 0] + array[0, 1] + 3, boldClosing);

            result = result.Insert(array[1, 0] + 7, boldOpening);
            result = result.Insert(array[1, 0] + array[1, 1] + 10, boldClosing);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
