using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int InputNum= -1;
        Console.WriteLine("Please Enter a Number, Type 0 to end.");
        

        while (InputNum !=0)
        {
            Console.Write("Please Enter a Number:");
            //string Numtyped = Console.ReadLine();
            //InputNum = int.Parse(Numtyped);
            InputNum = int.Parse(Console.ReadLine());
            if (InputNum!=0)
            {
                numbers.Add(InputNum);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum+=number;
        }
        Console.WriteLine($"The Sum is {sum}");

        float average = ((float)sum)/numbers.Count;
        Console.WriteLine($"The Average of the Numbers is {average}");

        int maxnum = numbers[0];
        foreach(int number in numbers)
        {
            if(number>maxnum)
            {
                maxnum=number;
            }
        }

        Console.WriteLine($"The Biggest Number is {maxnum}");
    }
}