using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

           bool canIVote = true;

            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            Console.WriteLine("Biggest long : {0}", long.MaxValue);
            Console.WriteLine("Smallest long : {0}", long.MinValue);

            decimal decPiVal = 3.111566376398636389338863M;
            decimal decBignum = 3.0000000000000002234424442M;
            Console.WriteLine("DEC : Pi + bigNum = {0}",
                decPiVal + decBignum);

            Console.WriteLine("Biggest decimal : {0}", decimal.MaxValue);
        }
    }
}