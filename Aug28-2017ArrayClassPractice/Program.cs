using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug28_2017ArrayClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays!

            //remember: "index" = position of an element in the array, starting at 0
            //element = each piece of info

            //to declare an array:
            //datatype[] nameOfArray = [elements listed here]

            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            string[] students = { "Mike", "Jackie", "Holly", "Gabrielle" };

            Console.WriteLine(students[3]);
            Console.WriteLine(students[0]);

            //powerpoint exercises:

            string[] vacaySpots = {"London", "Cairo", "The Outback", "Sri Lanka", "Lake Michigan", "Disney World", "Paris",
                "N'gorongoron Crater", "Acadia National Forest", "Easter Island"};

            Console.WriteLine($"{vacaySpots[0]} and {vacaySpots[9]}.");
            Console.WriteLine(vacaySpots[vacaySpots.Length - 1]); //another way to print last one

            int[] ages = { 2, 2, 11 };

            Console.WriteLine($"Charlie is {ages[0]}. Lucy is {ages[1]}. Eddie is {ages[2]}.");

            double[] gpa = new double[8]; //this one didn't initialize
                                          //just set the number of elements

            //to initialize:
            gpa[0] = 4.0;
            gpa[1] = 3.7;
                //etc...


            //Console.WriteLine($"Bluto Blutarsky ... you're a {gpa[7]}.");

            char[] initials = { 'J', 'M', 'H', 'G' };

            Console.WriteLine($"My teammates are {initials[0]}, {initials[1]}, and {initials[2]}.");

            //a ha! a string is an array of chars.
            //so you can just do this instead:

            Console.WriteLine(initials); //it'll print everything in the array!

            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            Console.WriteLine(daysOfWeek.Length);

            //how to change the value of an element: (first line is just for demonstration)

            Console.WriteLine(daysOfWeek[0]);
            daysOfWeek.SetValue("Funday", 0);  //SetValue
            Console.WriteLine(daysOfWeek[0]);

            int[] studentAges = new int[4];

            studentAges[0] = 45;
            studentAges[1] = 33;
            studentAges[2] = 42;
            studentAges[3] = 43;

            //searching for instances of elements in an array:
            string[] birthMonths = { "December", "July", "May", "July" };
            Console.WriteLine(Array.IndexOf(birthMonths, "July")); //IndexOf also works in string...
                                                                   //it looks for instances of whatever you're looking for
            Console.WriteLine(Array.LastIndexOf(birthMonths, "July")); //LastIndexOf

            //to order elements in an array:
            int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            Console.WriteLine(numbers[0]);
            Array.Reverse(numbers); //this reverses order of array
            Console.WriteLine(numbers[0]);

            //to sort:
            Array.Sort(numbers);
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[numbers.Length-1]);

            //you can sort strings too, but not necessarily how you'd expect.

            //more class exercises:

            string[] firstNames = { "Jackie", "Mike", "Holly", "Gabrielle" };
            Console.WriteLine(Array.IndexOf(firstNames, "Gabrielle"));

            Array.Sort(firstNames);
            Console.WriteLine(firstNames[0]);
            Console.WriteLine(firstNames[3]);


            int[] luckies = { 8, 43, 101, 1234, 101, 8, 1234, 43 };
            Console.WriteLine(Array.LastIndexOf(luckies, 8));

            char[] lmnop = { 'l', 'm', 'n', 'o', 'p' };
            Console.WriteLine(lmnop[0]);
            Array.Reverse(lmnop);
            Console.WriteLine(lmnop[0]);

            int[] favorites = new int[5];

            Console.WriteLine("\nWhat's your favorite number?");
            favorites[0] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat's your favorite number?");
            favorites[1] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat's your favorite number?");
            favorites[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat's your favorite number?");
            favorites[3] = int.Parse(Console.ReadLine());

            Console.WriteLine("\nWhat's your favorite number?");
            favorites[4] = int.Parse(Console.ReadLine());

            Array.Sort(favorites);

            Console.WriteLine(favorites[0]);
            Console.WriteLine(favorites[favorites.Length -1]);

            Console.ReadLine();
        }
    }
}
