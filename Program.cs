namespace _20261109_LinqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DemoFirst();

            List<double> src = new List<double> { 12.3, 98.4, 100.246, -7, 10.2 };

            double left = -5.5;
            double right = 15.2;

            var res1 = src.Where(n => n > left && n < right);

            Console.WriteLine("res1: ");
            foreach (var item in res1)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            // query mode
            var res2 = (from n in src
                        where n > left && n < right
                        select n)/*.ToList()*/;

            Console.WriteLine("res2: ");
            foreach (var item in res2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            src.Add(0.25);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("res2: ");
            foreach (var item in res2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            var res3 = src
                    .Where(n => n > 10.0)
                    .OrderByDescending(n => n);

            Console.WriteLine("res3: ");
            foreach (var item in res3)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            var res4 = from n in src
                       where n > 10.0
                       orderby n descending
                       select n;

            Console.WriteLine("res4: ");
            foreach (var item in res4)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var numberGroups = from n in numbers
            //                   group n by n % 5 into g
            //                   select (Remainder: g.Key, Numbers: g);

            var numberGroups = numbers
                    .GroupBy(n => n % 5)
                    .Select(n => new { Remainder =  n.Key, Numbers = n });


            foreach (var g in numberGroups)
            {
                Console.WriteLine($"Numbers with a remainder of {g.Remainder} when divided by 5:");
                foreach (var n in g.Numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }

        private static void DemoFirst()
        {
            var k = 12.3;
            double k2 = 12.3;

            var student1 = new
            {
                Name = "TestUser",
                Age = 20,
                Score = 90
            };

            Console.WriteLine($"k = {k}");
            Console.WriteLine($"k2 = {k2}");
            Console.WriteLine($"student1 = {student1.Name}, {student1.Age}, {student1.Score}");

            //Array.ForEach(new int[] { 1, 2, 3, 4, 5 }, n => Console.WriteLine(n));

            int[] source = { 1, 2, 3, 4, 5 };
            //Array.ForEach(source, n => Console.WriteLine(n));

            Console.WriteLine();
            //Array.ForEach(source, Print);

            //Array.ForEach(source, delegate(int n)
            //    {
            //        Console.WriteLine($"{n} ");
            //    });

            //Array.ForEach(source, (int n) =>
            //{
            //    Console.WriteLine($"{n} ");
            //});

            //Array.ForEach(source, (n) => Console.WriteLine($"{n} "));

            Array.ForEach(source, n => Console.WriteLine($"{n} "));

            int data = 12;

            int p = Utility.Sqr(data);

            int p2 = Utility.Sqr(Utility.Sqr(data));

            int res4 = 255.Sqr();

            int res5 = data.Sqr();

            Console.WriteLine($"res5 = {res5}");

            int res6 = data.Sqr().Sqr();

            Console.WriteLine($"res6 = {res6}");

            IEnumerable<int> source2 = source.MakeDouble();

            Console.WriteLine("source2: ");
            foreach (var item in source2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var firstNumbersLessThan6 = numbers.TakeWhile(n => n < 6);

            Console.WriteLine("First numbers less than 6:");
            foreach (var num in firstNumbersLessThan6)
            {
                Console.WriteLine(num);
            }
        }

        public static void Print(int n)
        {
            Console.WriteLine($"{n} ");
        }
    }
}
