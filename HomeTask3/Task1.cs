
Console.WriteLine("Введите длину стороны квадрата:");
var a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите символ:");
char symbol = Convert.ToChar(Console.ReadLine());

void printSquare(int a,char symbol)
{
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < a; j++)
        {
            Console.Write(symbol);  
        }
        Console.WriteLine();
    }
}

printSquare(a, symbol);