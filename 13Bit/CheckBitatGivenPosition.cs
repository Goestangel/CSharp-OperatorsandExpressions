using System;

class CheckBitatGivenPosition   
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//in given integer number n, has value of 1.

{
    static void Main()
    {
        Console.Write("Enter your number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Check bit of position: ");
        int position = int.Parse(Console.ReadLine());

        int moveBit = number >> position;
        int foundBit = moveBit & 1;

        bool isOne = foundBit == 1;

        Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        Console.WriteLine("Bit of position {0} is '1' = {1}", position, isOne);
    }
}
