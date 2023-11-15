Random random = new Random();
int[] mas = new int[15];
for (int i = 0; i < 15; i++)
{
    mas[i] = random.Next(-10, 11);
    Console.WriteLine(mas[i]);
}

int negative = 0;
int positive = 1;
int zero = 0;

for (int i = 0; i < 15; i++)
{
    if (mas[i] < 0)
    {
        negative++;
    }
    else if (mas[i] > 0)
    {
        positive *= mas[i];
    }
    else
    {
        zero++;
    }
}
Console.WriteLine("Кол-во щтрицательных:"+negative);
Console.WriteLine("Произведение положительных:"+positive);
Console.WriteLine("Кол-во нулевых:"+zero);