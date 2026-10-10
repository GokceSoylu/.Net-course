Console.WriteLine("Video 3 Ders Notları");
// Thread thread = new(() =>
// {
//     for (int i = 0; i < 100; i++)
//     {
//         Console.WriteLine("Woeker thread");
//     }
// });
// thread.Start();
// for (int i = 0; i < 100; i++)
// {
//     Console.WriteLine("Main Thread");
// }

#region Thread Id
// Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
// Thread thread1 = new(() =>
// {
//     Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
// });
// Thread thread2 = new(() =>
// {
//     Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
// });
// thread1.Start();
// thread2.Start();
#endregion

#region IsBackground 
// Thread thread = new(() =>
// {
//     for (int i = 0; i < 10; i++)
//     {
//         Console.WriteLine(i);
//         Thread.Sleep(1000);
//     }
//     Console.WriteLine("Worker thread sonlandı");
// });
// thread.IsBackground = false;
// thread.Start();

// Console.WriteLine("Main Thread Sonlandı");
#endregion
#region Thread State'i
//threadin bilgisni veririr
Thread thread = new(() =>
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(i);
        Thread.Sleep(1000);
    }
    Console.WriteLine("Worker thread sonlandı");
});
thread.Start();
System.Threading.ThreadState state = System.Threading.ThreadState.WaitSleepJoin;
while (state != System.Threading.ThreadState.Stopped)
{

    if (state != thread.ThreadState)
    {
        state = thread.ThreadState;
        Console.WriteLine(state);
    }
}

Console.WriteLine("Main Thread Sonlandı");

#endregion