// Виды методов
// Вид 1
void Metod1()
{
Console.WriteLine("Автор: Богатырева Наталья");
}
//Metod1();

// Вид 2
void Metod2(string msg)
{
Console.WriteLine(msg); 
}
// Metod2("Текст сообщения");
void Metod21(string msg, int count)
{
int i = 0;
while (i < count)
{
    Console.WriteLine(msg);
    i++;
}
}
//Metod21("Текст", 4);

// Вид 3
int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3(); 
//Console.WriteLine(year);

// Вид 4
string Metod4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i<count; i++)
    {
        result = result + text;
    }
return result;
}
//string res = Metod4(10, "z");
//Console.WriteLine(res);

// For
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}
