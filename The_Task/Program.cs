

string[] arrstr = new string[] { "ДА", "СБУДУТСЯ", "МЕЧТЫ", "БИЛЛИ", "БОНСА", "!!!" };
int size = arrstr.Length;
int newsize = 0;
for (int i = 0; i < size; i++)
{
    if (arrstr[i].Length < 4)
    {
        newsize++;
    }
}
// Console.WriteLine($"КОЛИЧЕСТВО ЭЛЕМЕНТОВ  {newsize}");
string[] arrstr3 = new string[newsize];
// Console.WriteLine($"РАЗМЕР ПРИНИМАЮЩЕГО МАССИВА  {arrstr3.Length}");
int count = 0;
for (int i = 0; i < size; i++)
{
    if (arrstr[i].Length < 4)
    {
        arrstr3[count] = arrstr[i];
        count++;
    }
}
for (int i = 0; i < newsize; i++)
{
    Console.Write($" '{arrstr3[i]}' ");
}