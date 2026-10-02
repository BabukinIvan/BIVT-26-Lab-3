namespace Lab3
{
    public class Blue
    {
        public double Task1(int n, int glass, int norma)
        {
            double milk = 0;

            // code here
            double moloko = 0;
            for (int i = 0; i < n; i++)
            {

                double ves = double.Parse(Console.ReadLine());
                if (ves < norma)
                {
                    moloko += glass;
                }
            }
            milk = moloko / 1000;
            // end

            return milk;
        }
        public (int first, int second, int third, int fourth) Task2(int n)
        {
            int first = 0, second = 0, third = 0, fourth = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                if (x > 0 && y > 0) first++;
                else if (x < 0 && y > 0) second++;
                else if (x < 0 && y < 0) third++;
                else if (x > 0 && y < 0) fourth++;
            }
            // end

            return (first, second, third, fourth);
        }
        public int Task3(int n)
        {
            int count = 0;

            // code here
            for (int i = 0; i < n; i++)
            {
                int perv = int.Parse(Console.ReadLine());
                int vtor = int.Parse(Console.ReadLine());
                int trit = int.Parse(Console.ReadLine());
                int four = int.Parse(Console.ReadLine());
                if (perv != 2 && perv != 3 && vtor != 2 && vtor != 3 && trit != 2 && trit != 3 && four != 2 && four != 3) count += 1;
            }
            // end

            return count;
        }
        public (int tasks, int serias) Task4(int time, int tasks)
        {
            int serias = 0;

            // code here
            serias = 10;
            int taskTime = 10;
            serias = 0;
            while(true)
            {
                if (time < 1440)
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
                else break;
            }
            // end

            return (tasks, serias);
        }
        public (int power, int agility, int intellect) Task5(int power, int agility, int intellect, int number)
        {

            // code here
            if (number == 1 || number == 3)
            {
                power += 10;
                if (intellect - 5 < 0) intellect = 0;
                else intellect -= 5;
            }
            if (number == 2 || number == 5)
            {
                if (number == 2)
                {
                    agility += 5;
                    if (intellect - 5 < 0) intellect = 0;
                    else intellect -= 5;
                }
                else intellect += 7;
                if (power - 5 < 0) power = 0;
                else power -= 5;
            }
            if (number == 4)
            {
                agility += 15;
                if (power - 10 < 0) power = 0;
                else power -= 10;
                if (intellect - 10 < 0) intellect = 0;
                else intellect -= 10;
            }
            // end

            return (power, agility, intellect);
        }
    }
}