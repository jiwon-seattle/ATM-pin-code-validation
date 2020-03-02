using System;

public class ATM
{
    public static void Main()
    {
        Console.WriteLine("Write a ATM PIN number that exactly consists of 4 digits or 6 digits.");
        int.TryParse(Console.ReadLine(), out int userInput);
        Console.WriteLine("user Input is" + userInput);
        int NumLen = userInput.ToString().Length;
        Console.WriteLine("userInput length is " + NumLen);
        Console.WriteLine(CheckNum(NumLen));
    }
    static bool CheckNum(int NumLen)
    {
        if(NumLen == 4 || NumLen == 6)
        {
            return true;
        }
            return false;
    }
}