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
            List<string> expression = interpretexpression(results);
            return DoExpression(expression);

        }
        public List<string> interpretexpression(string results)
        {
 
            string operations = "";
            string firstsum = "";
            string secondsum = "";
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] == '*' || results[i] == '/' || results[i] == '+' || results[i] == '-')
                {
                    operations = results[i].ToString();
                    continue;
                }
               else if (string.IsNullOrEmpty(operations))
                {
                    firstsum += results[i].ToString();
                }
                else
                {
                    secondsum += results[i].ToString();
                }
            }
            return new List<string> { firstsum, secondsum, operations };
        }
        public string DoExpression(List<string> expression)
        {
            string firstsum = expression[0];
            string secondsum = expression[1];
            string operaton = expression[2];

            switch (operaton)
            {
                case "*":
                    {
                        return (int.Parse(firstsum) * int.Parse(secondsum)).ToString();
                    }
                case "/":
                    {
                        return (int.Parse(firstsum) / int.Parse(secondsum)).ToString();
                    }
                case "+":
                    {
                        return (int.Parse(firstsum) + int.Parse(secondsum)).ToString();
                    }
                case "-":
                    {
                        return (int.Parse(firstsum) - int.Parse(secondsum)).ToString();
                    }
                default:
                    return "0";
               
            }
        }
    }
}
