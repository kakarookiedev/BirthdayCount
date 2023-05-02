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
            Console.WriteLine("BIRTHDAY DATE: "+MM+"/"+DD);

            int[] d = new int[2];
            d[0] = int.Parse(MM);
            d[1] = int.Parse(DD);

            TimeSpan dif = TimeSpan.Zero;
            DateTime daysLeft;
            if (new DateTime(dateToday.Year, d[0], d[1]) < dateToday)
            {
                daysLeft = new DateTime(dateToday.Year + 1, d[0], d[1]);
                dif = dateToday.Subtract(daysLeft);
            }else
            {
                daysLeft = new DateTime(dateToday.Year, d[0], d[1]);
                dif = dateToday.Subtract(daysLeft);
            }

            Console.WriteLine($"THERE ARE {dif.ToString("dd")} DAYS LEFT TO YOUR NEXT BIRTHDAY");


        }
    }
}
