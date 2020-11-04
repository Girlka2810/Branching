using System;

namespace Branching
{
    public class BranchingMethods
    {
        static public int CompareAAndBAndSolve(int a, int b)
        {
            if (a > b)
            {
                return (a + b);
            }
            else if (a == b)
            {
                return (a * b);
            }
            else
            {
                return (a - b);
            }
        }

        static public string FindQuater(int x, int y)
        {
            if (x > 0 && y > 0)
            {
                return ("1-st quater");
            }
            else if (x < 0 && y > 0)
            {
                return ("2-nd quater");
            }
            else if (x < 0 && y < 0)
            {
                return ("3-d quater");
            }
            else
            {
                return ("4-th quater");
            }
        }

        static public int[] SelectionSort(int[] arr)
        {
            int min, temp;
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
            return arr;

        }
            static public int[] SortInIncreasingNumbers(int a, int b, int c)
            {
                int[] array = new int[3] { a, b, c };
                array = SelectionSort(array);
                return array;
            }

            static public string FindDiscriminant(double a, double b, double c)
            {
                double d = b * b - 4 * a * c;
                double x1 = -b + Math.Sqrt(d) / (2 * a);
                double x2 = -b - Math.Sqrt(d) / (2 * a);
                double x3 = -b / 2 * a;
                if (d > 0)
                    return ("Корни квадратного уравнения: " + "x1 = " + x1 + ", x2 = " + x2);
                else if (d == 0)
                    return ("Уравнение имеет один корень: " + "x1 = " + x3);
                else
                    return ("Квадратное уравнение не имеет решений");
            }

            static public string IdentifyNumber(int a)
            {
                string num = "";
                if (a < 10)
                    throw new Exception("A must be from 10 to 99");
                if (a / 10 == 1 && a % 10 == 0)
                    num += ("Десять ");
                if (a / 10 == 1 && a % 10 == 1)
                    num += ("Одинадцать ");
                if (a / 10 == 1 && a % 10 == 2)
                    num += ("Двенадцать ");
                if (a / 10 == 1 && a % 10 == 3)
                    num += ("Тринадцать ");
                if (a / 10 == 1 && a % 10 == 4)
                    num += ("Четырнадцать ");
                if (a / 10 == 1 && a % 10 == 5)
                    num += ("Пятнадцать ");
                if (a / 10 == 1 && a % 10 == 6)
                    num += ("Шеснадцать ");
                if (a / 10 == 1 && a % 10 == 7)
                    num += ("Семнадцать ");
                if (a / 10 == 1 && a % 10 == 8)
                    num += ("Восемнадцать ");
                if (a / 10 == 1 && a % 10 == 9)
                    num += ("Девятнадцать ");
                if (a / 10 == 2)
                    num += ("Двадцать ");
                if (a / 10 == 3)
                    num += ("Тридцать ");
                if (a / 10 == 4)
                    num += ("Сорок ");
                if (a / 10 == 5)
                    num += ("Пятьдесят ");
                if (a / 10 == 6)
                    num += ("Шестьдесят ");
                if (a / 10 == 7)
                    num += ("Семьдесят ");
                if (a / 10 == 8)
                    num += ("Восемьдесят ");
                if (a / 10 == 9)
                    num += ("Девяносто ");
                if (a / 10 > 1)
                {
                    if (a % 10 == 1)
                        num += ("Один");
                    else if (a % 10 == 2)
                        num += ("Два");
                    else if (a % 10 == 3)
                        num += ("Три");
                    else if (a % 10 == 4)
                        num += ("Четыре");
                    else if (a % 10 == 5)
                        num += ("Пять");
                    else if (a % 10 == 6)
                        num += ("Шесть");
                    else if (a % 10 == 7)
                        num += ("Семь");
                    else if (a % 10 == 8)
                        num += ("Восемь");
                    else if (a % 10 == 9)
                        num += ("Девять");
                    else if (a % 10 == 0)
                        num += ("Ноль");
                }
                return num;
            }
        }
    }
