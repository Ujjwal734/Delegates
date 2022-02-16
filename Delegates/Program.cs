using Delegates;

Console.WriteLine("Hello, Welcome to Delegates...!");
Calculation calculation = new Calculation(DelegateSingle.Addition);
calculation.Invoke(20, 30);
Calculation calculation1 = new Calculation(DelegateSingle.Subtraction);
calculation1.Invoke(50, 30);
Calculation calculation2 = new Calculation(DelegateSingle.Multiplication);
calculation2.Invoke(2, 30);
Calculation calculation3 = new Calculation(DelegateSingle.Division);
calculation3.Invoke(20, 4);

