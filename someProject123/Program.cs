// принятие значений
Console.Write("Bведите число>> ");
string num = Console.ReadLine();

Console.Write("Bведите систему счисления(от 2 до 9) в которой находится число>> ");
int sysNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Bведите систему счисления(от 2 до 9) в которую хотите перевести число>> ");
int sysTo = Convert.ToInt32(Console.ReadLine());

// конвертор Char в String, тоесть он не превращает код юникода в символ, а обращается по нему к символу
List<string> list = [];
for (int i = 0; i < num.Length; i++) 
{
    list.Add(Convert.ToString(num[i]));
}

// перевод в десятичную
double value = 0;
int x = list.Count() - 1;
for (int i =0; i<list.Count(); i++)
{
    value += Convert.ToInt32(list[i]) * Math.Pow(sysNum, x);
    x -= 1;
}

// перевод из десятичной в любую
Stack<double> answer = [];

while (value > 1) 
{
    answer.Push(Math.Round(value % sysTo));
    value = value / sysTo;
}
answer.Push(value);

// вывод ответа
Console.Write("Ответ: ");
foreach (int i in answer) 
{
    Console.Write(i);
}