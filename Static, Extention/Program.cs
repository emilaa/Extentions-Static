using Static__Extention.Helpers;
using Static__Extention.Implementations;
using Static__Extention.Models;
using System;

namespace Static__Extention
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework Calculator
            //Calculation calculate = new Calculation();

            //int num1 = 18;
            //int num2 = 24;

            //var result = calculate.Calculate(num1, num2, "*");

            //Console.WriteLine(result);
            #endregion

            //Car car1 = new Car();
            //Car car2 = new Car();

            //Car.ActiveCount();

            //string word = "Salam P130";
            //string name = "Emil";
            //var result = Extentions.CheckDigit(word);
            //var result1 = word.CheckString(@"\d");
            //var result2 = name.CheckString(@"[A-Z]");

            //Console.WriteLine(word + "-" + result1 + " " + name + "-" + result2);

            int num1 = 25;

            Console.WriteLine(num1.SumNumbers(7,3,10));   
        }
    }
}
