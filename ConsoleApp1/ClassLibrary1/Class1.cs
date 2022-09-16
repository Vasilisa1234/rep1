using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.InteropServices;

namespace ClassLibrary1
{
    public class Matrix
    {
        private int n;
        private int[,] matr;
        public Matrix () { }
        public int N
        {
            get { return n; }
            set { if (value > 0) n = value; }
        }

        // https://tumovsky.by/notes/csharp-class-matrix

        public Matrix (int n)
        {
            this.n = n;
            matr = new int[this.n, this.n];
        }

        public int this [int i, int j]
        {
            get
            {
                return matr[i, j];
            }
            set
            {
                matr[i, j] = value;
            }
        }

        // Ввод матрицы с клавиатуры.
        public void WriteMatr()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите элемент матрицы {0}:{1}", i + 1, j + 1);
                    matr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        // Вывод матрицы с клавиатуры.
        public void ReadMatr()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        // Проверка матрицы А на единичность.
        public void oneMatr(Matrix a)
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == 1 && i == j)
                    {
                        count++;
                    }
                }
            }
            if (count == a.N)
            {
                Console.WriteLine("Единичная");
            }
            else Console.WriteLine("Не единичная");
        }

        // Умножение матрицы А на число.
        public static Matrix umnCh(Matrix a, int ch)
        {
            Matrix resMatr = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < a.N; j++)
                {
                    resMatr[i, j] = a[i, j] * ch;
                }
            }
            return resMatr;
        }

        // Умножение матрицы А на матрицу Б.
        public static Matrix umn(Matrix a, Matrix b)
        {
            Matrix resMatr = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
                for (int j = 0; j < b.N; j++)
                    for (int k = 0; k < b.N; k++)
                        resMatr[i, j] += a[i, k] * b[k, j];
            return resMatr;
        }

        // перегрузка оператора умножения.
        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Matrix.umn(a, b);
        }

        public static Matrix operator *(Matrix a, int b)
        {
            return Matrix.umnCh(a, b);
        }

        // Метод вычитания матрицы Б из матрицы А.
        public static Matrix razn(Matrix a, Matrix b)
        {
            Matrix resMatr = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    resMatr[i, j] = a[i, j] - b[i, j];
                }
            }
            return resMatr;
        }

        // Перегрузка оператора вычитания.
        public static Matrix operator *(Matrix a, Matrix b)
        {
            return Matrix.razn(a, b);
        }

        // Сложение матриц А и Б.
        public static Matrix Sum(Matrix a, Matrix b)
        {
            Matrix resMatr = new Matrix(a.N);
            for (int i = 0; i < a.N; i++)
            {
                for (int j = 0; j < b.N; j++)
                {
                    resMatr[i, j] = a[i, j] + b[i, j];
                }
            }
            return resMatr;
        }

        // Перегрузка сложения матриц.
        public static Matrix operator +(Matrix a, Matrix b)
        {
            return Matrix.Sum(a, b);
        }

        // Деструктор Matrix.
        ~Matrix()
        {
            Console.WriteLine("Очистка");
        }
    }
}
