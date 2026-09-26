using System.Net;

namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;
            double v;

            while (n != 0)
            {
                v = double.Parse(Console.ReadLine());
                if (v < norma)
                {
                    milk += glass / 1000.0;
                }
                n--;
            }

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            while (n != 0)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0)
                {
                    first++;
                }
                if (x < 0 && y > 0)
                {
                    second++;
                }
                if (x < 0 && y < 0)
                {
                    third++;
                }
                if (x > 0 && y < 0)
                {
                    fourth++;
                }

                n--;
            }

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = n;

            while (n != 0)
            {
                int q = int.Parse(Console.ReadLine());
                int w = int.Parse(Console.ReadLine());
                int e = int.Parse(Console.ReadLine());
                int r = int.Parse(Console.ReadLine());
                if (q == 2 || w == 2 || e == 2 || r == 2 || q == 3 || w == 3 || e == 3 || r == 3)
                {
                    count--;
                }
                n--;
            }

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {

            int taskTime = 10;
            int serias = 0;

            while (time < 1440)
            {
                if (tasks > 0)
                {
                    time += taskTime;
                    taskTime += 5;
                    tasks--;
                }
                else
                {
                    int seriasTime = int.Parse(Console.ReadLine());
                    time += seriasTime;
                    serias++;
                }
            }


            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {
            if (number == 1) { power += 10; intellect -= 5; }
            if (number == 2) { power -= 5; agility += 5; intellect -= 5;}
            if (number == 3) { power += 10; intellect -= 5;}
            if (number == 4) { power -= 10; intellect -= 10; agility += 15;}
            if (number == 5) { power -= 5; intellect += 7;}


            if (power < 0) power = 0;
            if (agility < 0) agility = 0;
            if (intellect < 0) intellect = 0;

            return (power, agility, intellect);
        }
    }
}
