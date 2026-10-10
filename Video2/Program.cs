Console.WriteLine("Video 3 Ders Notları");
#region Thread
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
#endregion
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
// Thread thread = new(() =>
// {
//     for (int i = 0; i < 10; i++)
//     {
//         Console.WriteLine(i);
//         Thread.Sleep(1000);
//     }
//     Console.WriteLine("Worker thread sonlandı");
// });
// thread.Start();
// System.Threading.ThreadState state = System.Threading.ThreadState.WaitSleepJoin;
// while (state != System.Threading.ThreadState.Stopped)
// {

//     if (state != thread.ThreadState)
//     {
//         state = thread.ThreadState;
//         Console.WriteLine(state);
//     }
// }

// Console.WriteLine("Main Thread Sonlandı");

#endregion
#region Race Condition
//birden fazla thread aynı kaynağı kullanılırsa yaşanabilecek problemdir
//race condition'ı çözmek için senkrenizayson teknikleirni kullancağız. 
//Race condition'ı çözmek için birden fazla çözüm yolu vardır
//en meşhur olan Locking tekniği ile başlıyoruz
// object locking = new();
// int i = 1;// thread'lerin ortak kullanacağı kaynak
// Thread thread1 = new(() =>
// {
//     lock (locking)
//     {
//         while (i <= 10)
//         {
//             Console.WriteLine($"thread 1 : {i}");
//             i++;
//         }
//     }
// });
// Thread thread2 = new(() => 
// {
//     lock (locking)
//     {
//         while (i > 0)
//         {
//             Console.WriteLine($"thread 2 : {i}");
//             i--;
//         }
//     }
// });
// thread1.Start();
// thread2.Start();
#endregion
#region Sleep
// int i = 0;
// Thread thread1 = new(() =>
// {
//     for (; i < 10;)
//     {
//         Console.WriteLine($"thread 1 : {i}");
//         i++;
//         Thread.Sleep(10);
//     }

// });
// Thread thread2 = new(() =>
// {
//     while (i < 10)
//         Console.WriteLine($"thread 2 : {i}");
// });
// thread1.Start();
// thread2.Start();
// Console.WriteLine("Main Thread Sonlandı");
#endregion
#region Join
// int i = 0;
// Thread thread1 = new(() =>
// {
//     while (i < 10)
//     {
//         i++;
//         Console.WriteLine($"thread1 : {i}");
//     }
// });
// Thread thread2 = new(() =>
// {
//     Console.WriteLine($"thraed2 : {i}");
// });
// thread1.Start();
// thread1.Join();
// thread2.Start();
#endregion
#region Thread İptal Etme - işaretle ve bitir
//bu yöntem yerine canselation tpken source da kulşnaılabilir detayaşrı ilerleyen derslerde
// bool shouldStop = false;
// Thread thread = new(() =>
// {
//     while (!shouldStop)
//     {
//         Console.WriteLine("in Thread");
//     }
//     Console.WriteLine("thread stoped");
// });
// thread.Start();
// Thread.Sleep(5000);//ana threadi biraz bekletiyoruz
// shouldStop = true;
#endregion
#region Interrupt metodu
//interrupt adı üstünde dürtme uyandırma
//uyuyan thread'i uyandırır
//exeption fırlatır try catch' ile yakalamka gerekir

#endregion