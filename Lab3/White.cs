using System.Security.Cryptography.X509Certificates;

namespace Lab3
{
    public class White
    {
        public double Task1(int n)
        {
            double averageHeight = 0;

            // code here
            double s = 0;
            double h = 0;
            for (int i=0; i<n; i++)
            {
                double.TryParse(Console.ReadLine(), out h);
                s = s + h;
            }
            averageHeight = s / n;
            // end

            return averageHeight;
        }
        public double Task2(int n)
        {
            double bestResult = 0;

            // code here
            double r = 0;
            for (int i=0; i<n; i++)
            {
                double.TryParse(Console.ReadLine(), out r);
                if (i == 0)
                {
                    bestResult = r;
                }
                if (r < bestResult)
                {
                    bestResult = r;
                }
            }
            
            // end

            return bestResult;
        }
        public int Task3(int n, double limit)
        {
            int count = 0;

            // code here
            double r = 0;
            for (int i =0; i<n; i++)
            {
                double.TryParse(Console.ReadLine(), out r);
                if (r <= limit)
                {
                    count++;
                }
            }
            // end

            return count;
        }
        public int Task4(int maxAmount)
        {
            int hours = 0;

            // code here
            int amount = 0;
            int.TryParse(Console.ReadLine(), out amount);
            while (amount < maxAmount)
            {
                if (hours % 5 != 4)
                {
                    amount += 1;
                }
                else
                {
                    amount -= 2;
                }
                hours++;
               
            }

            // end

            return hours;
        }
        public double Task5(int r, int type)
        {
            double area = 0;

            // code here
            switch (type)
            {
                case 1:
                    area = r * r;
                    break;
                    case 2:
                    area = r * r * Math.PI;
                    break;
                    case 3:
                    area = Math.Sqrt(3) / 4 * r * r;
                    break;
            }


            // end

            return area;
        }
    }
}