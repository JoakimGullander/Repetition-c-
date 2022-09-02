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
            int oops = int.Parse(Console.ReadLine());
            Console.WriteLine("Give a double!");
            double doub = double.Parse(Console.ReadLine());
            Console.WriteLine("Give a boolean!");
            bool boo = bool.Parse(Console.ReadLine());
            Console.WriteLine($"Your string: {stri} \nYour integer: {oops} \nYour double: {doub} \nYour boolean: {boo}");

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

            //Uppgift 23
            Console.WriteLine("Give first number!");
            double d1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Give second number");
            double d2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{d1} + {d2} = {d1 + d2}");
            Console.WriteLine($"{d1} - {d2} = {d1 - d2}");
            Console.WriteLine($"{d1} * {d2} = {d1 * d2}");
            Console.WriteLine($"{d1} / {d2} = {d1 / d2}");

            //Uppgift 24
            Console.WriteLine("Your speed:");
            double speed = double.Parse(Console.ReadLine());
            if (speed > 120)
            {
                Console.WriteLine("Speeding!");
            }

            //Uppgift 25
            Console.WriteLine("Give a number:");
            double orwell = double.Parse(Console.ReadLine());
            if (orwell == 1984)
            {
                Console.WriteLine("Orwell");
            }

            //Uppgift 26
            Console.WriteLine("Give your birthyear:");
            double birth = double.Parse(Console.ReadLine());
            if (birth < 1900)
            {
                Console.WriteLine("You're old");
            }

            //Uppgift 27
            Console.WriteLine("Give a number:");
            double posneg = double.Parse(Console.ReadLine());
            if (posneg >= 0)
            {
                Console.WriteLine("It is positive");
            }
            else
            {
                Console.WriteLine("It is negative");
            }

            //Uppgift 28
            Console.WriteLine("How old are you?");
            double adult = double.Parse(Console.ReadLine());
            if (adult >= 18)
            {
                Console.WriteLine("You're an adult!");
            }
            else
            {
                Console.WriteLine("You're underage!");
            }


            //Uppgift 29
            Console.WriteLine("Give first number!");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Give second number");
            double second = double.Parse(Console.ReadLine());
            if (first > second)
            {
                Console.WriteLine($"The larger number is {first}!");
            }
            else if (second > first) 
            {
                Console.WriteLine($"The larger number is {second}!");
            }
            else
            {
                Console.WriteLine($"They are equal!");
            }

            //Uppgift 30
            Console.WriteLine("Give your percent [0-100]:");
            double result = double.Parse(Console.ReadLine());
            if (result < 0)
            {
                Console.WriteLine("Impossible!");
            }else if (result < 50)
            {
                Console.WriteLine("Fail");
            }else if (result < 60)
            {
                Console.WriteLine("1");
            }else if (result < 70)
            {
                Console.WriteLine("2");
            }else if (result < 80)
            {
                Console.WriteLine("3");
            }else if (result < 90)
            {
                Console.WriteLine("4");
            }else
            {
                Console.WriteLine("Outstanding!");
            }

            //Uppgift 31
            Console.WriteLine("Give a number:");
            double evod = double.Parse(Console.ReadLine());
            if (evod % 2 == 0)
            {
                Console.WriteLine("It is even.");
            }else
            {
                Console.WriteLine("It is odd.");
            }

            //Uppgift 32
            Console.WriteLine("Speak, friend and enter!");
            string mellon = Console.ReadLine();
            if (mellon == "Mellon")
            {
                Console.WriteLine("Welcome, friend");
            }else
            {
                Console.WriteLine("They've got a cave troll");
            }

            //Uppgift 33
            Console.WriteLine("Give first string:");
            string echo1 = Console.ReadLine();
            Console.WriteLine("Give second string:");
            string echo2 = Console.ReadLine();
            if (echo1 == echo2)
            {
                Console.WriteLine("Echo");
            }else
            {
                Console.WriteLine("Nej");
            }

            //Uppgift 34
            Console.WriteLine("Do you want to continue?");
            string contexit = Console.ReadLine();
            contexit = contexit.ToLower();
            while (contexit != "nej")
            {
                Console.WriteLine("Do you want to continue?");
                contexit = Console.ReadLine();
                contexit = contexit.ToLower();
            }

            //Uppgift 35
            Console.WriteLine("Give a number:");
            double fotw = double.Parse(Console.ReadLine());
            while (fotw != 42)
            {
                Console.WriteLine("Give a numer:");
                fotw = double.Parse(Console.ReadLine());
            }

            //Uppgift 36
            Console.WriteLine("Give a number:");
            double power = double.Parse(Console.ReadLine());
            if (power < 0)
            {
                Console.WriteLine("That is negative");
            }else if (power > 0)
            {
                Console.WriteLine(power*power);
            }

            //Uppgift 37
            int noll = 1;
            int plus = 0;
            while (noll != 0)
            {
                Console.WriteLine("Give a number:");
                noll = int.Parse(Console.ReadLine());
                plus++;
            }
            Console.WriteLine($"Total numbers: {plus}");

            //Uppgift 38
            int noll2 = 1;
            int plus2 = 0;
            while (noll2 != 0)
            {
                Console.WriteLine("Give a number:");
                noll2 = int.Parse(Console.ReadLine());
                if (noll2 < 0)
                    plus2++;
            }
            Console.WriteLine($"Total negative numbers: {plus2}");

            //Uppgift 39
            int noll3 = 1;
            int sum = 0;
            while (noll3 != 0)
            {
                Console.WriteLine("Give a number:");
                noll3 = int.Parse(Console.ReadLine());
                sum += noll3;
            }
            Console.WriteLine($"Total sum of numbers: {sum}"); 
            
            //Uppgift 40
            int noll4 = 1;
            int plus3 = 0;
            int sum2 = 0;
            while (noll4 != 0)
            {
                Console.WriteLine("Give a number:");
                noll4 = int.Parse(Console.ReadLine());
                sum2 += noll4;
                plus3++;
            }
            Console.WriteLine($"Total sum of numbers: {sum}");
            Console.WriteLine($"Total numbers: {plus3}");
            
            //Uppgift 41
            Console.WriteLine("First number:");
            int whole = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            int whole2 = int.Parse(Console.ReadLine());
            if (whole == whole2)
            {
                int whole3 = whole + whole2;
                Console.WriteLine(whole3 * 4);
            }

            //Uppgift 42
            Console.WriteLine("Choose n:");
            int n = int.Parse(Console.ReadLine());
            if (n <= 63)
            {
                Console.WriteLine(63-n);
            }
            else
            {
                Console.WriteLine((n-63)*2);
            }

            //Uppgift 43
            Console.WriteLine("First number:");
            int sajeel = int.Parse(Console.ReadLine());
            Console.WriteLine("Second number:");
            int sajeel2 = int.Parse(Console.ReadLine());
            if (sajeel == 23 || sajeel2 == 23 || sajeel + sajeel2 == 23)
            {
                bool sajeel3 = true;
                Console.WriteLine(sajeel3);
            }

            //Uppgift 44
            Console.WriteLine("Number:");
            int divid = int.Parse(Console.ReadLine());
            if (divid % 10 == 0)
            {
                bool divi = true;
                Console.WriteLine(divi);
            }

            //Uppgift 45
            Console.WriteLine("String:");
            string check = Console.ReadLine();
            if (check[0] == 'i' && check[1] == 'f')
            {
                Console.WriteLine(check);
            }else
            {
                Console.WriteLine($"if {check}");
            }

            //Uppgift 46
            Console.WriteLine("How many numbers?");
            int i1 = int.Parse(Console.ReadLine());
            int[] array = new int[i1];
            for (int i = 0; i < i1; i++)
            {
                Console.WriteLine($"Give number {i + 1}");
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            Console.WriteLine(array[i1 - 1]);




            // Svår Uppgift 1 
            int size = 5;
            int[] arr = new int[size];
            Console.WriteLine("Array:");
            for (int i = 0; i < size; i++)
            {
                int numb = int.Parse(Console.ReadLine());
                arr[i] = numb;
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            int[] sortedArr = sort(arr);
            Console.WriteLine("\nSorted Array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{sortedArr[i]} ");
            }
        }

        static int[] sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int saved = arr[i];
                        arr[i] = arr[j];
                        arr[j] = saved;
                    }
                }
            }
            return arr;
        }
    }
}