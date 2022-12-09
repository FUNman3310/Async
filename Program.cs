

namespace Async
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread1 = new Thread(Loop1);
            //Thread thread2 = new Thread(Loop2);
            //thread1.Start();
            //thread1.Join();
            //thread2.Start();


            //static void Loop1()
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Thread.Sleep(7000);
            //        Console.Write("A");
            //    }
            //}

            //static void Loop2()
            //{
            //    for (int i = 0; i < 100; i++)
            //    {
            //        Thread.Sleep(1000);
            //        Console.Write("B");
            //    }
            //}


            Program program = new Program();
            //program.Incrementor();
            //program.Decrementor();

            Thread thread1 = new Thread(program.Incrementor);
            Thread thread2 = new Thread(program.Decrementor);
            Console.WriteLine(program.Counter);

            thread1.Start();
            thread1.Join();
            thread2.Start();
            thread2.Join();
        }

        public int Counter { get;  set; }
        private object LockObj1 = new object();
        private object LockObj2 = new object();

        void Incrementor()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (LockObj1)
                {
                    lock (LockObj2) 
                    {
                        Counter++;

                    }

                }
            }
        }
        void Decrementor()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (LockObj2)
                {
                    lock (LockObj1)
                    {
                        Counter--;

                    }
                }
                
            }
        }



    }
}
