public class Program
{
    public static void Main(string[] args)
    {

        int nextOfNumber, numberOfDigits;

        int[] arrayOfNumbers = new int[10];

        string[] digitsIntoToTheWords =
            {
                "ноль",
                "один",
                "два",
                "три",
                "четыре",
                "пять",
                "шесть",
                "семь",
                "восемь",
                "девять"
            };

        Console.WriteLine("Введите число: ");

        int number = int.Parse(Console.ReadLine());

        Console.Write("Вы ввели: ");

        nextOfNumber = 0;

        numberOfDigits = 0;

        do
        {
            nextOfNumber = number % 10;

            arrayOfNumbers[numberOfDigits] = nextOfNumber;

            numberOfDigits++;

            number = number / 10;

        }

        while (number > 0);

        numberOfDigits--;

        for (; numberOfDigits >= 0; numberOfDigits--)

        {
            Console.Write(digitsIntoToTheWords[arrayOfNumbers[numberOfDigits]] + " ");
        }
    }
}