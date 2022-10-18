namespace ConditionTasks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Conditions7();
        }

        private static void Conditions1()
        {
            Console.WriteLine("User gives 2 numbers a and b. If a>b then output a+b, if a=b then output a*b, if a<b then a-b.");

            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine(a + b);
            else if (a == b)
                Console.WriteLine(a * b);
            else if (a < b)
                Console.WriteLine(a - b);
        }

        private static void Conditions2()
        {
            Console.WriteLine("User gives 2 numbers x and y. Find out coordinate quarter of point with location (x,y).");

            Console.Write("x =  ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("y =  ");
            double y = Convert.ToDouble(Console.ReadLine());

            if (x > 0 && y > 0)
                Console.WriteLine("I quarter");
            else if (x < 0 && y > 0)
                Console.WriteLine("II quarter");
            else if (x < 0 && y < 0)
                Console.WriteLine("III quarter");
            else if (x > 0 && y < 0)
                Console.WriteLine("IV quarter ");
            else if (x == 0 || y == 0)
                Console.WriteLine("The point is the origin or lies on one of the x or y axes");

            Console.ReadLine();
        }

        private static void Conditions3()
        {
            Console.WriteLine("User gives 3 numbers a, b, c. Output them in the ascending order.");

            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a <= b && a <= c && b <= c)
                Console.WriteLine(a + " " + b + " " + c);
            else if (a <= b && a <= c && c <= b)
                Console.WriteLine(a + " " + c + " " + b);
            else if (b <= a && b <= c && a <= c)
                Console.WriteLine(b + " " + a + " " + c);
            else if (b <= a && b <= c && c <= a)
                Console.WriteLine(b + " " + c + " " + a);
            else if (c <= a && c <= b && a <= b)
                Console.WriteLine(c + " " + a + " " + b);
            else if (c <= a && c <= b && b <= a)
                Console.WriteLine(c + " " + b + " " + a);
        }

        private static void Conditions4()
        {
            Console.WriteLine("User gives 3 numbers a, b, c. Find out solution of quadratic equation ax^2+bx+c=0. ");

            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            double D = b * b - 4 * a * c;

            if (D < 0)
            {
                Console.WriteLine("D < 0");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                double x2 = (-b - Math.Sqrt(D)) / 2 * a;

                Console.WriteLine(x1);
                Console.WriteLine(x2);
            }
        }

        private static void Conditions5()
        {
            Console.WriteLine("User gives 2-digit number. Output the world according to this number. F.e. : 13 – thirteen.");

            string[] digits = new string[] {
            " ", "one", "two",   "three", "four",
            "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve","thirteen",
            "fourteen", "fifteen", "sixteen",
            "seventeen", "eighteen", "nineteen"
            };

            string[] tensMultiple = new string[] {
            "", "", "twenty", "thirty", "forty",
            "fifty", "sixty", "seventy", "eighty", "ninety"
            };

            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 10 || number > 99)
            {
                Console.WriteLine("two digit number only!");
                Conditions5();
            }
            else if (number < 20)
            {
                Console.WriteLine(digits[number]);
            }
            else if (number >= 20)
            {
                Console.WriteLine(tensMultiple[number / 10] + " " + digits[number % 10]);
            }
        }

        private static void Conditions6()
        {
            Console.WriteLine("User gives 3 numbers x, y, r. Find out if point with location (x,y) is inside the circle with radius r.");

            Console.Write("x = ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("y = ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("r = ");
            int r = Convert.ToInt32(Console.ReadLine());

            double hypo = Math.Sqrt(x * x + y * y);

            if (hypo < r)
            {
                Console.WriteLine("Inside");
            }
            else if (hypo == r)
            {
                Console.WriteLine("On the circle");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }

        private static void Conditions7()
        {
            Console.WriteLine(" A program with 4 different options: ");
            Console.WriteLine("   1. Take a 3-digit number as input, and say if square of this number equals sum of all it’s digits to the power of 3.");
            Console.WriteLine("   2. Take a 4-digit number and say if sum of first two digits equals sum of last 2 digits.");
            Console.WriteLine("   3. Take a 3-digit number as input. Say if there any 2 similar digits in it. ");
            Console.WriteLine("   4. Take a float number. Say if first 3 digits after comma contains 0. ");

            Console.Write(" Choose an option: ");
            int x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Conditions_7A();
                    break;
                case 2:
                    Conditions_7B();
                    break;
                case 3:
                    Conditions_7C();
                    break;
                case 4:
                    Conditions_7D();
                    break;
                default:
                    Conditions7();
                    break;
            }
        }

        private static void Conditions_7A()
        {
            // 1. Take a 3-digit number as input, and say if square of this number equals sum of all it’s digits to the power of 3.

            Console.Write(" Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("three digit number only!");
                Conditions_7A();
            }
            else
            {
                int a = number / 100;
                int b = number / 10 % 10;
                int c = number % 10;
                int sum = a + b + c;

                if (number * number == sum * sum * sum)
                {
                    Console.WriteLine(" Yes");
                }
                else
                {
                    Console.WriteLine(" No");
                }
            }
        }

        private static void Conditions_7B()
        {
            // 2. Take a 4-digit number and say if sum of first two digits equals sum of last 2 digits.

            Console.Write(" Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 1000 || number > 9999)
            {
                Console.WriteLine("four digit number only!");
                Conditions_7B();
            }
            else
            {
                int a = number / 1000;
                int b = number / 100 % 10;
                int c = number / 10 % 10;
                int d = number % 10;

                if (a + b == c + d)
                {
                    Console.WriteLine(" Yes");
                }
                else
                {
                    Console.WriteLine(" No");
                }
            }
        }

        private static void Conditions_7C()
        {
            // 3. Take a 3-digit number as input. Say if there any 2 similar digits in it.

            Console.Write(" Input number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 100 || number > 999)
            {
                Console.WriteLine("three digit number only!");
                Conditions_7C();
            }
            else
            {
                int a = number / 100;
                int b = number / 10 % 10;
                int c = number % 10;

                if (a == b || a == c || c == b)
                {
                    Console.WriteLine(" Yes");
                }
                else
                {
                    Console.WriteLine(" No");
                }
            }
        }

        // есть ли более хорошее решение?
        private static void Conditions_7D()
        {
            // 4. Take a float number. Say if first 3 digits after comma contains 0.

            Console.Write(" Input float number: ");
            float number = float.Parse(Console.ReadLine());

            number = (number - Convert.ToInt32(number)) * 1000;

            int n = Convert.ToInt32(number);

            int a = n / 100;
            int b = n / 10 % 10;
            int c = n % 10;

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine(" Yes");
            }
            else
            {
                Console.WriteLine(" No");
            }

        }
    }
}