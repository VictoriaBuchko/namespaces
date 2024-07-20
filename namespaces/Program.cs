//Task1
namespace Namespace1
{
    public class Test
    {
        public void Print()
        {
            Console.WriteLine("Hello from Namespace1");
        }
    }
}

namespace Namespace2
{
    public class Test
    {
        public void Print()
        {
            Console.WriteLine("Hello from Namespace2");
        }
    }
}
//Task2
namespace Company
{
    namespace Department
    {
        public class Employee
        {
            public void ShowDepartment()
            {
                Console.WriteLine("Employee belongs to Sales Department");
            }
        }
    }
}
//Task3
namespace MathOperations
{
    public class MathAdd
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}

namespace StringOperations
{
    public class StringConcatenate
    {
        public string Concatenate(string a, string b)
        {
            return a + b;
        }
    }
}
//Task4
namespace France
{
    public class Paris
    {
        public int Population { get; set; }

        public Paris()
        {
            Population = 2140526;
        }
    }
}

namespace Italy
{
    public class Rome
    {
        public int Population { get; set; }

        public Rome()
        {
            Population = 2872800; 
        }
    }
}

namespace Germany
{
    public class Berlin
    {
        public int Population { get; set; }

        public Berlin()
        {
            Population = 3644826;
        }
    }
}

namespace namespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Task 1");
            //1) Создайте два пространства имен, каждое с одним классом.
            //Один класс должен содержать метод, который печатает сообщение "Hello from Namespace1",
            //а другой — метод, который печатает "Hello from Namespace2".
            //Названия этих классов должны быть одинаковыми.В основном классе вызовите эти методы.
            Namespace1.Test obj1 = new Namespace1.Test();
            Namespace2.Test obj2 = new Namespace2.Test();

            obj1.Print();
            obj2.Print();


            Console.WriteLine("\nTask 2");
            //2) Создайте пространство имен Company,
            //внутри него создайте вложенное пространство имен Department, содержащее класс Employee.
            //Класс Employee должен иметь метод ShowDepartment,
            //который выводит "Employee belongs to Sales Department".
            //В основном классе создайте объект класса Employee и вызовите его метод.
            Company.Department.Employee employee = new Company.Department.Employee();
            employee.ShowDepartment();


            Console.WriteLine("\nTask 3");
            //3) Создайте 2 пространства имен MathOperations и StringOperations, каждое с одним классом,
            //содержащим метод для выполнения соответствующей операции
            //(например, сложение чисел, конкатенация строк).В основном классе используйте эти методы.
            MathOperations.MathAdd add = new MathOperations.MathAdd();
            int sum = add.Add(3, 4);
            Console.WriteLine("Sum: " + sum);


            StringOperations.StringConcatenate con = new StringOperations.StringConcatenate();
            string concatenated = con.Concatenate("Hello, ", "world!");
            Console.WriteLine("New string: " + concatenated);


            Console.WriteLine("\nTask 4");
            //4) Разработать приложение, в котором бы сравнивалось население трёх столиц из разных стран.
            //Причём страна бы обозначалась пространством имён,а город — классом в данном пространстве.
            France.Paris paris = new France.Paris();
            Italy.Rome rome = new Italy.Rome();
            Germany.Berlin berlin = new Germany.Berlin();

            Console.WriteLine("Population of Paris: " + paris.Population);
            Console.WriteLine("Population of Rome: " + rome.Population);
            Console.WriteLine("Population of Berlin: " + berlin.Population);

            Populations(paris.Population, rome.Population, berlin.Population);
        }




        public static void Populations(int pop1, int pop2, int pop3)
        {
            if (pop1 > pop2 && pop1 > pop3)
            {
                Console.WriteLine("Paris has the largest population");
            }
            else if (pop2 > pop1 && pop2 > pop3)
            {
                Console.WriteLine("Rome has the largest population");
            }
            else if (pop3 > pop1 && pop3 > pop2)
            {
                Console.WriteLine("Berlin has the largest population");
            }
        }
    }
}
