using System;
using System.IO;

// Разработать программу для обработки двух или трёх двумерных массивов разного размера с использованием подпрограмм
// При разработке подпрограмм предусмотреть случай, когда искомых элементов нет
// Необходимо выбрать подходящий тип подпрограммы, для ввода и вывода тоже использовать подпрограммы
// Быть внимательным при выборе типа данных заданных массивов
// Вычислить значение выражения Amin * Bmin – Cmin, где Amin, Bmin и Cmin – минимальные значения
// среди положительных элементов двумерных массивов A, B и C

namespace Homework_4._7
{
   internal class Program
   {
      static void Main(string[] args)
      {
         // Переводит (,) в (.)
         //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

         string nameOne = "A";
         string nameTwo = "B";
         string nameThree = "C";

         int rowOne = VariousMethods.SizeRow(nameOne);
         int columnOne = VariousMethods.SizeColumn(nameOne);
         int rowTwo = VariousMethods.SizeRow(nameTwo);
         int columnTwo = VariousMethods.SizeColumn(nameTwo);
         int rowThree = VariousMethods.SizeRow(nameThree);
         int columnThree = VariousMethods.SizeColumn(nameThree);

         string pathOne = Path.GetFullPath("a.txt");
         if (!File.Exists(pathOne))
         {
            Console.WriteLine("Ошибка при открытии файла для чтения. Файл не существует");
         }

         string pathTwo = Path.GetFullPath("b.txt");
         if (!File.Exists(pathTwo))
         {
            Console.WriteLine("Ошибка при открытии файла для чтения. Файл не существует");
         }

         string pathThree = Path.GetFullPath("c.txt");
         if (!File.Exists(pathThree))
         {
            Console.WriteLine("Ошибка при открытии файла для чтения. Файл не существует");
         }
         string pathFour = Path.GetFullPath("finish.txt");
         if (!File.Exists(pathFour))
         {
            Console.WriteLine("Ошибка при открытии файла для чтения. Файл не существует");
            File.Create(pathFour);
         }
         else
         {
            Console.WriteLine("Файл существует. Очищаем");
            // Очищаем содержимое файла
            // Вариант 1
            File.Create(pathFour).Close();
            // Вариант 2
            //File.WriteAllLines(pathFour, new string[0]);
            //File.WriteAllLines(pathFour, Array.Empty<string>());
            // Вариант 3
            //File.WriteAllText(pathFour, string.Empty);
            // Вариант 4
            //File.WriteAllBytes(pathFour, new byte[0]);
            //File.WriteAllBytes(pathFour, Array.Empty<byte>());
            // Вариант 5
            //FileStream fileStream = new FileStream(pathFour, FileMode.Truncate);
            //fileStream.Close();
            // Вариант 6
            //FileStream fileStream = new FileStream(pathFour, FileMode.Open);
            //fileStream.SetLength(0);
            //fileStream.Close();
         }

         // Перенести проверку на ноль в метод VvodArray
         double[,] sourceOne = VariousMethods.VvodArray(pathOne, nameOne);
         if (sourceOne.GetLength(0) == 0 && sourceOne.GetLength(1) == 0)
         {
            Console.WriteLine("Исходный массив строк {0} пуст", nameOne);
         }
         else
         {
            double[,] searchOne = VariousMethods.InputArray(sourceOne, rowOne, columnOne, nameOne);
            bool fl = VariousMethods.SearchingPositiv(searchOne);
            Console.WriteLine(fl);

            //double[] maxOne = VariousMethods.FindMaxArray(searchOne, nameOne);
            //string[] stringArray = VariousMethods.VivodStringArray(maxOne);
            //VariousMethods.FileWriteString(stringArray);
         }

         Console.ReadKey();
      }

      double find_min_positive(double[,] search)
      {
         double min = search[0, 0];
         int i = 0;
         while (i < search.GetLength(0))
         {
            int j = 0;
            while (j < search.GetLength(1))
            {
               if (search[i, j] > 0)
               {
                  fl = false;
               }
               else
               {
                  j++;
               }


               if (min < 0 && search[i, j] > min && j < search.GetLength(1))
               {
                  min = search[i, j];
               }
               else
               {
                  if (search[i, j] > 0 && search[i, j] < min)
                  {
                     min = search[i, j];
                  }
               }




            }

            i++;
         }






         //for (int i = 0; i < n; i++)
         //{
         //   for (int j = 0; j < m; j++)
         //   {
         //      if (min < 0 && x[i][j] > min && j < m)
         //      {
         //         min = x[i][j];
         //      }
         //      else
         //      {
         //         if (x[i][j] > 0 && x[i][j] < min)
         //         {
         //            min = x[i][j];
         //         }
         //      }
         //   }
         //}

         return min;
      }
   }
}