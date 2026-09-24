using System.Globalization;

namespace Lab3
{
    public class Program
    {
        public static void Main()
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Console.WriteLine("\nTest white league\n");
            // TestWhite();
            // Console.WriteLine("\nTest green league\n");
            // TestGreen();
            // Console.WriteLine("\nTest blue league\n");
            // TestBlue();
            Console.WriteLine("\nTest purple league\n");
            TestPurple();
        }
        private static void TestWhite()
        {
            // var white = new White();
            // Console.WriteLine($"Task1 test 1 {white.Task1(0) == 0}");
            // Console.WriteLine($"Task1 test 2. Paste 1 inputs");
            // Console.WriteLine($"Task1 test 2 {white.Task1(1) == 168}");
            // Console.WriteLine($"Task1 test 3. Paste 2 inputs");
            // Console.WriteLine($"Task1 test 3 {white.Task1(2) == 157.5}");
            // Console.WriteLine($"Task1 test 4. Paste 5 inputs");
            // Console.WriteLine($"Task1 test 4 {white.Task1(5) == 164.6}");
            // Console.WriteLine($"Task1 test 5. Paste 10 inputs");
            // Console.WriteLine($"Task1 test 5 {white.Task1(10) == 163.4}");
            
            // Console.WriteLine($"Task2 test 1 {white.Task2(0) == 0}");
            // Console.WriteLine($"Task2 test 2. Paste 1 inputs");
            // Console.WriteLine($"Task2 test 2 {white.Task2(1) == 15.8}");
            // Console.WriteLine($"Task2 test 3. Paste 2 inputs");
            // Console.WriteLine($"Task2 test 3 {white.Task2(2) == 14.2}");
            // Console.WriteLine($"Task2 test 4. Paste 5 inputs");
            // Console.WriteLine($"Task2 test 4 {white.Task2(5) == 14.2}");
            // Console.WriteLine($"Task2 test 5. Paste 10 inputs");
            // Console.WriteLine($"Task2 test 5 {white.Task2(10) == 14.0}");
            
            // Console.WriteLine($"Task3 test 1 {white.Task3(0, 15.1) == 0}");
            // Console.WriteLine($"Task3 test 2. Paste 2 inputs");
            // Console.WriteLine($"Task3 test 2 {white.Task3(2, 15.1) == 1}");
            // Console.WriteLine($"Task3 test 3. Paste 5 inputs");
            // Console.WriteLine($"Task3 test 3 {white.Task3(5, 15.1) == 3}");
            // Console.WriteLine($"Task3 test 4. Paste 10 inputs");
            // Console.WriteLine($"Task3 test 4 {white.Task3(10, 15.1) == 7}");
            // Console.WriteLine($"Task3 test 5. Paste 10 inputs");
            // Console.WriteLine($"Task3 test 5 {white.Task3(10, 14.5) == 5}");
            
            // Console.WriteLine($"Task4 test 1. Paste 7");
            // Console.WriteLine($"Task4 test 1 {white.Task4(0) == 0}");
            // Console.WriteLine($"Task4 test 2. Paste 7");
            // Console.WriteLine($"Task4 test 2 {white.Task4(5) == 0}");
            // Console.WriteLine($"Task4 test 3. Paste 7");
            // Console.WriteLine($"Task4 test 3 {white.Task4(10) == 3}");
            // Console.WriteLine($"Task4 test 4. Paste 7");
            // Console.WriteLine($"Task4 test 4 {white.Task4(20) == 28}");
            // Console.WriteLine($"Task4 test 5. Paste 7");
            // Console.WriteLine($"Task4 test 5 {white.Task4(50) == 103}");
        }
        private static void TestGreen()
        {
            // var green = new Green();
            // Console.WriteLine($"Task1 test 1 {green.Task1(1, 2, 2, 0) == 0}");
            // Console.WriteLine($"Task1 test 2. Paste 4 inputs");
            // Console.WriteLine($"Task1 test 2 {green.Task1(1, 1, 2, 2) == 2}");
            // Console.WriteLine($"Task1 test 3. Paste 10 inputs");
            // Console.WriteLine($"Task1 test 3 {green.Task1(1, 1, 2, 5) == 4}");
            // Console.WriteLine($"Task1 test 4. Paste 20 inputs");
            // Console.WriteLine($"Task1 test 4 {green.Task1(1, 2, 1, 10) == 1}");
            // Console.WriteLine($"Task1 test 5. Paste 20 inputs");
            // Console.WriteLine($"Task1 test 5 {green.Task1(0, 1, 1, 10) == 6}");

            // Console.WriteLine($"Task2 test 1 {green.Task2(0) == (0, 0)}");
            // Console.WriteLine($"Task2 test 2. Paste 2 inputs");
            // Console.WriteLine($"Task2 test 2 {green.Task2(1) == (1, 2.080865204668481)}");
            // Console.WriteLine($"Task2 test 3. Paste 4 inputs");
            // Console.WriteLine($"Task2 test 3 {green.Task2(2) == (1, 2.080865204668481)}");
            // Console.WriteLine($"Task2 test 4. Paste 10 inputs");
            // Console.WriteLine($"Task2 test 4 {green.Task2(5) == (5, 0.7071067811865476)}");
            // Console.WriteLine($"Task2 test 5. Paste 20 inputs");
            // Console.WriteLine($"Task2 test 5 {green.Task2(10) == (10, 0.5099019513592785)}");

            // Console.WriteLine($"Task3 test 1. Insert input until the task completes (first set)");
            // Console.WriteLine($"Task3 test 1 {green.Task3() == 2}");
            // Console.WriteLine($"Task3 test 2. Insert input until the task completes (second set)");
            // Console.WriteLine($"Task3 test 2 {green.Task3() == 2}");
            
            // Console.WriteLine($"Task4 test 1 {green.Task4(0, 0) == 0}");
            // Console.WriteLine($"Task4 test 2. Paste 5 inputs");
            // Console.WriteLine($"Task4 test 2 {green.Task4(5, 0) == 16}");
            // Console.WriteLine($"Task4 test 3. Paste 5 inputs");
            // Console.WriteLine($"Task4 test 3 {green.Task4(0, 5) == 64}");
            // Console.WriteLine($"Task4 test 4. Paste 10 inputs");
            // Console.WriteLine($"Task4 test 4 {green.Task4(5, 5) == 84}");
            // Console.WriteLine($"Task4 test 5. Paste 12 inputs");
            // Console.WriteLine($"Task4 test 5 {green.Task4(10, 2) == 61}");
        }
        private static void TestBlue()
        {
            // var blue = new Blue();
            // Console.WriteLine($"Task1 test 1 {blue.Task1(0, 200, 30) == 0}");
            // Console.WriteLine($"Task1 test 2. Paste 5 inputs");
            // Console.WriteLine($"Task1 test 2 {blue.Task1(5, 200, 30) == 0.6}");
            // Console.WriteLine($"Task1 test 3. Paste 5 inputs");
            // Console.WriteLine($"Task1 test 3 {blue.Task1(5, 250, 30) == 0.75}");
            // Console.WriteLine($"Task1 test 4. Paste 10 inputs");
            // Console.WriteLine($"Task1 test 4 {blue.Task1(10, 200, 30) == 1.2}");
            // Console.WriteLine($"Task1 test 5. Paste 10 inputs");
            // Console.WriteLine($"Task1 test 5 {blue.Task1(10, 200, 25) == 0.4}");

            // Console.WriteLine($"Task2 test 1 {blue.Task2(0) == (0, 0, 0, 0)}");
            // Console.WriteLine($"Task2 test 2. Paste 2 inputs");
            // Console.WriteLine($"Task2 test 2 {blue.Task2(1) == (1, 0, 0, 0)}");
            // Console.WriteLine($"Task2 test 3. Paste 4 inputs");
            // Console.WriteLine($"Task2 test 3 {blue.Task2(2) == (1, 0, 0, 0)}");
            // Console.WriteLine($"Task2 test 4. Paste 10 inputs");
            // Console.WriteLine($"Task2 test 4 {blue.Task2(5) == (1, 1, 1, 0)}");
            // Console.WriteLine($"Task2 test 5. Paste 20 inputs");
            // Console.WriteLine($"Task2 test 5 {blue.Task2(10) == (4, 2, 1, 0)}");

            // Console.WriteLine($"Task3 test 1 {blue.Task3(0) == 0}");
            // Console.WriteLine($"Task3 test 2. Paste 4 inputs");
            // Console.WriteLine($"Task3 test 2 {blue.Task3(1) == 0}");
            // Console.WriteLine($"Task3 test 3. Paste 8 inputs");
            // Console.WriteLine($"Task3 test 3 {blue.Task3(2) == 1}");
            // Console.WriteLine($"Task3 test 4. Paste 20 inputs");
            // Console.WriteLine($"Task3 test 4 {blue.Task3(5) == 3}");
            // Console.WriteLine($"Task3 test 5. Paste 40 inputs");
            // Console.WriteLine($"Task3 test 5 {blue.Task3(10) == 4}");

            // Console.WriteLine($"Task4 test 1. Insert input until the task completes");
            // Console.WriteLine($"Task4 test 1 {blue.Task4(0, 0) == (0, 12)}");
            // Console.WriteLine($"Task4 test 2. Insert input until the task completes");
            // Console.WriteLine($"Task4 test 2 {blue.Task4(700, 0) == (0, 7)}");
            // Console.WriteLine($"Task4 test 3. Insert input until the task completes");
            // Console.WriteLine($"Task4 test 3 {blue.Task4(0, 22) == (0, 1)}");
            // Console.WriteLine($"Task4 test 4. Insert input until the task completes");
            // Console.WriteLine($"Task4 test 4 {blue.Task4(100, 10) == (0, 9)}");
            // Console.WriteLine($"Task4 test 5. Insert input until the task completes");
            // Console.WriteLine($"Task4 test 5 {blue.Task4(0, 35) == (12, 0)}");
        }
        private static void TestPurple()
        {
            var purple = new Purple();
            Console.WriteLine($"Task1 test 1 {purple.Task1(0, 0, 0) == 0}");
            Console.WriteLine($"Task1 test 2. Paste 10 inputs");
            Console.WriteLine($"Task1 test 2 {purple.Task1(5, 0, 3) == 5}");
            Console.WriteLine($"Task1 test 3. Paste 10 inputs");
            Console.WriteLine($"Task1 test 3 {purple.Task1(5, 1, 3) == 4}");
            Console.WriteLine($"Task1 test 4. Paste 20 inputs");
            Console.WriteLine($"Task1 test 4 {purple.Task1(10, 2, 3) == 3}");
            Console.WriteLine($"Task1 test 5. Paste 20 inputs");
            Console.WriteLine($"Task1 test 5 {purple.Task1(10, 1, 5) == 8}");

            Console.WriteLine($"Task2 test 1 {purple.Task2(0) == (0, 0)}");
            Console.WriteLine($"Task2 test 2. Paste 4 inputs");
            Console.WriteLine($"Task2 test 2 {purple.Task2(1) == (1, 2.75)}");
            Console.WriteLine($"Task2 test 3. Paste 8 inputs");
            Console.WriteLine($"Task2 test 3 {purple.Task2(2) == (1, 3.75)}");
            Console.WriteLine($"Task2 test 4. Paste 20 inputs");
            Console.WriteLine($"Task2 test 4 {purple.Task2(5) == (2, 4.05)}");
            Console.WriteLine($"Task2 test 5. Paste 40 inputs");
            Console.WriteLine($"Task2 test 5 {purple.Task2(10) == (3, 3.925)}");

            Console.WriteLine($"Task3 test 1 {purple.Task3(0) == 0}");
            Console.WriteLine($"Task3 test 2. Paste 2 inputs");
            Console.WriteLine($"Task3 test 2 {purple.Task3(1) == 3}");
            Console.WriteLine($"Task3 test 3. Paste 4 inputs");
            Console.WriteLine($"Task3 test 3 {purple.Task3(2) == 3.5}");
            Console.WriteLine($"Task3 test 4. Paste 6 inputs");
            Console.WriteLine($"Task3 test 4 {Math.Abs(purple.Task3(3) - 3.3333) <= 0.0001}");
            Console.WriteLine($"Task3 test 5. Paste 10 inputs");
            Console.WriteLine($"Task3 test 5 {purple.Task3(5) == 3.6}");

            Console.WriteLine($"Task4 test 1. Insert input until the task completes");
            Console.WriteLine($"Task4 test 1 {purple.Task4(000, 1) == ("Система заблокирована!", 1)}");
            Console.WriteLine($"Task4 test 2. Insert input until the task completes");
            Console.WriteLine($"Task4 test 2 {purple.Task4(000, 5) == ("Аварийный выход!", 4)}");
            Console.WriteLine($"Task4 test 3. Insert input until the task completes");
            Console.WriteLine($"Task4 test 3 {purple.Task4(123, 3) == ("Доступ разрешен!", 2)}");
            Console.WriteLine($"Task4 test 4. Insert input until the task completes");
            Console.WriteLine($"Task4 test 4 {purple.Task4(283, 3) == ("Доступ разрешен!", 3)}");
            Console.WriteLine($"Task4 test 5. Insert input until the task completes");
            Console.WriteLine($"Task4 test 5 {purple.Task4(283, 2) == ("Система заблокирована!", 2)}");
        }
    }
}
