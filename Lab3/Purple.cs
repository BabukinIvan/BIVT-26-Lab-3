using System.Net.Http.Headers;

namespace Lab3
{
    public class Purple
    {
        public int Task1(int n, int r1, int r2)
        {
            int count = 0;
        int count = 0;
    
        n = abe;
    
        return count;

            return count;
        }
        public (int count, double average) Task2(int n)
        {
            int count = 0;
            double average = 0;

            // code here

            // end

            return (count, average);
        }
        public double Task3(int exams)
        {
            double avgMark = 0;

            // code here

            // end

            return avgMark;
        }
        public (string solution, int attempts) Task4(int code, int limit)
        {
            string solution = "Код не подобран";
            int attempts = 0;

            int c1 = code / 100;
            int c2 = code / 10 % 10;
            int c3 = code % 10;
            while (attempts < limit)
            {
                attempts += 1;
                int a1 = int.Parse(Console.ReadLine());
                if (a1 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
            
                int a2 = int.Parse(Console.ReadLine());
                if (a2 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
            
                int a3 = int.Parse(Console.ReadLine());
                if (a3 == -1)
                {
                    solution = "Аварийный выход!";
                    break;
                }
            
                if (a1 == c1 && a2 == c2 && a3 == c3)
                {
                    solution = "Доступ разрешен!";
                    break;
                }
            }
            if (solution == "Код не подобран") solution = "Система заблокирвоана!";

            return (solution, attempts);
        }
        public double Task5(int a, int n)
        {
            double luck = 0;

            // code here

            // end

            return luck;
        }
    }
}
