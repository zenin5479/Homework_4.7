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

         string nameFileOne = "a.txt";
         string nameFileTwo = "b.txt";
         string nameFileThree = "c.txt";
         string nameFileFour = "finish.txt";

         int rowOne = MethodsForArray.SizeRow(nameOne);
         int columnOne = MethodsForArray.SizeColumn(nameOne);
         int rowTwo = MethodsForArray.SizeRow(nameTwo);
         int columnTwo = MethodsForArray.SizeColumn(nameTwo);
         int rowThree = MethodsForArray.SizeRow(nameThree);
         int columnThree = MethodsForArray.SizeColumn(nameThree);

         string pathOne = Path.GetFullPath(nameFileOne);
         string pathTwo = Path.GetFullPath(nameFileTwo);
         string pathThree = Path.GetFullPath(nameFileThree);

         double minOne = 0;
         double[,] sourceOne = MethodsForArray.VvodArray(pathOne, nameFileOne);
         if (sourceOne.GetLength(0) == 0)
         {
            Console.WriteLine("Файл {0} пуст", nameFileOne);
         }
         else
         {
            double[,] searchOne = MethodsForArray.InputArray(sourceOne, rowOne, columnOne, nameOne);
            bool flOne = MethodsForArray.SearchingPositiv(searchOne);
            if (flOne)
            {
               Console.WriteLine("В двумерном массиве {0} нет искомых положительных элементов", nameOne);
            }
            else
            {
               minOne = MethodsForArray.SearchingMinPositiv(searchOne, nameOne);
            }
         }

         double minTwo = 0;
         double[,] sourceTwo = MethodsForArray.VvodArray(pathTwo, nameFileTwo);
         if (sourceTwo.GetLength(0) == 0)
         {
            Console.WriteLine("Файл {0} пуст", nameFileTwo);
         }
         else
         {
            double[,] searchTwo = MethodsForArray.InputArray(sourceTwo, rowTwo, columnTwo, nameTwo);
            bool flTwo = MethodsForArray.SearchingPositiv(searchTwo);
            if (flTwo)
            {
               Console.WriteLine("В двумерном массиве {0} нет искомых положительных элементов", nameTwo);
            }
            else
            {
               minTwo = MethodsForArray.SearchingMinPositiv(searchTwo, nameTwo);
            }
         }

         double minThree = 0;
         double[,] sourceThree = MethodsForArray.VvodArray(pathThree, nameFileThree);
         if (sourceThree.GetLength(0) == 0)
         {
            Console.WriteLine("Файл {0} пуст", nameFileThree);
         }
         else
         {
            double[,] searchThree = MethodsForArray.InputArray(sourceThree, rowThree, columnThree, nameThree);
            bool flThree = MethodsForArray.SearchingPositiv(searchThree);
            if (flThree)
            {
               Console.WriteLine("В двумерном массиве {0} нет искомых положительных элементов", nameThree);
            }
            else
            {
               minThree = MethodsForArray.SearchingMinPositiv(searchThree, nameThree);
            }
         }

         double result = MethodsForArray.CalculatingValue(minOne, minTwo, minThree);
         Console.WriteLine("Результат Amin * Bmin – Cmin: {0}", result);
         //Console.WriteLine("Результат Amin * Bmin – Cmin: {0:f2}", result);
         //Console.WriteLine("Результат Amin * Bmin – Cmin: {0:f}", result);

         string[] stringArray = MethodsForArray.VivodString(result);
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

         MethodsForArray.FileWriteString(stringArray, nameFileFour);
         Console.ReadKey();
      }
   }
}