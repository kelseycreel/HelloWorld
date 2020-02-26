using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //// console greeting
            //Console.WriteLine("Howdy Y'all!!");
            //Console.ReadKey(); // What happens if you run the app without this line?

            //// animal syllables 
            //var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Bat" };
            //var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            //foreach (var animal in animals)
            //{
            //    var countOfVowels = 0;
            //    foreach (var animalChar in animal)
            //    {
            //        foreach (var vowel in vowels)
            //        {
            //            if (vowel == animalChar)
            //            {
            //                countOfVowels++;
            //            }
            //        }
            //    }
            //    if (countOfVowels >= 2)
            //    {
            //        Console.WriteLine(animal);
            //        Console.ReadLine();
            //    }
            //}

            // command line arguments
            //var arguments = new []{ "Southern", "British", "Australian"};

            Console.WriteLine($"Choose a dialect: {args[0]}, {args[1]}, {args[2]}");
            var dialect = Console.ReadLine();
            var otherDialect = false;
            foreach (var argument in args)
            {
                if (argument.ToLower() == dialect.ToLower())
                {
                    Console.WriteLine($"Your dialect: {dialect}");
                    otherDialect = false;
                    break;
                }
                else
                {
                    otherDialect = true;
                }
            } 
            if (otherDialect)
            {
                Console.WriteLine("Oops! You have to choose one of MY dialects!");
            }
            Console.ReadLine();
        }
    }
}
