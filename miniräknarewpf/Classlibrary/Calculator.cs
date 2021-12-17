using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniräknarewpf.Classlibrary
{
    internal class Calculator
    {
        public string Calculate(string results)
        {
            List<string> expression = InterpretExpression(results);
            return DoExpression(expression);

        }
        public List<string> InterpretExpression(string results)
        {

            string operations = "";
            string firstSum = "";
            string secondSum = "";
            List<char> operators = new List<char> { '*', '/', '+', '-' };
            for (int i = 0; i < results.Length; i++)
            {
                if (operators.Contains(results[i]))
                {
                    operations = results[i].ToString();
                    continue;
                }
                else if (string.IsNullOrEmpty(operations))
                {
                    firstSum += results[i].ToString();
                }
                else
                {
                    secondSum += results[i].ToString();
                }
            }
            return new List<string> { firstSum, secondSum, operations };
        }
        public string DoExpression(List<string> expression)
        {
            string firstSum = expression[0];
            string secondSum = expression[1];
            string operation = expression[2];

            switch (operation)
            {
                case "*":
                    {
                        return (double.Parse(firstSum) * double.Parse(secondSum)).ToString();
                    }
                case "/":
                    {
                        return (double.Parse(firstSum) / double.Parse(secondSum)).ToString();
                    }
                case "+":
                    {
                        return (double.Parse(firstSum) + double.Parse(secondSum)).ToString();
                    }
                case "-":
                    {
                        return (double.Parse(firstSum) - double.Parse(secondSum)).ToString();
                    }
                default:
                    return "0";

            }
        }
    }
}
