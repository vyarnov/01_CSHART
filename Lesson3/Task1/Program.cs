// int a = 1;
// int b = 2;
// int c = 3;
// int d = 4;
// double numenator = 10;
// int denumenator = 0;
// double result = 0;



double CalculateFormula(int a, int b, int c, int d)
{
    int numenator = a * b;
    double denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

Console.WriteLine(CalculateFormula(1,2,3,4));
