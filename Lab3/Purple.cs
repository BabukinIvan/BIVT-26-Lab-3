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
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double d = Math.Sqrt(x * x + y * y);
                if (d >= r1 && d <= r2)
                {
                    count++;
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
            int s = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                int d = int.Parse(Console.ReadLine());

                s += a + b + c + d;
                if (a == 2 || b == 2 || c == 2 || d == 2)
                {
                    count++;
                }
            }
            if (n > 0)
            {
                average = (double)s / (n * 4);
            }
            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here
            for (int i = 0; i < exams; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                double x = a * 0.4 + b * 0.6;
                if (x > 85)
                    avgMark += 5;
                else if (x > 70)
                    avgMark += 4;
                else if (x > 50)
                    avgMark += 3;
                else
                    avgMark += 2;
            }
            if (exams > 0)
                avgMark /= exams;
            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            // code here
            for (int i = 0; i < limit; i++)
            {
                attempts++;
                int x = int.Parse(Console.ReadLine());
                if (x == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int y = int.Parse(Console.ReadLine());
                if (y == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int z = int.Parse(Console.ReadLine());
                if (z == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
                int a = x * 100 + y * 10 + z;
                if (a == code)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }
            if (solution == "Код не подобран")
            {
                solution = "Система заблокирована!";
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
                    case 1:
                    case 8:
                    case 15:
                    case 22:
                    case 29:
                        luck *= 1.5;
                        if (luck > 100)
                            luck = 100;
                        break;
                    case 4:
                    case 11:
                    case 18:
                    case 25:
                        luck -= 10;
                        if (luck < 0)
                            luck = 0;
                        break;
                    case 7:
                    case 14:
                    case 21:
                    case 28:
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