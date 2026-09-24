using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;

            // code here
            int pNum = 1;

            while (n > 0)
            {
                Console.WriteLine($"Point #{pNum}");
                Console.Write("Enter X coordinate\n> ");
                bool isCorrect1 = double.TryParse(Console.ReadLine(), out double x);
                Console.Write("Enter Y coordinate\n> ");
                bool isCorrect2 = double.TryParse(Console.ReadLine(), out double y);
                Console.WriteLine("----------------------------------------------");

                if (!isCorrect1 || !isCorrect2)
                {
                    Console.WriteLine("|Nice try.");
                    x = 0;
                    y = 0;
                    n++;
                    pNum--;
                }
                else
                {
                    double Dist = Math.Sqrt(x * x + y * y);
                    if (Dist >= r1 && Dist <= r2)
                    {
                        count++;
                    }
                }


                n--;
                pNum++;
            }
            // end

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here
            int studNum = 1;
            int markSum = 0, i = 0;

            while (i < n)
            {
                Console.WriteLine($"Student #{studNum}");
                Console.Write("Enter first mark\n> ");
                bool isCorrect1 = int.TryParse(Console.ReadLine(), out int firstMark);
                Console.Write("Enter second mark\n> ");
                bool isCorrect2 = int.TryParse(Console.ReadLine(), out int SecondMark);
                Console.Write("Enter third mark\n> ");
                bool isCorrect3 = int.TryParse(Console.ReadLine(), out int ThirdMark);
                Console.Write("Enter fourth mark\n> ");
                bool isCorrect4 = int.TryParse(Console.ReadLine(), out int FourthMark);
                Console.WriteLine("----------------------------------------------");
                if (!isCorrect1 || !isCorrect2 || !isCorrect3 || !isCorrect4)
                {
                    Console.WriteLine("|Nice try.");
                    firstMark = 0;
                    SecondMark = 0;
                    ThirdMark = 0;
                    FourthMark = 0;
                    i--;
                    studNum--;
                }
                else
                {
                    markSum = markSum + firstMark + SecondMark + ThirdMark + FourthMark;
                    if (firstMark <= 2 || SecondMark <= 2 || ThirdMark <= 2 || FourthMark <= 2)
                    {
                        count++;
                    }
                }


                i++;
                studNum++;
            }
            if (n > 0)
            {
                average = (double)markSum / (4 * n);
            }
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            int theory, practice, mark, n = exams;
            double score = 0;
            for (; exams > 0; exams--)
            {
                Console.Write("Enter theory score\n> ");
                theory = int.Parse(Console.ReadLine());
                Console.Write("Enter practice score\n> ");
                practice = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------------");
                score = 0.4 * theory + 0.6 * practice;
                switch (score)
                {
                    case > 85:
                        mark = 5;
                        break;
                    case > 70:
                        mark = 4;
                        break;
                    case > 50:
                        mark = 3;
                        break;
                    default:
                        mark = 2;
                        break;
                }

                avgMark += (double)mark / n;

            }
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;
            string codeStr = "";
            string codeNum = "";
            // code here

            do
            {
                Console.Write($"Enter digit #{codeStr.Length+1}\n> ");
                codeNum = Console.ReadLine();
                if (codeNum == "-1")
                {
                    solution = "Аварийный выход!";
                    attempts++;
                    break;
                }

                codeStr += codeNum;

                if (int.Parse(codeStr) == code)
                {
                    solution = "Доступ разрешен!";
                    attempts++;
                    break;
                }

                if (codeStr.Length >= 3)
                {
                    codeStr = "";
                    attempts++;
                }

                if (attempts >= limit)
                {
                    solution = "Система заблокирована!";
                    break;
                }
            } while (attempts < limit);
            // end

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here

            int stDay = a;
            int durDays = n;
            int i = 0;

            for (; a < stDay + durDays; a++, i++)
            {
                switch (a)
                {
                    case 1 or 8 or 15 or 22 or 29:
                        luck *= 1.5;
                        if (luck > 100) luck = 100;
                        break;
                    case 4 or 11 or 18 or 25:
                        luck -= 10;
                        if (luck < 0) luck = 0;
                        break;
                    case 7 or 14 or 21 or 28:
                        if (luck < 50) luck = 55;
                        break;
                    default:
                        luck += 5;
                        if (luck > 100) luck = 100;
                        break;
                }
            }

            // end

            return luck;
        }
    }
}