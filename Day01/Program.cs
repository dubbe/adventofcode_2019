using System;
class Program
{
    static void Main()
    {
        string[] lines = System.IO.File.ReadAllLines("input"); 
        int amount = 0;
        foreach(string line in lines) {
            amount =  amount + GetFuelAmount(Int32.Parse(line));
        }
        Console.WriteLine(amount);
    }

    public static int GetFuelAmount(int mass, int currentFuel = 0) {
        int requiredFule = (int)Math.Floor((decimal)mass/3)-2;
        if(requiredFule <= 0) {
            return currentFuel;
        }
        return GetFuelAmount(requiredFule, requiredFule + currentFuel);
    }
}