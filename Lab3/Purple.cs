using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;
            double x;
            double y;
    
            for (int i = 0; i < n; i++)
            {
                x = Double.Parse(Console.ReadLine());
                y = Double.Parse(Console.ReadLine());
                if ((x * x) + (y * y) <= r1 * r1)
                {
                    count++;
                    if ((x * x) + (y * y) <= r2 * r2)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;
            for (int i = 0; i < n; i++)
            {
                int uch1, uch2, uch3, uch4;
                uch1 = Int32.Parse(Console.ReadLine());
                uch2 = Int32.Parse(Console.ReadLine());
                uch3 = Int32.Parse(Console.ReadLine());
                uch4 = Int32.Parse(Console.ReadLine());
                average += (uch1 + uch2 + uch3 + uch4) / 4.0;
                if (uch1 == 2 || uch2 == 2 || uch3 == 2 || uch4 == 2)
                {
                    count++;
                }
            }
            average /= n;
            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;
            int theory, practice,mark,n = exams;
            double score = 0;
            while (exams > 0)
            {
                theory = Int32.Parse(Console.ReadLine());
                practice = Int32.Parse(Console.ReadLine());
                score = (0.4 * theory) + (0.6 * practice);
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
                avgMark += mark / n;
                exams--;
            }
            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            solution = "Система заблокирована!";
            int attempts = 0;
            for (int i = 0; i < limit; i++)
            {
                attempts++;
                int a, b, c;
                a = Int32.Parse(Console.ReadLine());
                if (a == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                b = Int32.Parse(Console.ReadLine());
                if (a == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                c = Int32.Parse(Console.ReadLine());
                if (a == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int codetry = a * 100 + b * 10 + c;
                if (code == codetry)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
                
                
            }
            
            

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;
            int k = a + n; 
            for (; a < k ; a++ )
                switch (a)
                {
                    case 1 or 8 or 15 or 22 or 29:
                    {
                        if (luck * 1.5 > 100)
                        {
                            luck = 100;
                        }
                        else
                        {
                            luck *= 1.5;
                        }
                        break;
                    }
                    case 4 or 11 or 18 or 25:
                    {
                        if (luck - 10 > 0)
                        {
                            luck -= 10;
                        }
                        else
                        {
                            luck = 0;
                        }

                        break;
                    }
                    case 7 or 14 or 21 or 28:
                    {
                        if (luck < 50)
                        {
                            luck = 55;
                        }

                        break;
                    }
                    default:
                    {
                        if (luck + 5 > 100)
                        {
                            luck = 100;
                        }
                        else
                        {
                            
                            luck += 5;
                        }
                        break;
                    }
                       
                }
            return luck;
        }
    }
}
