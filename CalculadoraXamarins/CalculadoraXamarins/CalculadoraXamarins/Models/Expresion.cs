using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraXamarins.Models
{
    public class Expresion
    {
        public double num1 { get; set; }
        public double num2 { get; set; }


        public double sumar()
        {
            return num1 + num2;
        }

        public double restar()
        {
            return num1 - num2;
        }
    }
}
