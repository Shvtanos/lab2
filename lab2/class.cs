using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab2
{
    public class BaseClass
    {
        // Три вещественных поля
        private double _field1;

        public double Field1
        {
            get { return _field1; }
            set { _field1 = value; }
        }

        private double _field2;

        public double Field2
        {
            get { return _field2; }
            set { _field2 = value; }
        }

        private double _field3;

        public double Field3
        {
            get { return _field3; }
            set { _field3 = value; }
        }

        // Конструктор по умолчанию
        public BaseClass(double field1 = 0, double field2 = 0, double field3 = 0)
        {
            Field1 = field1;
            Field2 = field2;
            Field3 = field3;
        }

        // Конструктор копирования
        public BaseClass(BaseClass other)
        {
            Field1 = other.Field1;
            Field2 = other.Field2;
            Field3 = other.Field3;
        }

        // Метод приведения к целому типу
        public void ToInt()
        {
            Field1 = Math.Truncate(Field1);
            Field2 = Math.Truncate(Field2);
            Field3 = Math.Truncate(Field3);
        }

        // Перегруженный метод ToString()
        public override string ToString()
        {
            return $"x: {Field1}, y: {Field2}, z: {Field3}";
        }

        // Метод для вычисления произведения трех полей
        public double ProductFields()
        {
            return Field1 * Field2 * Field3;
        }

        // Метод для поиска наибольшего значения из трех полей
        public double MaxField()
        {
            return Math.Max(Math.Max(Field1, Field2), Field3);
        }
    }

    // Дочерний класс
    public class DerivedClass : BaseClass
    {
        // Добавляем новое поле типа bool
        public bool NewField { get; set; }

        // Конструктор по умолчанию для дочернего класса
        public DerivedClass(double field1 = 0, double field2 = 0, double field3 = 0, bool newField = false)
            : base(field1, field2, field3)
        {
            NewField = newField;
        }

        // Метод для проверки состояния поля NewField
        public void CheckNewField()
        {
            Console.WriteLine($"Значение нового поля: {NewField}");
        }

        // Метод для вычисления суммы трех полей
        public double SumFields()
        {
            return Field1 + Field2 + Field3;
        }

        // Метод для поиска произведения трех полей
        public double ProductFields()
        {
            return Field1 * Field2 * Field3;
        }

        // Метод для поиска наибольшего значения из трех полей
        public double MaxField()
        {
            return Math.Max(Math.Max(Field1, Field2), Field3);
        }

        // Метод для вывода информации о классе
        public void PrintInfo()
        {
            Console.WriteLine($"Информация о объекте:");
            Console.WriteLine(base.ToString());
            Console.WriteLine($"Новое поле: {NewField}");
            Console.WriteLine($"Сумма полей: {SumFields():F2}");
            Console.WriteLine($"Произведение полей: {ProductFields():F2}");
            Console.WriteLine($"Наибольшее поле: {MaxField():F2}");
        }

       
    }
}
