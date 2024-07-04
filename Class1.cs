using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Calculator
    {
        public int Calcular(string op, float value1, float value2)
        {
            switch (op)
            {
                case "+":
                    return Convert.ToInt32( value1 + value2);
                case "-":
                    return Convert.ToInt32(value1 - value2);
                case "*":
                    return Convert.ToInt32(value1 * value2);
                case "/":
                    return Convert.ToInt32(value1 / value2);
                default:return 0;
            }
        }    } }

