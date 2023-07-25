﻿// See https://aka.ms/new-console-template for more information

using System;
namespace  Calculator
{
    class Calculator
    {
       static void Main()
       {
           Console.WriteLine("Enter Values");
           Console.Write("Enter first number: ");
           string firstValue= Console.ReadLine();
           Console.Write("Operations [+ - * /]: ");
           string operation = Console.ReadLine();
           Console.Write("Enter second number: ");
           string secondValue = Console.ReadLine();
           Console.WriteLine("Converting values...");

           decimal firsNumber = decimal.Parse(firstValue);
           decimal secondNumber = decimal.Parse(secondValue);
           
           string template = $"{firsNumber} {operation} {secondNumber} =";
           decimal result = operation switch
           {
              "+" => firsNumber + secondNumber,
              "-" => firsNumber - secondNumber,
              "*" => firsNumber * secondNumber,
              "/" => firsNumber / secondNumber,
              "%" => firsNumber % secondNumber,
               _  => 0              
           };
     
           Console.WriteLine($"{template} {result}"); 
           Console.WriteLine(new string('-', 40));
           Console.WriteLine("Enter your age: ");
           string ageString = Console.ReadLine();
           int age = int.Parse(ageString);

           string message = (age >= 18 && age <=30) 
                                 ? "You are eligible to military service"
                                 : "You are not eligible to military service";

           Console.WriteLine(message); 
       }
    }
}