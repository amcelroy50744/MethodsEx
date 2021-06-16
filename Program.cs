using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();
            Console.WriteLine("What is your dog's name?");
            string userDog = Console.ReadLine();
            Console.WriteLine("What color is your dog");
            string userDogColor = Console.ReadLine();
            Console.WriteLine($"There was a dirty man named {userName}, who was {userAge} and smelled like his {userDogColor} dog named {userDog}");
            Console.WriteLine($"{userName} never took baths and loved to dumpster dive with {userDog}");
            Console.WriteLine($"{userDog} and {userName} have not been clean since {userName} was 18 but now he is {userAge}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("give me a nember to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

    

        }
    
        public static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;


            //int sum = num + num2;

            //return sum;

            return num1 + num2;


        }

        public static int Multiply(int x, int y) 
        {
            return x * y;

        
        
        }

    }

}            
