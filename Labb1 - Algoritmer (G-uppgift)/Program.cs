

Console.Write("Mata in en text: ");
string long1 = Console.ReadLine();
long summa = 0;
for (int i = 0; i < long1.Length; i++)
{
    if (!int.TryParse(long1[i].ToString(), out int number))
    {
        continue;
    }
    for (int j = i + 1; j < long1.Length; j++)
    {
        if (!int.TryParse(long1[j].ToString(), out int number2))
        {
            break;
        }
        if (long1[i] == long1[j])
        {
            var start = "";
            if (i != 0)
                start = long1.Substring(0, i);
            var found = long1.Substring(i, j - i + 1);
            summa += Convert.ToInt64(found);
            string end = "";
            if (j + 1 < long1.Length)
                end = long1.Substring(j + 1);
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
Console.Write(summa);
Console.ResetColor();
