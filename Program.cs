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





         int rowOne = VariousMethods.SizeRow(nameOne);
         int columnOne = VariousMethods.SizeColumn(nameOne);
         int rowTwo = VariousMethods.SizeRow(nameTwo);
         int columnTwo = VariousMethods.SizeColumn(nameTwo);
         int rowThree = VariousMethods.SizeRow(nameThree);
         int columnThree = VariousMethods.SizeColumn(nameThree);
         //double[,] arrayDouble = VariousMethods.VvodArray(rowOne, columnOne);
         //Console.WriteLine();
         //double[,] arraySearch = VariousMethods.InputArray(arrayDouble, rowOne, columnOne);
         //Console.WriteLine();
         //double[] arrayMax = VariousMethods.FindMax(arraySearch);
         //Console.WriteLine();
         //string[] stringArray = VariousMethods.VivodStringArray(arrayMax);
         //Console.WriteLine();
         //VariousMethods.FileWriteString(stringArray);
         //Console.WriteLine();

         Console.ReadKey();
      }
   }
}