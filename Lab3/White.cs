using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            int sum = 0;
            for (int i = 0; i <= n; i ++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            averageHeight = (double)sum / n;
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            double a = 100000.0;
            for (int i = 0; i < n; i++)
            {
                a = Math.Min(a, double.Parse(Console.ReadLine()));
            }
            bestResult = a;
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            for (int i = 0; i <= n; i ++)
            {
                if (double.Parse(Console.ReadLine()) <= limit) count += 1;
            }
            // end

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
            int amount = int.Parse(Console.ReadLine());
            while (true) 
            {
                if (amount < maxAmount)
                {
                    if (hours % 5 != 4) amount += 1;
                    else amount -= 2;
                    hours++;
                }
                else break;
            }
                // end

             return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here
            if (type == 1)
            {
                area = Math.Pow(r, 2);
            }
            else if (type == 2)
            {
                area = 3.14 * Math.Pow(r, 2);
            }
            else if (type == 3)
            {
                area = Math.Pow(3, 0.5) / 2 * r;
            }
            // end

            return area;
        }
    }
}