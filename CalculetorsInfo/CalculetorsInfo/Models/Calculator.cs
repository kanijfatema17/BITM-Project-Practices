using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculetorsInfo.Models
{
   public class Calculator
    {
       // public int Add(int firstNumber, int secondNumber)
       // {
       //     return firstNumber + secondNumber;

       // }

       // public int Add(int firstNumber, int secondNumber, int lastNumber = 0)
       // {

       //     return firstNumber + secondNumber + lastNumber;

       // }
       //public double Add(double firstName, double secondNumber)
       //{
       //    return firstName + secondNumber;

       //}


       public double Add(params double[] inputs)
       {

           double result = 0;
           if (inputs.Length == 0){
       
            return result;
       
       }
           foreach (double input in inputs)
           {
               result += input;

           }
           return result;
       
       
       }
       
    }
}
