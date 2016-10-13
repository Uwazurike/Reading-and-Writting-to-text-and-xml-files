using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Reading_from_text_files_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\Users\\iykef\\OneDrive\\Documents\\numbers.txt";

            StreamWriter myStreamWritter = new StreamWriter(fileName, true);

            for (int i = 0; i < 100; i++)

            {
                List<Numbers> myNumbers = new List<Numbers>();

                Numbers name = new Numbers();
                name.NumCount = string.Format("The Number Is {0}", i + 1);
                myNumbers.Add(name);

                myStreamWritter.WriteLine(name.NumCount);
            }
            myStreamWritter.Close();

            StreamReader myStreamReader = new StreamReader(fileName);

            for (int i = 0; i < 100; i++)

                if (File.Exists(fileName))

                {

                    while (!myStreamReader.EndOfStream)

                    {
                        List<Numbers> myNumbers = new List<Numbers>();
                        string myRead = myStreamReader.ReadLine();

                        string[] values = myRead.Split(',');
                        Numbers name2 = new Numbers();
                        myNumbers.Add(name2);
                        name2.NumCount = string.Format("The Number Is {0}", i++);
                        Console.WriteLine(name2.NumCount);
                    }
                }

                else

                {
                   Console.WriteLine("This file is missing");

                }
                   Console.ReadKey();
        }
    }
}
   