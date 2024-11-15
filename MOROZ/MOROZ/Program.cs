using System.Numerics;

namespace Calc
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите опцию:");
            Console.WriteLine("1) Ввести А");
            Console.WriteLine("2) Ввести В");
            Console.WriteLine("3) Выполнить операцию +");
            Console.WriteLine("4) Выполнить операцию -");
            Console.WriteLine("5) Выполнить операцию *");
            Console.WriteLine("6) Выполнить операцию /");

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            int a = 0, b = 0;

            Console.Write("Введите номер опции: ");

            string choice = Convert.ToString(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    a = A();
                    break;
                case "2":
                    b = B();
                    break;
                case "3":
                    Console.WriteLine(Plus(a, b));
                    break;
                case "4":
                    Console.WriteLine(Min(a, b));
                    break;
                case "5":
                    Console.WriteLine(Umn(a, b));
                    break;
                case "6":

                    break;
                default:
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                    break;
            }

            return true;
        }
        static int A()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        static int B()
        {
            return Convert.ToInt32(Console.ReadLine());

        }
        private static int Plus(int a, int b)
        {
            return a + b;
        }
        private static int Min(int a, int b)
        {
            return a - b;
        }
        static int Umn(int a, int b) 
        {
            return a * b;
        }
    }
}
