using System;
public class Logical_Programs
{ 
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number to reverse");
        int Num = Convert.ToInt32(Console.ReadLine());//for converting into integer
        int Reverse = 0;
        while (Num > 0)
        {
            int remainder = Num % 10;
            Reverse = (Reverse * 10) + remainder;
            Num = Num / 10;
        }
        Console.WriteLine("Reverse No. is {0}", Reverse);
    }
}