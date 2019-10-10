using System;

namespace Calculater
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int method;
            double number1, number2, add, sub, mult, divi;

            Console.WriteLine("What calculation would you like (1 for addition, 2 for subtraciton, 3 for multiplication, 4 for subtraction )");
            method = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            number2 = Convert.ToInt32(Console.ReadLine());

            //callings
            if (method == 1){
                add = addition(number1, number2);
                Console.WriteLine("the answer to the final calculation is {0}", add);}
            else if (method == 2) {
                sub = subtraction(number1, number2);
                Console.WriteLine("the answer to the final calculation is {0:0.00}", sub);}
            else if (method == 3) { 
                mult = multiplication(number1, number2);
                Console.WriteLine("the answer to the final calculation is {0:0.00}", mult);}    
            else if (method == 4) { 
                divi = division(number1, number2);
                Console.WriteLine("the answer to the final calculation is {0:0.00}", divi);}

        }

        

            //methods
            public static double addition(double n1, double n2) {
                double add;
                add = n1 + n2;
                return add;
        }
            public static double subtraction(double n1, double n2){
                double sub;
                sub = n1 - n2;
                return sub;
        }
            public static double multiplication(double n1, double n2){
                double mult;
                mult = n1 * n2;
                return mult;
        }
            public static double division (double n1, double n2)
        {
                double divi;
                divi = n1 / n2;
                return divi;
        }

    }
}
