using System;

namespace BirthdayCount
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateToday = DateTime.Now;

            
            Console.WriteLine("INPUT YOUR BIRTHDAY: (MM)");
            string MM = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("INPUT YOUR BIRTHDAY: (DD)");
            string DD = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(dateToday.Year+"-"+MM+"-"+DD);

            int[] d = new int[2];
            d[0] = int.Parse(MM);
            d[1] = int.Parse(DD);


            DateTime nextBirthday;

            if (new DateTime(dateToday.Year, d[0], d[1]) < dateToday)
            {
                nextBirthday = new DateTime(dateToday.Year + 1, d[0], d[1]);
            }
            else
            {
                nextBirthday = new DateTime(dateToday.Year, d[0], d[1]);
            }

            int daysLeft = (nextBirthday - dateToday).Days;

            Console.WriteLine($"THERE ARE {daysLeft} DAYS LEFT TO YOUR NEXT BIRTHDAY");

        }
    }
}