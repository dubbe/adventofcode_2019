using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        //Part1();
        Part2();
    }

    public static void Part1() {
        string[] input = System.IO.File.ReadAllText("input").Split(",");   

        int[] data = Array.ConvertAll<string, int>(input, int.Parse);

        data = InitialState(data);

        string newText = Operate(data);

        System.IO.File.WriteAllText("output_part1", newText);
    }

    public static void Part2() {
        string[] input = System.IO.File.ReadAllText("input").Split(",");   

        var nouns = Enumerable.Range(0, 99).ToList();
        var verbs = Enumerable.Range(0, 99).ToList();
        foreach(var noun in nouns) {
            foreach(var verb in verbs) {
                int[] data = Array.ConvertAll<string, int>(input, int.Parse);
                data = InitialStatePart2(data, noun, verb);
                data = Operate2(data);
                if(data[0] == 19690720) {
                    Console.WriteLine(noun);
                    Console.WriteLine(verb);
                    Console.WriteLine(100*noun+verb);
                    break;
                }
            }
        } 
    }

    public static int[] InitialState(int[] data) {
        data[1] = 12;
        data[2] = 2;
        return data;
    }

    public static int[] InitialStatePart2(int[] data, int a, int b) {
        data[1] = a;
        data[2] = b;
        return data;
    }
    public static string Operate(int[] data) { 
        return string.Join(",", Operate2(data));
    }

    public static int[] Operate2(int[] data) {
        var i=0;
        while(data[i] != 99) {
            var sum = Calculate(data[i], data[data[i+1]], data[data[i+2]]);
            data[data[i+3]] = sum;
            i += 4;
        }
        return data;
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