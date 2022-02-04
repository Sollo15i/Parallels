using Parallels;
using System;

namespace HalloWorld
{
    class Program

    {
      
        static void Main(string[] args)
        {
            myClassSong();

        }

        static void Calculator()
        {
            Console.WriteLine("хо-хо. Добро пожаловать в калькулятор))");
            Console.WriteLine("Введи первое число");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введи оператор");

            string op = Console.ReadLine();

            Console.WriteLine("Введи первое число");
            int num2 = int.Parse(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else
            {
                Console.WriteLine("Вы ввели не тот оператор");
            }



        }

        static void Massiv()
        {
            int[] kontainers =  { 4, 41, 42, 41, 66, 5};
            string[] friends = { "Nikita", "Nastya", "Masha", "Olya" };


            kontainers[2] = 777;
            Console.WriteLine(kontainers);
            Console.WriteLine(friends);

            for (int i = 0; i < kontainers.Length; i++)
            {
                Console.WriteLine(kontainers[i]);   

                for (int j = 0; j < friends.Length; j++)
                {
                    Console.WriteLine(friends[j]);
                    break;
                }
            }

            Console.WriteLine("----");

            foreach (var num in kontainers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("-----");

            foreach (var friend in friends)
            {
                Console.WriteLine(friend);
            }


        }

        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hi {name} {age}");
        }

        static int ReturnMethood(int num)
        {
            int result = num * num * num;
            return result;
        }

        static void IfElseMethood()
        {
            bool isTall = false;
            bool isMale = true;
            bool iseyeBlue = true;

            if (!iseyeBlue && isMale && iseyeBlue)
            {
                Console.WriteLine("Высокий, голубые глаза и ты мужчина!");
            }
            else if (isTall || isMale || iseyeBlue)
            {
                Console.WriteLine("что-то в тебе есть...");
            }
            else if (isTall || !iseyeBlue)
            {
                Console.WriteLine("Твои глаза..");
            }

        }

        static void GetMax ()
        {
            Console.WriteLine("Введи два числа через энтер");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            //int num3 = int.Parse(Console.ReadLine());


            Console.WriteLine(Math.Max(num1, num2));

           
            
        }

        static string getDaySwitch(int dayNum )
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;

                case 1:
                    dayName = "Tuesday";
                    break;

                case 2:
                    dayName = "Wednseday";
                    break;
                
                case 3:
                    dayName = "thursday";
                    break;
                
                case 4:
                    dayName = "friday";
                    break;
                
                case 5:
                    dayName = "saturday";
                    break;
                
                case 6:
                    dayName = "sunday";
                    break;

                default:
                    dayName = "Invalid Number";
                    break;

                    

            }
            return dayName;

        }

        static void CycleWhile()
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
        }

        static void CycleWhileGame()
        {
            string secredWord = "cat";
            string guessWord = "";
            int count = 0;
            int countLimit = 3;
            bool guessWordUser = false; 


            Console.WriteLine("мурчит");

            while (secredWord != guessWord && !guessWordUser)
            {
                if (count < countLimit)
                {
                    Console.WriteLine($"попытка № {count + 1} ...");
                    guessWord = Console.ReadLine();
                    count++;
                }
                else
                {
                    guessWordUser = true;
                }
            }
            if (guessWordUser)
            {
                Console.WriteLine("you lose");
            }
            else 
            {
                Console.WriteLine($"Победа! это действительно \"{secredWord}\"");
            }
            
            
            
        }

        static void CycleFor()
        {
            int[] massivChisel = { 22, 2313, 123, 1, 123, 22, 30, 1, 40, 123, 3 };
            for (int i = 0; i < massivChisel.Length; i++)
            {
                Console.WriteLine(massivChisel[i]);
            }
        }

        static int GetPow ( int baseNum, int powNum)
        {
            int result = 1;
            for (int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
            // Console.WriteLine(GetPow(2,3));
        }

        static void DvoynoyMassiv()
        {
            int[,] numberGrid =
            {
                {23,32 },
                {4532,554 },
                {1,2},
                {12,3},
            };
        }

        static void TryCath()
        {
            try
            {
                int num1 = 2;
                int num2 = 0;
                Console.WriteLine(num1/num2);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Error");
                Console.WriteLine(exp.GetType()) ;
                Console.WriteLine(exp.Message) ;
            }
        }

        static void myClassBook()
        {

            Book book1 = new Book("Кот в тапках", "Никита Рошка", 18);
            Book book2 = new Book("Кот в тапках", "Никита Рошка", 18);
            Console.WriteLine(book1.title);
            
        }

        static void myClassStudent()
        {
            myClassStudent();
            Student student1 = new Student("Jum", "Manager", 2.3);
            Student student2 = new Student("Nikita", "Kupec", 5);

            Console.WriteLine(student1.hasHonors());
            Console.WriteLine(student2.hasHonors());
        }

        static void myClassSong()
        {
            Song scriptonit = new Song("Животные", "Скриптонит", 200);
            Song pharaoh = new Song("Плакшели", "Фараон", 140);
            Song pharaoh1 = new Song("Плакшели", "Фараон", 140);
            Console.WriteLine(Song.songCount);
            Song pharaoh2 = new Song("Плакшели", "Фараон", 140);
            Song pharaoh3 = new Song("Плакшели", "Фараон", 140);
            Song pharaoh4 = new Song("Плакшели", "Фараон", 140);
            
        }



    }

}