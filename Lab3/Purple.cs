using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Вводи X и Y");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (Math.Abs(x) < Math.Abs(r1) && Math.Abs(y) < Math.Abs(r1))
                {
                    count ++;
                }
            }
            // end

            return count;
        }
        
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Оценки ученика под номером {i}");
                int fst = int.Parse(Console.ReadLine());
                int scd = int.Parse(Console.ReadLine());
                int trd = int.Parse(Console.ReadLine());
                int fth = int.Parse(Console.ReadLine());
                average += fst + scd + trd + fth;
                if (fst == 2 || scd == 2 || trd == 2 || fth == 2)
                {
                    count ++;
                }
            }
            average /= n;
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory = exams, practice = exams, mark = exams, n = exams;
            double score = 0;
            while (exams > 0)
            {
                Console.WriteLine("Вводи");
                theory = int.Parse(Console.ReadLine());
                practice = int.Parse(Console.ReadLine());
                score = 0.4 * theory + 0.6 * practice;
                if (score > 85)
                {
                    mark = 5;
                }
                else if (score > 70)
                {
                    mark = 4;
                }
                else if (score > 50)
                {
                    mark = 3;
                }
                else
                {
                    mark = 2;
                }
                avgMark += mark /n;
                exams--;
            }
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here
            while (limit > 0)
            {
                limit--;
                attempts++;
                Console.WriteLine("Первая Цифра");
                int fst = int.Parse(Console.ReadLine());
                if (fst == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                Console.WriteLine("Вторая Цифра");
                int scnd = int.Parse(Console.ReadLine());
                if (scnd == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                Console.WriteLine("Третья Цифра");
                int trd = int.Parse(Console.ReadLine());
                if (trd == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int res = (fst * 100) + (scnd * 10) + trd;
                if (res == code)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
                else if (limit == 0)
                {
                    solution = "Система заблокирована!";
                    break;
                }
                else
                {
                    Console.WriteLine("НЕ УГАДАЛ");
                }
            }
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here
            for (int i = a; i < a + n; i++)
            {
                switch (i)
                {
                    case 1 or 8 or 15 or 22 or 29:
                        luck *= 1.5;
                        if (luck > 100)
                            luck = 100;
                        break;
                    case 4 or 11 or 18 or 25:
                        luck -= 10;
                        if (luck < 0)
                            luck = 0;
                        break;
                    case 7 or 14 or 21 or 28:
                        if (luck < 50)
                            luck = 55;
                        break;
                    default:
                        luck += 5;
                        if (luck > 100)
                            luck = 100;
                        break;
                }
            }
            // end

            return luck;
        }
    }
}
