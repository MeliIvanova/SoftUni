using System;

namespace L04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int cetury = int.Parse(Console.ReadLine());
            int years = cetury * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;

            Console.WriteLine($"{cetury} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
 