using System;
using System.Threading;

class bai80
{
    static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(ff);
        Thread thread = new Thread(threadStart);
        thread.Start();
        thread.Join();
        Console.WriteLine("Đã thực hiện xong");
    }

    static void ff()
    {
        Random random = new Random();
        while (true)
        {
            int n = random.Next();
            if (n % 2025 == 0)
            {
                break;
            }
            Console.WriteLine(n);
            Thread.Sleep(100);
        }
    }
}
