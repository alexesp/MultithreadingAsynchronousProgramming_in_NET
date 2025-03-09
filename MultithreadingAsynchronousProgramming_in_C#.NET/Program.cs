



//void WriteThreadId()
//{
//    for (int i = 0; i < 10; i++)
//    {
//        Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
//        Console.WriteLine(Thread.CurrentThread.Name);
//        Thread.Sleep(100);
//    }
//}

//WriteThreadId();

//Thread thread1 = new Thread(WriteThreadId);
//thread1.Start();

//Thread thread2 = new Thread(WriteThreadId);
//thread2.Start();

//Thread thread1 = new Thread(WriteThreadId);
//Thread thread2 = new Thread(WriteThreadId);

//thread1.Name = "Thread1";
//thread2.Name = "Thread2";
//Thread.CurrentThread.Name = "ThreadMain";

//thread1.Priority = ThreadPriority.Highest;
//thread2.Priority = ThreadPriority.Lowest;
//Thread.CurrentThread.Priority = ThreadPriority.Normal;

//thread1.Start();
//thread2.Start();

//WriteThreadId();

//##########################################################

//foreach(Button button in Controls.OfType<Button>())
//{
//    button.Click += async (s, e) => { await Task.Delay(1000); Process.Start("notepad"); };
//}

//##########################################################
//int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//int SumSegment(int start, int end)
//{
//    int segmentSum = 0;
//    for(int i = start; i < end;i++)
//    {
//        Thread.Sleep(100);
//        segmentSum += array[i];
//    }
//    return segmentSum;
//}



//int sum = 0;

//int sum1 = 0, sum2 = 0, sum3 = 0, sum4 = 0;

//var startTime = DateTime.Now;

//int numofThreads = 4;
//int segmentLength = array.Length / numofThreads;

//Thread[] threads = new Thread[numofThreads];
//threads[0] = new Thread(() => { sum1 = SumSegment(0, segmentLength); });
//threads[1] = new Thread(() => { sum2 = SumSegment(segmentLength, 2 * segmentLength); });
//threads[2] = new Thread(() => { sum3 = SumSegment(2 * segmentLength, 3 * segmentLength); });
//threads[3] = new Thread(() => { sum4 = SumSegment(3 * segmentLength, array.Length); });

//foreach(var thread in threads)
//{
//    thread.Start();
//}
//foreach (var thread in threads)
//{
//    thread.Join();
//}
//foreach(var num in array)
//{
//    Thread.Sleep(100);
//    sum += num;
//}

//var endTime = DateTime.Now;

//var timeSpan = endTime - startTime;


//Console.WriteLine($"The sum is {sum}");


//Console.WriteLine($"The sum is {sum1 + sum2 + sum3 + sum4}");
//Console.WriteLine($"The time it takes: {timeSpan.TotalMilliseconds}");


//###################  TASK  ###########################################################

//Task task = new Task(Work);
//task.Start();

//Task.Run(Work);
//var task = Task.Run(Work);


//Console.WriteLine(task.Id);
//void Work()
//{
//    Console.WriteLine("Task");
//    Console.WriteLine(Thread.CurrentThread.IsThreadPoolThread);
//}



//int sum = 0;

//var task = Task.Run(() =>
//{
//    for (int i = 1; i <= 100; i++)
//    {
//        Task.Delay(100);
//        sum += i;
//    }
//});
//task.Wait();

//Console.WriteLine($"The result is: {sum}");




//using System.Text.Json;

//using var client = new HttpClient();

//var taskList = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon");


//var tastkUrl = taskList.ContinueWith(t =>
//{
//    var result = t.Result;
//Console.WriteLine(result);

//var doc = JsonDocument.Parse(result);

//JsonElement root = doc.RootElement;
//JsonElement results = root.GetProperty("results");
//JsonElement firstResult = results[0];

// Console.WriteLine($"Name: {firstResult.GetProperty("name")}");
//Console.WriteLine($"Url: {firstResult.GetProperty("url").ToString()}");
//return firstResult.GetProperty("url").ToString();

//root.GetProperty("results");
//});

//var taskJson = tastkUrl.ContinueWith(t =>
//{
//    var result = t.Result;

//    return client.GetStringAsync(result);
//}).Unwrap();

//taskJson.ContinueWith(t =>
//{

//    var result = t.Result;
//    var doc = JsonDocument.Parse(result);
//    JsonElement root = doc.RootElement;
//    JsonElement results = root.GetProperty("name");

//    Console.WriteLine($"Name: {root.GetProperty("name").ToString()}");
//Console.WriteLine($"Url: {firstResult.GetProperty("url").ToString()}");
//});





//var tasks = new[]
//{
//    Task.Run(() =>
//    {
//        throw new InvalidOperationException("Invalid operation.");
//    }),
//    Task.Run(() =>
//    {
//        throw new ArgumentNullException("Argument null.");
//    }),
//    Task.Run(() =>
//    {
//        throw new Exception("General Exception.");
//    })

//};

//Task.WhenAll(tasks).ContinueWith(t =>
//{
//    if (t.IsFaulted && t.Exception != null)
//    {
//        foreach (var ex in t.Exception.InnerExceptions)
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//});

//var t = Task.WhenAll(tasks);
//t.Wait();


//###################################################################################

using System.Text.Json;

OutputFirst();

Console.ReadLine();





async void OutputFirst()
{


    using var client = new HttpClient();

    var taskList = client.GetStringAsync("https://pokeapi.co/api/v2/pokemon");


    var response = await taskList;

        var doc = JsonDocument.Parse(response);

        JsonElement root = doc.RootElement;
        JsonElement results = root.GetProperty("results");
        JsonElement firstResult = results[0];

        Console.WriteLine($"Name: {firstResult.GetProperty("name")}");
       
   
}


//Console.ReadLine();