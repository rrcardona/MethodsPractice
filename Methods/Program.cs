using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int number1 = 25;
            //    int number2 = 50;
            //    int total = Add(number1, number2);
            //    Console.WriteLine(total);
            //    Console.WriteLine(Multiply(number1, number2));
            //    Greeting();
            //    string name = "Will Robensen";
            //    RobotWarning(name);
            WageCalculator(8, 40);
            retireAge(31);
            celebration();
            add(19,86);
            
        }

        public static int Add(int firstNumber, int secondNumber)
        {
                int sum = firstNumber + secondNumber;
                return sum;
        }

        public static int Multiply(int firstNumber, int secondNumber)
        {
                int product = firstNumber * secondNumber;
                return product;
        }

        public static void Greeting()
        {
                Console.WriteLine("Hello World");

        }

        public static void RobotWarning(string name)
        {
                Console.WriteLine("Danger, " + name);
        }

        //create a method call FavoriteFood
        //it should take two string parameters
        //Name of the food and the other being the food
        //it should be void return type
        //the method should concatenate the two values





        public static void FavFood(string foodType, string foodName)
        {
            Console.WriteLine(foodType + ":" + foodName);
        }




        //create a method called RetirementCalculator

        //It should take an int as a parameter respresenting the users age. 
        //The method should calculate how many more years until retiring using 65 as the age of retirement.
        //The return type should be void
        //Once it calculates the users retirement age it should print
        //"The user will retire in X years, where X represents the value that was calculated

        public static void retireAge(int age)
        {
            int ageToRetire = 65 - age;
            Console.WriteLine("You will retire in " + ageToRetire + " years");
        }
        
        public static double WageCalculator (double hoursWorked, double hourlyWage)
        {
            double monthlyWage = hourlyWage * hoursWorked;
            return monthlyWage;
        } 

        public static void celebration()
        {
            Console.WriteLine("THE CHAMP IS HERE!!!!");
        }
        
        public static int add(int firstNumber, int secondNumber)
        {
            int answer = firstNumber + secondNumber;
            return answer;
        }
    }
   }

