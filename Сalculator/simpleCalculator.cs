using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class simpleCalculator
    {
        public string calculate(string colsoleStr)
        {
            string operatorStr = "+-*/%q";
            string consoleNumber;
            double consoleNumber1, consoleNumber2, res;
            char consoleChar = default;
            bool resParse1 = false;
            bool resParse2 = false;
            int indexIn = 0;
            string result = "";

            while (true)
            {
                consoleNumber = colsoleStr;
                for (int i = 1; i < consoleNumber.Length; i++)
                {
                    indexIn = operatorStr.IndexOf(consoleNumber[i]);
                    if (indexIn != -1)
                    {
                        if (consoleNumber[i] == 'q' && !(consoleNumber.Substring(0, 4) == "sqrt"))
                        {
                            indexIn = -1;
                            break;
                        }

                        consoleChar = consoleNumber[i];
                        indexIn = i;
                        break;
                    }
                }

                if (indexIn != -1)
                {
                    if (consoleChar == 'q')
                    {
                        resParse1 = true;
                        consoleNumber1 = 0;
                        resParse2 = Double.TryParse(consoleNumber.Substring(4), out consoleNumber2);
                        if (consoleNumber2 < 0) resParse2 = false;
                    }
                    else
                    {
                        resParse1 = Double.TryParse(consoleNumber.Substring(0, indexIn), out consoleNumber1);
                        resParse2 = Double.TryParse(consoleNumber.Substring(indexIn + 1), out consoleNumber2);
                    }

                    if ((resParse1 && resParse2) && !(consoleChar == '/' && consoleNumber2 == 0)) break;
                }

                result = "Данные не корректны! Введите выражение ещё раз:";
            }

            switch (consoleChar)
            {
                case '+':
                    res = consoleNumber1 + consoleNumber2;
                    result = $"Результат сложения:  {res}";
                    break;
                case '-':
                    res = consoleNumber1 - consoleNumber2;
                    result = $"Результат вычитания: {res}";
                    break;
                case '*':
                    res = consoleNumber1 * consoleNumber2;
                    result =  $"Результат умножения: {res}";
                    break;
                case '/':
                    res = consoleNumber1 / consoleNumber2;
                    result = $"Результат деления: {res}";
                    break;
                case '%':
                    res = consoleNumber1 * 0.01 * consoleNumber2;
                    result = $"{consoleNumber1} % от числа {consoleNumber2} это: {res}";
                    break;
                case 'q':
                    res = Math.Sqrt(consoleNumber2);
                    result = $"Корень квадратный числа {consoleNumber2} это: {res}";
                    break;

            }
            return result;
        }
    }
}
