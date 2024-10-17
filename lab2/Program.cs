using lab2;

using System.Text.RegularExpressions;


internal class Program
{
    static double GetDoubleInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine().Trim();

            // Проверяем, что входная строка содержит только цифры и одну запятую
            if (Regex.IsMatch(input, @"^-?[0-9]+(\,[0-9]+)?$"))
            {
                if (double.TryParse(input, out double result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите число.");
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите число с запятой.");
            }
        }
    }


    private static void Main(string[] args)
    {
        Console.Write("Введите значение 1 числа(x): ");
        double field1 = GetDoubleInput("");

        Console.Write("Введите значение 2 числа(y): ");
        double field2 = GetDoubleInput("");

        Console.Write("Введите значение 3 числа(z): ");
        double field3 = GetDoubleInput("");

        BaseClass baseInstance = new BaseClass(field1, field2, field3);
        Console.WriteLine("\nБазовый класс:");
        Console.WriteLine(baseInstance.ToString());

        // Создаем копию базового класса
        BaseClass copyInstance = new BaseClass(baseInstance);
        Console.WriteLine("\nКопия базового класса:");
        Console.WriteLine(copyInstance.ToString());

        // Приведем к целому типу
        copyInstance.ToInt();
        Console.WriteLine("\nПосле приведения к целому типу:");
        Console.WriteLine(copyInstance.ToString());

        // Создаем экземпляр дочернего класса
        Console.Write("Введите значение нового поля (true/false): ");
        bool newField = Convert.ToBoolean(Console.ReadLine());
        DerivedClass derivedInstance = new DerivedClass(field1, field2, field3, newField);
        Console.WriteLine("\nДочерний класс:");
        derivedInstance.PrintInfo();

        // Проверяем состояние нового поля
        Console.WriteLine($"\nТекущее значение нового поля: {derivedInstance.NewField}");

        // Изменяем значения полей и вызываем методы
        Console.Write("Введите новое значение x: ");
        double newField1 = GetDoubleInput("");

        Console.Write("Введите новое значение y: ");
        double newField2 = GetDoubleInput("");

       Console.Write("Введите новое значение NewField (true/false): ");
        bool newNewField = Convert.ToBoolean(Console.ReadLine());
        derivedInstance.Field1 = newField1;
        derivedInstance.Field2 = newField2;
        derivedInstance.NewField = newNewField;

        Console.WriteLine("\nНовое значение x: " + derivedInstance.Field1);
        Console.WriteLine("Новое значение y: " + derivedInstance.Field2);
        Console.WriteLine($"Новое значение NewField: {derivedInstance.NewField}");

        Console.WriteLine("\nПроверяем состояние нового поля:");
        derivedInstance.CheckNewField();
        Console.WriteLine("\nИнформация о объекте после изменений:");
        derivedInstance.PrintInfo();
    }


}