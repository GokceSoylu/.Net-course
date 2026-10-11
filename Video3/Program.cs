
#region Spinning
//spinning olayı şu 
//yine multithreading'de senkrenizasyon gereken durumda yani iki ve daha fazla thread'in 
//aynı kaynağı kullanması durumunda spinngig kullanılabilir yani
//thread'in çalışması şarta conditiona bağlı yaparız
//bu sayade önde hangi thread'in çalışacağını da belirleyebilirz
// bool thread1condition = true;
// bool thread2condition = false;

// int i = 0;
// Thread thread1 = new(() =>
// {
//     while (thread1condition)
//     {
//         Console.WriteLine($"thread 1  : {++i}");
//         Thread.Sleep(1000);
//         if (i >= 10)
//         {
//             thread1condition = false;
//             thread2condition = true;
//             Thread.Sleep(5000);
//             Console.WriteLine($"thread 1 condition : {thread1condition}");
//             Console.WriteLine($"thread2 condition : {thread2condition}");
//         }
//     }
// });
// Thread thread2 = new(() =>
// {
//     while (!thread2condition) //işte bu! ne yaptık adlında iki thread'de aynı anda çalışırken biz birini diğeri bitene kadar yada istediğimz level gelene kadar beklet,yoruz bunu da bir condition'a bağlıyoruz
//     {
//         Thread.SpinWait(10); //cpu yakmamak için minşk bekleme ekledik
//     }
//     while (true)
//     {
//         Console.WriteLine($"tread 2 : {--i}");
//         Thread.Sleep(1000);
//         if (i <= 0)
//         {
//             thread2condition = false;
//             break;
//         }
//     }
// });
// thread1.Start();
// thread2.Start();
#endregion
#region Monitor Enter / Monitor Exit
// int i = 0;
// object locking = new();
// Thread thread1 = new(() =>
// {
//     try
//     {
//         Monitor.Enter(locking);
//         for (i = 0; i <= 10; i++)
//         {
//             Console.WriteLine($"thread 1 : {i}");
//         }
//     }
//     finally
//     {
//         Monitor.Exit(locking); //bir hata durununda exit yapılamaz diye her türlü exit işlemmin garantye alıyoruz
//     }
// });
// Thread thread2 = new(() =>
// {
//     try
//     {
//         Monitor.Enter(locking);
//         while (true)
//         {
//             Console.WriteLine($"thread 2  : {i}");
//             i--;
//             if (i <= 0)
//                 break;
//         }
//     }
//     finally
//     {
//         Monitor.Exit(locking);
//     }
// });
// thread1.Start();
// thread2.Start();
#endregion