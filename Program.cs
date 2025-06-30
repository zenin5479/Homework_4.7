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
         string pathTwo = Path.GetFullPath("b.txt");
         string pathThree = Path.GetFullPath("c.txt");
         string pathFour = Path.GetFullPath("finish.txt");
         if (!File.Exists(pathFour))
         {
            Console.WriteLine("Файл не существует");
            File.Create(pathFour);
         }
         else
         {
            // Очищаем содержимое файла
            File.Create(pathFour).Close();
         }

         double minOne = -1.0;
         double[,] sourceOne = VariousMethods.VvodArray(pathOne, nameOne);
         if (sourceOne.GetLength(0) == 0)
         {
            Console.WriteLine("Файл пуст");
         }
         else
         {
            double[,] searchOne = VariousMethods.InputArray(sourceOne, rowOne, columnOne, nameOne);
            bool flOne = VariousMethods.SearchingPositiv(searchOne);
            if (!flOne)
            {
               minOne = VariousMethods.SearchingMinPositiv(searchOne);
               Console.WriteLine(minOne);
            }
            else
            {
               Console.WriteLine("В двумерном массиве {0} нет искомых положительных элементов", nameOne);
            }
         }

         double minTwo = -1.0;
         double[,] sourceTwo = VariousMethods.VvodArray(pathTwo, nameTwo);
         if (sourceTwo.GetLength(0) == 0)
         {
            Console.WriteLine("Файл пуст");
         }
         else
         {
            double[,] searchTwo = VariousMethods.InputArray(sourceTwo, rowTwo, columnTwo, nameTwo);
            bool flTwo = VariousMethods.SearchingPositiv(searchTwo);
            if (!flTwo)
            {
               minTwo = VariousMethods.SearchingMinPositiv(searchTwo);
               Console.WriteLine(minTwo);
            }
            else
            {
               Console.WriteLine("В двумерном массиве {0} нет искомых положительных элементов", nameTwo);
            }
         }



         // Сравниваем значения double используя метод CompareTo(Double) 
         if (minTwo.CompareTo(-1.0) == 0)
         {

         }


         //string[] stringArray = VariousMethods.VivodStringArray(maxOne);
         //VariousMethods.FileWriteString(stringArray);

         Console.ReadKey();
      }

      double CalculatingValue(double minOne, double minTwo, double minThree)
      {
         return minOne * minTwo - minThree;
      }
   }
}