using System;

namespace Task1
{
    public class BaseClass
    {
        protected int field1;
        protected int field2;
        protected int field3;

        public BaseClass(int f1, int f2, int f3)
        {
            this.field1 = f1;
            this.field2 = f2;
            this.field3 = f3;
        }

        // Конструктор копирования
        public BaseClass(BaseClass other)
        {
            this.field1 = other.field1;
            this.field2 = other.field2;
            this.field3 = other.field3;
        }

        public int GetProduct()
        {
            return field1 * field2 * field3;
        }

        public override string ToString()
        {
            return $"field1: {field1}, field2: {field2}, field3: {field3}";
        }
    }

    public class DerivedClass : BaseClass
    {
        private string description;

        public DerivedClass(int f1, int f2, int f3, string desc) : base(f1, f2, f3)
        {
            this.description = desc;
        }

        public string GetDescription()
        {
            return description;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Description: {description}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение для field1: ");
            int f1 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение для field2: ");
            int f2 = int.Parse(Console.ReadLine());
            Console.Write("Введите значение для field3: ");
            int f3 = int.Parse(Console.ReadLine());
            Console.Write("Введите описание: ");
            string desc = Console.ReadLine();

            DerivedClass derived = new DerivedClass(f1, f2, f3, desc);

            Console.WriteLine("Созданный объект: " + derived);
            Console.WriteLine("Произведение полей: " + derived.GetProduct());

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}