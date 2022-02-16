using Delegates;

Console.WriteLine("Hello, Welcome to Delegates...!");
Calculation calculation = new Calculation(DelegateSingle.Addition);
calculation.Invoke(20, 30);
Calculation calculation1 = new Calculation(DelegateSingle.Subtraction);
calculation1(40, 10);

