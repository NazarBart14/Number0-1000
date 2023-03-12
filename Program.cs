namespace Number0_1000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 2;
            int end = 1000;
            var task = Task.Run(() =>
            {
                int count = 0;
                for (int i = start; i <= end; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        count++;
                    }
                }
                return count;
            });
            int primeCount = task.Result;
            Console.WriteLine("Кількість простих чисел між {0} і {1}: {2}", start, end, primeCount);
            task.Wait();
        }
    }
}