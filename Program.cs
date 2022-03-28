// ett enklare program med nedanstående funktioner

using System;

namespace executeFunctions
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input = 0;
            while (true)
            {
                Console.WriteLine(" Enter the function number to be executed from the assignment menu(1-16):");
                Console.WriteLine("1. helloWorld function");
                Console.WriteLine("2. enterPersonalDetails function");
                Console.WriteLine("3. changingTextColors function");
                Console.WriteLine("4. todaysDate function");
                Console.WriteLine("5. biggestOfTwoNumbers function");
                Console.WriteLine("6. guesstheNumber function");
                Console.WriteLine("7. fileWrite function");
                Console.WriteLine("8. fileRead function");
                Console.WriteLine("9. findingroots function");
                Console.WriteLine("10. multiplicationTable function");
                Console.WriteLine("11. arrangingArrays function");
                Console.WriteLine("12. palindrome function");
                Console.WriteLine("13. numbersBetween function");
                Console.WriteLine("14. evenOdd function");
                Console.WriteLine("15. addIntegers function");
                Console.WriteLine("16. characteristics function");
                Console.WriteLine("0. exit function");

                int menuChoice = int.Parse(Console.ReadLine());


                switch (menuChoice)
                {
                    case 1:
                        helloWorld();
                        break;

                    case 2:
                        enterPersonalDetails();
                        break;

                    case 3:
                        changingTextColors();
                        break;

                    case 4:
                        todaysDate();
                        break;

                    case 5:
                        biggestOfTwoNumbers();
                        break;

                    case 6:
                        guesstheNumber();
                        break;

                    case 7:
                        fileWrite();
                        break;

                    case 8:
                        fileRead();
                        break;

                    case 9:
                        findingroots();
                        break;

                    case 10:
                        multiplicationTable();
                        break;

                    case 11:
                        arrangingArrays();
                        break;

                    case 12:
                        palindrome();
                        break;

                    case 13:
                        numbersBetween();
                        break;

                    case 14:
                        evenOdd();
                        break;

                    case 15:
                        addIntegers();
                        break;

                    case 16:
                        characteristics();
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Number not managed");
                        break;
                }
                input++;
                if (input < 20)
                    continue;
                else
                    break;
            }
        }  // Main program ends here




        // 1. Funktion som skriver ut ”Hello World” i konsolen
        public static void helloWorld()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

        // 2. Funktion som tar in input från användaren (Förnamn, Efternamn, Ålder)
        // och sedan skriver ut dessa i konsolen
        public static void enterPersonalDetails()
        {
            Console.WriteLine("Enter your first name, last name and the age.");
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            string age = Console.ReadLine();
            Console.WriteLine("My first name is " + firstname + ".\n" + "My last name is " + lastname + ".\n" + "My age is " + age + ".");
            Console.ReadLine();
        }

        // 3. Funktion som ändrar färgen på texten i konsolen
        // (och ändrar tillbaka om man använder funktionen igen
        public static void changingTextColors()
        {
            Console.WriteLine("This program is about changing the color of the text.\n");

            Console.WriteLine("Please press enter to see the text color changes to greeen.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("My text color changed to green now. \n");
            //Console.Clear();
            Console.WriteLine("Please press enter to see the text color changes to white again.");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("My text color is white again.");
            Console.ReadLine();
        }

        // 4. Funktion för att skriva ut dagens datum
        public static void todaysDate()
        {
            Console.Write("Today`s date and time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();
        }

        // 5. Funktion som tar två input värden, sedan skriver ut vilket av dem som är störst.
        public static void biggestOfTwoNumbers()
        {
            Console.WriteLine("Enter the first integer value: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer value: ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x > y)
            {
                Console.Write("The first number is greater.");
            }
            else
            {
                Console.WriteLine(" The second number is greater.");
            }
            Console.ReadLine();
        }


        // 6. Funktion som genererar att slumpmässigt tal mellan 1 och 100.
        // Användaren ska sedan gissa talet.
        // Gissar användaren rätt så ska ett meddelande säga detta,
        // samt hur många försök det tog.
        // Gissar användaren fel ska ett meddelande visas som informerar ifall talet var för stort eller för litet
        public static void guesstheNumber()
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {

                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + ":");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess : " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + "is High!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + "is Low!");
                    }
                    guesses++;
                }

                Console.WriteLine("Number : " + number);
                Console.WriteLine("You are Right!");
                Console.WriteLine("Number of guesses is :" + guesses);

                Console.WriteLine("Would you like to play again, Y/N: ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }


            Console.WriteLine("Thanks for playing!");
            Console.ReadLine();
        }

        // 7. Funktion där användaren skriver in en textrad, som sedan sparas i en fil på hårddisken
        public static void fileWrite()
        {
            String text, text1;

            Console.WriteLine("Type the data to be entered in the file.\n");

            text = Console.ReadLine().ToString();
            text1 = text;

            String filepath = @"C:\sample.txt";

            if (!File.Exists(filepath))
            {
                using (StreamWriter sw = File.CreateText(filepath))
                {
                    sw.WriteLine(text1);
                    sw.Dispose();
                }

            }
            Console.ReadLine();

        }

        //8. Funktion där en fil läses in från hårddisken
        //(för enkelhetens skull kan man använda filen från uppgift 7)
        public static void fileRead()
        {
            string filepath = @"C:\sample.txt";

            /* Read entire text file content in one string  
            string text = File.ReadAllText(filepath);
            Console.WriteLine(text);
            Console.ReadLine(); */

            // Read a text file line by line.  
            string[] lines = File.ReadAllLines(filepath);

            foreach (string line in lines)
                Console.WriteLine(line);
            Console.ReadLine();  // optional
        }

        // 9. Funktion där användaren skickar in ett decimaltal
        // och får tillbakaroten ur, upphöjt till 2 och upphöjt till 10
        public static void findingroots()
        {
            // input values with decimal places
            double x;
            Console.WriteLine("Enter a decimal number : ");
            x = double.Parse(Console.ReadLine());

            // output square root of x
            Console.WriteLine("Square root of the entered number is: " + Math.Sqrt(x));

            // x is the base and 2 is power ( index or exponent of a number)
            double pow1 = Math.Pow(x, 2);
            Console.WriteLine("Number raised to 2 is: " + pow1);

            // x is the base and 10 is power
            double pow2 = Math.Pow(x, 10);
            Console.WriteLine("Number raised to 10 is: " + pow2);
            Console.ReadLine();
        }


        // 10. Funktion där programmet skriver ut en multiplikationstabell från 1 till 10.
        // En ”tabb” ska läggas in efter varje nummer.
        // Försöka att ställa upp det så det blir relativt läsbart.
        public static void multiplicationTable()
        {

            Console.Write("\n\n");
            Console.Write("Displaying the multiplication table:\n");
            Console.Write("----------------------------------- \n\n");
            Console.Write("Enter the range of input for the range: ");
            int inputRange = int.Parse(Console.ReadLine());
            for (int i = 1; i <= inputRange; i++)
            {
                for (int j = 1; j <= inputRange; j++)
                {
                    Console.Write($"{i}*{j}={i * j}" + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }

        // 11. Funktion som skapar två arrayer.
        // Den första fylls med slumpmässiga tal.
        // Den andra fylls med talen från den första i stigande ordning.
        // Array.Sort() får EJ användas.

        public static void arrangingArrays()
        {
            // int[] randnum = new int[] { 56, 45, 786, 98, 67 }; * hardcoded

            int[] arr = new int[15];
            int n, temp;


            Console.WriteLine("Enter the number of array elements: ");
            n = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter the array numbers: ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("After arranging in ascending order:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();

        }


        // 12. Funktion som tar en input från användaren
        // och kontrollerar ifall det är en palindrom
        // (alltså samma ord från båda håll, såsom Anna eller radar.
        public static void palindrome()
        {
            // Ask user to enter a string
            string a = string.Empty;
            Console.WriteLine("Enter a String or Word");
            a = Console.ReadLine();

            // reverse the given string
            char[] c = a.ToCharArray();
            Array.Reverse(c);
            String b = new String(c);

            // Compare the strings
            if (a.ToLower() == b.ToLower())
            {
                Console.WriteLine("Given string is a Palindrome.");
            }
            else
            {
                Console.WriteLine("Given string is not a Palindrome.");
            }
            Console.ReadLine();
        }



        // 13. Funktion som tar två inputs från användaren
        // och skriver sedan ut alla siffror som är mellan de två inputsen.
        public static void numbersBetween()
        {
            //  User inputs
            Console.Write("Number 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int n;
            for (n = num1; n <= num2; n++)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }


        // 14. Funktion där användaren skickar in ett antal värden (komma-separerade siffror)
        // som sedan sorteras och skrivs ut efter udda och jämna värden.

        public static void evenOdd()
        {
            int[] values = { 2, 5, 76, 35, 56, 9, 89, 21, 32, 33, 28 };
            Console.WriteLine("Values to be sorted into even and odd are: ");
            foreach (var item in values)
            {

                Console.WriteLine(item);
            }

            Console.ReadLine();

            Array.Sort(values);
            foreach (int result in values)
            {

                if (result % 2 == 0)
                {
                    Console.Write(result + " is even number.");
                }
                else
                {
                    Console.Write(result + " is odd number.");

                }
                Console.ReadLine();
            }
        }

        // 15. Funktion där användaren skriver in ett antal värden(komma-separerade siffor)
        // som sedan adderas och skrivs ut.

        static void addIntegers()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // display array elements in console
            Console.WriteLine("Elements of array to be added are: \n");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                sum += arr[i];

            }
            Console.WriteLine("Sum of elements is: " + sum);
            Console.ReadLine();

        }


        // 16. Funktion där användaren ska ange namnet på sin karaktär och namnet på en motståndare.
        // Funktionen skall sedan själv lägga till slumpmässiga värden för Hälsa, Styrka och Tur,
        // som sparas i en instans av en klass.
        static void characteristics()
        {
            // Nameof my character
            Console.WriteLine(" Enter the name of your character: ");
            Console.ReadLine();

            //Name of my opponent
            Console.WriteLine(" Enter the name of your opponent: ");
            Console.ReadLine();


            // Create object of Class type mycharacter
            Mycharacter mychar = new Mycharacter();
            /*mychar.health = 90;
            mychar.strength = 100;
            mychar.luck = 75; */

            Console.WriteLine("Enter the health of my character : ");
            int h1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the strength of my character : ");
            int s1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the luck of my character : ");
            int l1 = int.Parse(Console.ReadLine());

            // setting values in object properties
            mychar.health = h1;
            mychar.strength = s1;
            mychar.luck = l1;

            // getting values from object properties
            Console.WriteLine($"My Character values for health, strength and luck are: {mychar.health},{mychar.strength},{mychar.luck} \n");


            // Entering the values of my opponent from self defined class
            Myopponent myopp = new Myopponent();
            /*myopp.health = 65;
            myopp.strength = 95;
            myopp.luck = 85;*/

            Console.WriteLine("Enter the health of my character : ");
            int h2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the strength of my character : ");
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the luck of my character : ");
            int l2 = int.Parse(Console.ReadLine());


            myopp.health = h2;
            myopp.strength = s2;
            myopp.luck = l2;
            Console.WriteLine($"My opponent values for health, strength and luck are: {myopp.health},{myopp.strength},{myopp.luck} \n");
            Console.ReadLine();
        }

        // defining a class for my chracter properties
        class Mycharacter
        {
            public double health { get; set; }
            public double strength { get; set; }
            public double luck { get; set; }


        }
        // defining a class for my opponent properties
        class Myopponent
        {
            public double health { get; set; }
            public double strength { get; set; }
            public double luck { get; set; }
        }
    }
}


