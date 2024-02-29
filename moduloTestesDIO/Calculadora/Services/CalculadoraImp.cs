using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
        public void aaa(string[] args) { 
            //desafio de codigo
        decimal media = 0;
        int count = 0;
        for (int index = 0; index < args.Length; index++)
        {
            decimal num = Convert.ToDecimal(args[index]);
            if(num < 0 || num > 10)
            {
            Console.WriteLine("nota invalida");
            }
            else
            {
                media = num + media;
                count++;
            }
            
        }
        decimal result = (decimal)media / count;

        Console.WriteLine($"media = {result}");
        }
    }
}