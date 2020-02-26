using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // console greeting
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hi {name}");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan", "Bat" };
            var index = new Random().Next(animals.Length);

            Console.WriteLine("What's your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine($"Would you like a {color} {animals[index]}?");

            // animal syllables 
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
            foreach (var animal in animals)
            {
                var countOfVowels = 0;
                foreach (var animalChar in animal)
                {
                    foreach (var vowel in vowels)
                    {
                        if (vowel == animalChar)
                        {
                            countOfVowels++;
                        }
                    }
                }
                if (countOfVowels >= 2)
                {
                    Console.WriteLine(animal);
                    Console.ReadKey();
                }
            }

            // command line arguments
            //var arguments = new []{ "Southern", "British", "Australian"};

            Console.WriteLine($"Choose a dialect: {args[0]}, {args[1]}, {args[2]}");
            var dialect = Console.ReadLine();
            foreach (var argument in args)
            {
                if (argument.ToLower() == dialect.ToLower())
                {
                    switch (dialect)
                    {
                        case "Southern":
                            Console.WriteLine("Hey Y'all!");
                            break;

                        case "British":
                            Console.WriteLine("Cheers mate");
                            break;
                        case "Australian":
                            Console.WriteLine("G'day mate");
                            break;
                        default:
                            Console.WriteLine("Oops! You have to choose one of MY dialects!");
                            break;
                    }
                }
            } 
            Console.ReadLine();

            //ConsoleKeyInfo enteredKey;

            //do
            //{
            //    enteredKey = Console.ReadKey();
            //    Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");

            //} while (enteredKey.Key != ConsoleKey.Escape);

            //string sentence;

            //do
            //{
            //    Console.WriteLine("Type in a sentence. Press enter when done.");
            //    sentence = Console.ReadLine();
            //    Console.WriteLine($"You entered the sentence: {sentence}");

            //} while (sentence != "quit");

        }
    }
}
