/*
 62. Создать класс Matrix2x2 - двумерная матрица из вещественных чисел. 
Аргументы - содержимое матрицы (лучше хранить двумерным массивом). 
Методы:
● Matrix2x2() - конструктор для нулевой матрицы;                                                     !
● Matrix2x2(double) - конструктор для матрицы, у которой каждый элемент равен поданному числу;       !
● Matrix2x2(double [][]) - конструктор для матрицы, содержимое подается на вход в виде массива;      !
● Matrix2x2(double, double, double, double) - глупый конструктор, но пусть он будет.                 !
● Matrix2x2 add(Matrix2x2) - сложение матрицы с другой;                                              !
● void add2(Matrix2x2) - сложение матрицы с другой;                                                  !
● Matrix2x2 sub(Matrix2x2) - вычитание из матрицы другой матрицы;                                    !
● void sub2(Matrix2x2) - вычитание из матрицы другой матрицы;                                        !
● Matrix2x2 multNumber(double) - умножение матрицы на вещественное число;                            !
● void multNumber2(double) - умножение матрицы на вещественное число;                                !
● Matrix2x2 mult(Matrix2x2) - умножение матрицы на другую матрицу;                                   !
● void mult2(Matrix2x2) - умножение матрицы на другую матрицу;                                       !
● double det() - определитель матрицы;                                                               !
● void transpon() - транспонировать матрицу;                                                         !
● Matrix2x2 inverseMatrix() - возвратить обратную матрицу для заданной.                              !
Если это невозможно, вывести сообщение об ошибке и вернуть нулевую матрицу (кто знает исключения, 
можно их использовать).

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62_
{
    class Matrix2x2
    {
        double[,] m = new double[2, 2];

        public Matrix2x2(double m00, double m01, double m10, double m11)
        {
            m[0, 0] = m00;
            m[0, 1] = m01;
            m[1, 0] = m10;
            m[1, 1] = m11;
        }
        public Matrix2x2() : this(0, 0, 0, 0) { }
        public Matrix2x2(double k)
        {
            m[0, 0] = m[0, 1] = m[1, 0] = m[1, 1] = k;

        }
        public Matrix2x2(double[,] c)
        {
            if (c.GetLength(0) == 2 && c.GetLength(1) == 2)
                for (int i = 0; i < 2; i++)
                    for (int j = 0; j < 2; j++)
                    {
                        m[i, j] = c[i, j];
                    }
        }
        public Matrix2x2 add(Matrix2x2 b)
        {
            Matrix2x2 res = new Matrix2x2();
            if (b.m.GetLength(0) == 2 && b.m.GetLength(1) == 2)
            {
                for (int i = 0; i < res.m.GetLength(0); i++)
                    for (int j = 0; j < res.m.GetLength(1); j++)
                        res.m[i, j] = this.m[i, j] + b.m[i, j];
                return res;
            }
            return res;

        }
        public static Matrix2x2 operator -(Matrix2x2 a, Matrix2x2 b)
        {

            Matrix2x2 res = new Matrix2x2();
            for (int i = 0; i < res.m.GetLength(0); i++)
                for (int j = 0; j < res.m.GetLength(1); j++)
                    res.m[i, j] = a.m[i, j] - b.m[i, j];
            return res;
        }
        public static Matrix2x2 operator *(Matrix2x2 a, double d)
        {
            Matrix2x2 res = new Matrix2x2();
            res.m[0, 0] = a.m[0, 0] * d;
            res.m[0, 1] = a.m[0, 1] * d;
            res.m[1, 0] = a.m[1, 0] * d;
            res.m[1, 1] = a.m[1, 1] * d;
            return res;
        }
        public static Matrix2x2 operator /(Matrix2x2 a, double d)
        {
            Matrix2x2 res = new Matrix2x2();
            res.m[0, 0] = a.m[0, 0] / d;
            res.m[0, 1] = a.m[0, 1] / d;
            res.m[1, 0] = a.m[1, 0] / d;
            res.m[1, 1] = a.m[1, 1] / d;
            return res;
        }
        public static bool operator ==(Matrix2x2 a, Matrix2x2 b) {
            bool f = true;
            if (a.m[0, 0] != b.m[0, 0] || a.m[0, 1] != b.m[0, 1] || a.m[1, 0] != b.m[1, 0] || a.m[1, 1] != b.m[1, 1])
                f = false;
            return f;
        }
        public static bool operator !=(Matrix2x2 a, Matrix2x2 b)
        {
            bool f = true;
            if (a.m[0, 0] == b.m[0, 0] || a.m[0, 1] == b.m[0, 1] || a.m[1, 0] == b.m[1, 0] || a.m[1, 1] == b.m[1, 1])
                f = false;
            return f;
        }

        public void add2(Matrix2x2 b)
        {

            if (b.m.GetLength(0) == 2 && b.m.GetLength(1) == 2)
            {
                for (int i = 0; i < m.GetLength(0); i++)
                    for (int j = 0; j < m.GetLength(1); j++)
                        this.m[i, j] += b.m[i, j];

            }

        }
        public Matrix2x2 sub(Matrix2x2 b)
        {
            Matrix2x2 res = new Matrix2x2();
            if (b.m.GetLength(0) == 2 && b.m.GetLength(1) == 2)
            {
                for (int i = 0; i < res.m.GetLength(0); i++)
                    for (int j = 0; j < res.m.GetLength(1); j++)
                        res.m[i, j] = this.m[i, j] - b.m[i, j];
                return res;
            }
            return res;

        }
        public void sub2(Matrix2x2 b)
        {

            if (b.m.GetLength(0) == 2 && b.m.GetLength(1) == 2)
            {
                for (int i = 0; i < m.GetLength(0); i++)
                    for (int j = 0; j < m.GetLength(1); j++)
                        this.m[i, j] -= b.m[i, j];

            }

        }
        public Matrix2x2 multNumber(double r)
        {
            Matrix2x2 res = new Matrix2x2();
            if (m.GetLength(0) == 2 && m.GetLength(1) == 2)
            {
                for (int i = 0; i < res.m.GetLength(0); i++)
                    for (int j = 0; j < res.m.GetLength(1); j++)
                        res.m[i, j] = this.m[i, j] * r;
                return res;
            }
            return res;

        }
        public void multNumber2(double r)
        {
            if (m.GetLength(0) == 2 && m.GetLength(1) == 2)
            {
                for (int i = 0; i < m.GetLength(0); i++)
                    for (int j = 0; j < m.GetLength(1); j++)
                        this.m[i, j] *= r;

            }

        }
        public Matrix2x2 mult(Matrix2x2 b)
        {
            Matrix2x2 res = new Matrix2x2();
            if (m.GetLength(0) == 2 && m.GetLength(1) == 2)
            {
                res.m[0, 0] = this.m[0, 0] * b.m[0, 0] + this.m[0, 1] * b.m[1, 0];
                res.m[0, 1] = this.m[0, 0] * b.m[0, 1] + this.m[0, 1] * b.m[1, 1];
                res.m[1, 0] = this.m[1, 0] * b.m[0, 0] + this.m[1, 1] * b.m[1, 0];
                res.m[1, 1] = this.m[1, 0] * b.m[0, 1] + this.m[1, 1] * b.m[1, 1];

            }
            return res;
        }
        public void mult2(Matrix2x2 b)
        {
            Matrix2x2 res = new Matrix2x2();
            if (m.GetLength(0) == 2 && m.GetLength(1) == 2)
            {
                res.m[0, 0] = this.m[0, 0] * b.m[0, 0] + this.m[0, 1] * b.m[1, 0];
                res.m[0, 1] = this.m[0, 0] * b.m[0, 1] + this.m[0, 1] * b.m[1, 1];
                res.m[1, 0] = this.m[1, 0] * b.m[0, 0] + this.m[1, 1] * b.m[1, 0];
                res.m[1, 1] = this.m[1, 0] * b.m[0, 1] + this.m[1, 1] * b.m[1, 1];
            }
            this.m[0, 0] = res.m[0, 0];
            this.m[0, 1] = res.m[0, 1];
            this.m[1, 0] = res.m[1, 0];
            this.m[1, 1] = res.m[1, 1];

        }
        public double det()
        {
            return this.m[0, 0] * this.m[1, 1] - this.m[0, 1] * this.m[1, 0];
        }
        public void transpon()
        {
            if (m.GetLength(0) == 2 && m.GetLength(1) == 2)
            {
                double tmp = m[0, 1];
                m[0, 1] = m[1, 0];
                m[1, 0] = tmp;

            }
        }
        public override string ToString()
        {
            return $"{m[0, 0]},{ m[0, 1]},{ m[1, 0]},{ m[1, 1]}";
        }
        public Matrix2x2 inverseMatrix()
        {

            Matrix2x2 inverseMatrix = new Matrix2x2();
            double det = this.det();
            if (det == 0)
            {
                Console.WriteLine("eror");
                inverseMatrix.m[0, 0] = 0;
                inverseMatrix.m[0, 1] = 0;
                inverseMatrix.m[1, 0] = 0;
                inverseMatrix.m[1, 1] = 0;

            }
            else
            {
                inverseMatrix.m[0, 0] = m[1, 1];
                inverseMatrix.m[0, 1] = -m[1, 0];
                inverseMatrix.m[1, 0] = -m[0, 1];
                inverseMatrix.m[1, 1] = m[0, 0];
                inverseMatrix.multNumber2((1 / det));

            }

            return inverseMatrix;
        }



    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
