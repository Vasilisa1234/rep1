using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие:\n" +
                "1. Умножение матрицы на число\n" +
                "2. Сложение матриц\n" +
                "3. Вычитание матриц\n" +
                "4. Умножение матриц\n" +
                "5. Возведение в степень матрицы\n" +
                "6. Транспонирование матрицы\n");
            int choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
