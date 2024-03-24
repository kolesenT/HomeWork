using Calculator;

simpleCalculator myCalculator = new simpleCalculator();

Console.WriteLine("Введите выражение \n(Доступны операции:\n + сложение \n - вычитание \n * умножение\n / деление\n " +
                 "% процент от числа \n sqrt корень квадратный):\n");

Console.WriteLine(myCalculator.calculate(Console.ReadLine()));
