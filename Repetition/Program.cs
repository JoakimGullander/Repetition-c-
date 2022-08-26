using System;

namespace Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Uppgift 1
            Console.WriteLine("Hello World!");

            //Uppgift 2
            Console.WriteLine("One upon a time");
            Console.WriteLine("I was falling in love");
            Console.WriteLine("Now i'm only falling apart");

            //Uppgift 3
            Console.WriteLine("Once upon a time \nI was falling in love \nNow i'm only falling apart");

            //Uppgift 4
            string message = "Live and sleep!";
            Console.WriteLine(message);

            //Uppgift 5
            string name = "Ada Lovelace";
            Console.WriteLine($"Hej {name}");

            //Uppgift 6
            Console.WriteLine("Give input!");
            string input = Console.ReadLine();
            Console.WriteLine(input);

            //Uppgift 7
            Console.WriteLine("Give input!");
            string input2 = Console.ReadLine();
            Console.WriteLine(input2);
            Console.WriteLine(input2);
            Console.WriteLine(input2);

            //Uppgift 8
            Console.WriteLine("What is your name?");
            string name2 = Console.ReadLine();
            Console.WriteLine($"{name2}!");

            //Uppgift 9
            Console.WriteLine("Hello how are you?");
            Console.ReadLine();
            Console.WriteLine("That's interesting, tell me more");
            Console.ReadLine();
            Console.WriteLine("Thank you for sharing!");

            //uppgift 10
            Console.WriteLine("I will tell a story, but I need some information. \nGive a name for female main character:");
            string storyname = Console.ReadLine();
            Console.WriteLine("Give the character a profession");
            string storyprof = Console.ReadLine();
            Console.WriteLine($"Here is the story: \nOnce upon a time there was a {storyprof} called {storyname} \nOn her way to work, {storyname} often pondered what being {storyprof} meant to them. \n When you work as a {storyprof} you meet interesting people. \n{storyname} enjoys their work as {storyprof}, The end.");

            //Uppgift 11
            int days = 200;
            double hours = 3.5;
            string coding = "It sure is!";
            Console.WriteLine("Days to summer:");
            Console.WriteLine(days);
            Console.WriteLine("Hours to lunch:");
            Console.WriteLine(hours);
            Console.WriteLine("Coding is fun:");
            Console.WriteLine(coding);

            //Uppgift 12
            Console.WriteLine("Give a number!");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"You gave {number}");

            //Uppgift 13
            Console.WriteLine("Give a number!");
            double number2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"You gave {number2}");

            //Uppgift 14
            Console.WriteLine("Give me a boolean!");
            bool answer = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(answer);

            //Uppgift 15
            Console.WriteLine("Give a string!");
            string stri = Console.ReadLine();
            Console.WriteLine("Give a integer!");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Give a double!");
            double doub = double.Parse(Console.ReadLine());
            Console.WriteLine("Give a boolean!");
            bool boo = bool.Parse(Console.ReadLine());
            Console.WriteLine($"Your string: {stri} \nYour integer: {i} \nYour double: {doub} \nYour boolean: {boo}");

            //Uppgift 16
            Console.WriteLine("How many days?");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine(day*86400);

            //Uppgift 17
            Console.WriteLine("Give first number!");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second number!");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your sum is {num1+num2}");

            //Uppgift 18
            Console.WriteLine("Give first number!");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second number!");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give third number!");
            int num5 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your sum is {num3 + num4 + num5}");

            //Uppgift 19
            Console.WriteLine("Give first number!");
            int num6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second number!");
            int num7 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num6} + {num7} = {num6 + num7}");

            //Uppgift 20
            Console.WriteLine("Give first number!");
            int num8 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second number!");
            int num9 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num8} * {num9} = {num8 * num9}");

            //Uppgift 21
            Console.WriteLine("Give first number!");
            double numb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second number!");
            double numb2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The average is {(numb1 + numb2)/2}");

            //Uppgift 22
            Console.WriteLine("Give first number!");
            double numb3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give second number!");
            double numb4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Give third number!");
            double numb5 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The average is {(numb3 + numb4 + numb5) / 3}");


        }
    }
}
