// See https://aka.ms/new-console-template for more information

//1
// String person = "john";
// int age = 30;
// double wage = 20.5;

// Console.WriteLine($"Hi, my name is {person} I am  {age} years old and earn ${wage} per hour");


//6
// public class Car {
//     public string Make { get; set; }
//     public string Model { get; set; }
//     public int Year { get; set; }

//     public string Color { get; set; }
//      public void DisplayDetails() {
//         Console.WriteLine($"Make: {Make} Model: {Model} Year {Year}, Color{Color}");
//     }
// }

// public class Program {
//     public static void Main(string[] args) {
//         Car car1 = new Car { Make = "Toyota", Model = "XYZ", Year = 2000, Color = "Blue" };
//         Car car2 = new Car { Make = "Toyota", Model = "ABC", Year = 1999, Color = "Red" };
//         Car car3 = new Car { Make = "Toyota", Model = "QWE", Year = 1888, Color = "Yellow" };

//         car1.DisplayDetails();
//         car2.DisplayDetails();
//         car3.DisplayDetails();
//     }
// }


//5
// int x = 0;
// for (int i = x; i <= 20; i++ ) {
//     Console.WriteLine( "" + i );
// }

//5
// int i = 0;
// while (i <= 20) {
//     Console.WriteLine(i);
//     i++;
// }


// 3
// using System.Net.NetworkInformation;
// using System.Runtime.Serialization;

// Console.WriteLine("Enter your name: ");
// String name = Console.ReadLine();
// GetGreeting();

// void GetGreeting() {
//     Console.WriteLine($"Hello, {name}!");
// }



//4
// int userInput = int.Parse(Console.ReadLine());

// if (userInput < 0) {
//     Console.WriteLine("negative num :" + userInput);
// } else if (userInput > 0) {
//     Console.WriteLine("Positive num : " + userInput);
// } else {
//     Console.WriteLine("Literally 0 : " + userInput );
// }


//2
// using System.Transactions;

// int[] numbers = new int[5];

// for (int i = 0; i < numbers.Length; i++) {
//     Console.WriteLine($"Enter num {i + 1}");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Array");
// foreach (int num in numbers) {
//     Console.WriteLine(num);
// }

// int sum = 0;
// foreach (int num in numbers) {
//     sum += num;
// }
// Console.WriteLine($"sum of array :{sum}");
