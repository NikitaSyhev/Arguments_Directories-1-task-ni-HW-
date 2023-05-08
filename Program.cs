using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace Arguments_Directories
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //
            //003 Программы должна принимать на вход, как аргумент командной строки имя каталога в файловой системе
            //и выводить список файлов и папок этого каталога.В случае отсутствия параметров программа должна вывести информацию о
            //текущем каталоге.
            if (args.Length > 0)
            {
                string directory = args[0]; // аргумент командной строки - директория
                if (Directory.Exists(directory)) // проверка
                {
                    Console.WriteLine("Подкаталоги:");
                    string[] dirs = Directory.GetDirectories(directory); // получаем подкаталоги
                    foreach (string s in dirs)
                    {
                        Console.WriteLine(s); //вывод
                    }
                    Console.WriteLine();
                    Console.WriteLine("Файлы:"); // получаем спискок файлов
                    string[] files = Directory.GetFiles(directory);
                    foreach (string s in files)
                    {
                        Console.WriteLine(s);//вывод
                    }
                }
            }
            else
            {
                Console.WriteLine(Directory.GetCurrentDirectory());
            }
            Console.ReadLine();
        }
    }
}
