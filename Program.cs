using System;
using System.IO;
using LibraryFor2DArray;

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

         string nameFileOne = "a.txt";
         string nameFileTwo = "b.txt";
         string nameFileThree = "c.txt";
         string nameFileFour = "finish.txt";

         int rowOne = ClassFor2DArray.SizeRow(nameOne);
         int columnOne = ClassFor2DArray.SizeColumn(nameOne);
         int rowTwo = ClassFor2DArray.SizeRow(nameTwo);
         int columnTwo = ClassFor2DArray.SizeColumn(nameTwo);
         int rowThree = ClassFor2DArray.SizeRow(nameThree);
         int columnThree = ClassFor2DArray.SizeColumn(nameThree);

         string pathOne = Path.GetFullPath(nameFileOne);
         string pathTwo = Path.GetFullPath(nameFileTwo);
         string pathThree = Path.GetFullPath(nameFileThree);

         double minOne = 0;
         double[,] sourceOne = ClassFor2DArray.VvodArray(pathOne, nameFileOne);
         if (sourceOne.GetLength(0) == 0)
         {
            Console.WriteLine("Файл {0} пуст", nameFileOne);
         }
         else
         {
            double[,] searchOne = ClassFor2DArray.InputArray(sourceOne, rowOne, columnOne, nameOne);
            bool flOne = ClassFor2DArray.SearchingPositiv(searchOne);
            if (flOne)
            {
               Console.WriteLine("В двумерном массиве {0} нет искомых положительных элементов", nameOne);
            }
            else
            {
               minOne = ClassFor2DArray.SearchingMinPositiv(searchOne, nameOne);
            }
         }

         double minTwo = 0;
         double[,] sourceTwo = ClassFor2DArray.VvodArray(pathTwo, nameFileTwo);
         if (sourceTwo.GetLength(0) == 0)
         {
            Console.WriteLine("Файл {0} пуст", nameFileTwo);
         }
         else
         {
            double[,] searchTwo = ClassFor2DArray.InputArray(sourceTwo, rowTwo, columnTwo, nameTwo);
            bool flTwo = ClassFor2DArray.SearchingPositiv(searchTwo);
            if (flTwo)
            {
               Console.WriteLine("В двумерном массиве {0} нет искомых положительных элементов", nameTwo);
            }
            else
            {
               minTwo = ClassFor2DArray.SearchingMinPositiv(searchTwo, nameTwo);
            }
         }

         double minThree = 0;
         double[,] sourceThree = ClassFor2DArray.VvodArray(pathThree, nameFileThree);
         if (sourceThree.GetLength(0) == 0)
         {
            Console.WriteLine("Файл {0} пуст", nameFileThree);
         }
         else
         {
            double[,] searchThree = ClassFor2DArray.InputArray(sourceThree, rowThree, columnThree, nameThree);
            bool flThree = ClassFor2DArray.SearchingPositiv(searchThree);
            if (flThree)
            {
               Console.WriteLine("В двумерном массиве {0} нет искомых положительных элементов", nameThree);
            }
            else
            {
               minThree = ClassFor2DArray.SearchingMinPositiv(searchThree, nameThree);
            }
         }

         double result = ClassFor2DArray.CalculatingValue(minOne, minTwo, minThree);
         Console.WriteLine("Результат Amin * Bmin – Cmin: {0}", result);
         //Console.WriteLine("Результат Amin * Bmin – Cmin: {0:f2}", result);
         //Console.WriteLine("Результат Amin * Bmin – Cmin: {0:f}", result);

         string[] stringArray = ClassFor2DArray.VivodString(result);
         string pathFour = Path.GetFullPath(nameFileFour);
         if (!File.Exists(pathFour))
         {
            Console.WriteLine("Файл {0} не существует. Создаем новый", nameFileFour);
            File.Create(pathFour);
         }
         else
         {
            // Очищаем содержимое файла
            Console.WriteLine("Файл {0} содержит предыдущие результаты. Очищаем данные", nameFileFour);
            File.Create(pathFour).Close();
         }

         ClassFor2DArray.FileWriteString(stringArray, nameFileFour);
         Console.ReadKey();
      }
   }
}