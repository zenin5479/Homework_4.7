using System;

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

         int n = VariousMethods.SizeRow();
         int m = VariousMethods.SizeColumn();
         double[,] arrayDouble = VariousMethods.VvodArray(n, m);
         Console.WriteLine();
         double[,] arraySearch = VariousMethods.InputArray(arrayDouble, n, m);
         Console.WriteLine();
         double[] arrayMax = VariousMethods.FindMax(arraySearch);
         Console.WriteLine();
         string[] stringArray = VariousMethods.VivodStringArray(arrayMax);
         Console.WriteLine();
         VariousMethods.FileWriteString(stringArray);
         Console.WriteLine();
         //string[] arrayString = VariousMethods.VivodArrayString(arrayMax);
         //Console.WriteLine();
         //VariousMethods.FileWriteArray(arrayString);

         Console.ReadKey();
      }
   }
}