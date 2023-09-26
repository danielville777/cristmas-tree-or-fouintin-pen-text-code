namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool o= false;
            int inc = 0;
            int incc = 0;
            int inccc = 0;
            Console.WriteLine("input text");
            string test = Console.ReadLine();
            Console.WriteLine("input iterations");
            int gorounds = int.Parse(Console.ReadLine());
            Console.WriteLine("input speed (100 is good)");
            int speed = int.Parse(Console.ReadLine());
            while (inc!=gorounds)
            {
                Console.WriteLine(test);
                if (incc < 10) {
                    while (incc > inccc) {
                        Console.Write(test);
                        inccc++;
                    }  inccc = 0; }
               
                
                if (incc > 10)
                {inccc = 10;
                    while (inccc>incc-10)
                    {
                        Console.Write(test);
                        inccc=inccc-1;
                    }
                    inccc = 0;
                }
                incc++;
                inc++;
                Thread.Sleep(speed);
                if (incc > 20) { incc = 0; }

            }
        }
    }
}