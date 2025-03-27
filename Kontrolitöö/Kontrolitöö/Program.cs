//Выбор с помощью свмтча
// 1.ThenBy OrderBy
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace Kontrolitöö
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta meetodi number");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. ThenBy ja OrderBy"); 
            Console.WriteLine("2. File writer "); 
            Console.WriteLine("3. ForLoop piramiid"); 
            Console.WriteLine("\n\nPalun tee valik numbriga: ");

            byte metod = byte.Parse(Console.ReadLine());

           

            switch (metod)
            {
                case 1:
                    ThenBy();
                    break;

                case 2:
                    textFile();
                    break;

                case 3:
                    ForLoopPiramiid();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
            }

           
        }

        public static void ThenBy()
        {
     
            var thenByResult = PeopleList.peoples
                .OrderBy(x => x.Age)
                .ThenBy(x => x.Name);

            Console.WriteLine("List of people by ages");
            foreach (var people in thenByResult)
            {
                Console.WriteLine(people.Age + " " + people.Name);
            }
        }

        public static void textFile()
        {

          
            Console.WriteLine("Kirjuta file path.");
            Console.WriteLine("For example - C:/Users/opilane/Uus/WriteToFile.txt ");
            string filePath = Console.ReadLine();


            if(!Directory.Exists(filePath))
            {


                Console.WriteLine("Kirjuta faili text.");
            string inputText = Console.ReadLine();
            File.WriteAllText(filePath, inputText);

            }
            else
                {
                Console.WriteLine("Error");
                    }



            //@"C:/Users/opilane/Uus/WriteToFile.txt";

        }



        static void ForLoopPiramiid()
        {
             int i, j, n ;
            Console.WriteLine("Sisesta ridade arv");
           int height = int.Parse(Console.ReadLine());

            for (i= 0; i <= height; i++)
            {
               

                for (j = 1; j <= height -i; j++)
                {
                    Console.Write(" ");
                }
                for (j =  1; j <= 2 * i - 1; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }


    }
}
