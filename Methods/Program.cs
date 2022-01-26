using System;

namespace Methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("how old are you?");
            string age = Console.ReadLine();

            Console.WriteLine("what is your dog name");
            string userDogName = Console.ReadLine();

            Console.WriteLine("what color is your dog?");
            string userDogColor = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, he was{age} years old.");
            Console.WriteLine($"He had a {userDogColor}, dog named{userDogName}.");
            Console.WriteLine($"{userName} loved {userDogName} but he did not like being {age} years old,");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse( Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse( Console.ReadLine());

            int sum = Sum(num1, num2,2,3,5,7);
            Console.WriteLine($"The sum is:{sum}");

            Console.WriteLine("Give me a number to add");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = multiply(num1, num2);
            Console.WriteLine($"The product is:{product}");






        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }
        
        public static int multiply(int x , int y )
        {
            return x * y;
        }
    }

}