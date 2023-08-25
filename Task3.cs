
var rand = new Random();

List<int> listNumbers = new List<int>();

int number;

Console.Write("Первоначальная коллекция: ");

for (int i = 0; i < 10; i++)
{
    do
    {
        number = rand.Next(-100, 100);
    } 
    
    while (listNumbers.Contains(number));

    listNumbers.Add(number);
    
    Console.Write(number + " ");
}

Console.WriteLine($"{Environment.NewLine}----------------------------");

Console.WriteLine("Коллекция после сортировки по возрастанию и округления значений второй половины до четного значения: ");

var orderedNumbers1 = listNumbers
                     .OrderBy(x => x)
                     .Skip(5)
                     .Select(x => x % 2 == 0 ? x : x + 1);

foreach (var num in orderedNumbers1)

    Console.Write(num + " ");

Console.WriteLine($"{Environment.NewLine}----------------------------");

Console.WriteLine($"{Environment.NewLine}Коллекция после сортировки по убыванию и возведения значений в квадрат: ");

var orderedNumbers2 = listNumbers
                     .OrderByDescending(x => x)
                     .Select(x => x * x);

foreach (var num in orderedNumbers2)

    Console.Write(num + " ");

Console.WriteLine(Environment.NewLine);

