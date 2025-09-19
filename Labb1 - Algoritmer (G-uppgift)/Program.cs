

Console.Write("Mata in en text: ");
string inmatning = Console.ReadLine();

long summa = 0;
for (int i = 0; i < inmatning.Length; i++)
{
    if (!int.TryParse(inmatning[i].ToString(), out int number))
    {
        continue;
    }
    for (int j = i + 1; j < inmatning.Length; j++)
    {
        if (!int.TryParse(inmatning[j].ToString(), out int number2))
        {
            break;
        }
        if (inmatning[i] == inmatning[j])
        {
            string start = "";

            if (i != 0)
                start = inmatning.Substring(0, i);

            string found = inmatning.Substring(i, j - i + 1);

            summa = summa + Convert.ToInt64(found);
            string end = "";

            if (j + 1 < inmatning.Length)
                end = inmatning.Substring(j + 1);

            Console.Write(start);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(found);
            Console.ResetColor();
            Console.Write(end);
            Console.WriteLine();

            break;
        }
    }
}
Console.Write("Total" + " = " + summa);
Console.ResetColor();

