using System;
public class Program
{
    public static void Main()
    {
        Part1();
    }

    public static void Part1(){
        string[] input = System.IO.File.ReadAllText("input").Split(",");   

        int[] data = Array.ConvertAll<string, int>(input, int.Parse);

        data = InitialState(data);

        string newText = Operate(data);

        System.IO.File.WriteAllText("output_part1", newText);
    }

    public static int[] InitialState(int[] data) {
        data[1] = 12;
        data[2] = 2;
        return data;
    }
    public static string Operate(int[] data) {
         var i=0;
        while(data[i] != 99) {
            var sum = Calculate(data[i], data[data[i+1]], data[data[i+2]]);
            data[data[i+3]] = sum;
            i += 4;
        }
        return string.Join(",", data);
    }

    public static int Calculate(int operation, int a, int b) {
        switch(operation) {
            case 1:
                return a+b;
            case 2:
                return a*b;
            case 99:
                return 0;
            default:
                throw new Exception();
        }

    }

}