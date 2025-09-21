Console.WriteLine("*** Min labb1 ***");
Console.WriteLine();

Console.Write("Mata in en text: ");
string inmatning = Console.ReadLine();

long summa = 0;
for (int i = 0; i < inmatning.Length; i++)
{
    char inputChar = inmatning[i];
    
    if (!char.IsDigit(inputChar))
        continue;

    for (int j = i + 1; j < inmatning.Length; j++)
    {
        char nästaChar = inmatning[j];

        if (!char.IsDigit(nästaChar))
            break;

        if (inputChar == nästaChar)
        {
            string found = inmatning.Substring(i, j - i + 1);

            summa = summa + Convert.ToInt64(found);

            for (int k = 0; k < inmatning.Length; k++)
            {
                if (k >= i && k <= j)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(inmatning[k]);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    Console.Write(inmatning[k]);
                }
            }
            Console.WriteLine();
            break;
        }
    }
}
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"Total = {summa}");
Console.ResetColor();
