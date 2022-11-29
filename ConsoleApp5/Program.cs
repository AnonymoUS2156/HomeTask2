using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            const int mil = 1_000_000;
            List<int> list = new List<int>(mil);
            ArrayList arrayList = new ArrayList(mil);
            LinkedList<int> ints = new LinkedList<int>();
            stopwatch.Start();
            for (int i = 0; i < mil; i++)
            {
                list.Add(i + 1);
            }
            Console.WriteLine($"Input List = {stopwatch.Elapsed.Milliseconds} ms");
            stopwatch.Stop();
            stopwatch.Restart();

            for (int i = 0; i < mil; i++)
            {
                arrayList.Add(i + 1);
            }
            Console.WriteLine($"Input ArrayList = {stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Stop();
            stopwatch.Restart();

            for (int i = 0; i < mil; i++)
            {
                ints.AddLast(i + 1);
            }

            stopwatch.Stop();
            Console.WriteLine($"Input LinkedList = {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            list.Find(x => x == 496753);
            stopwatch.Stop();
            Console.WriteLine($"element of 496753 in List finds for {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            arrayList.LastIndexOf(496753);
            stopwatch.Stop();
            Console.WriteLine($"element of 496753 in ArrayList finds for {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            ints.Find(496753);
            stopwatch.Stop();
            Console.WriteLine($"element of 496753 in LinkedList finds for {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Start();

            for (int i = 777; i < mil; i += 777)
            {

                stopwatch.Stop();
                Console.WriteLine($"time of every 777-th element in List ={stopwatch.ElapsedMilliseconds} ms of {list[i - 1]}");
                stopwatch.Start();
            }

            stopwatch.Restart();

            for (int i = 777; i < mil; i += 777)
            {

                stopwatch.Stop();
                Console.WriteLine($"time of every 777-th element in ArrayList ={stopwatch.ElapsedMilliseconds} ms of {arrayList[i - 1]}");
                stopwatch.Start();
            }

            stopwatch.Restart();

            var b = ints.First;
            for (int i = 0; i < mil; i++)
            {
                if (b.Value % 777 == 0)
                {
                    stopwatch.Stop();
                    Console.WriteLine($"time of every 777-th element in LinkedList ={stopwatch.ElapsedMilliseconds} ms of {b.Value}");
                    stopwatch.Start();
                }
                b = b.Next;
            }
            stopwatch.Stop();
        }
    }
}