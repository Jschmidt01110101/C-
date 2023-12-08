
    // James Schmidt
    // 12/8/23
    // Assignment: CIS317 Performance Assessment Concurrency Multiple Producers & Consumers
    // Description: Consumer class with multiple producers and consumers support
class Program
{
    static void Main()
    {
        BlockingBuffer buffer = new BlockingBuffer(5);

        Producer producer1 = new Producer("P1", 2, 10, 10, buffer);
        Producer producer2 = new Producer("P2", 3, 25, 29, buffer);
        Producer producer3 = new Producer("P3", 1, 30, 39, buffer);

        Consumer consumer1 = new Consumer("C1", 3, 1, 9, buffer);
        Consumer consumer2 = new Consumer("C2", 2, 1, 13, buffer);

        Thread producerThread1 = new Thread(producer1.Run);
        Thread producerThread2 = new Thread(producer2.Run);
        Thread producerThread3 = new Thread(producer3.Run);

        Thread consumerThread1 = new Thread(consumer1.Run);
        Thread consumerThread2 = new Thread(consumer2.Run);

        producerThread1.Start();
        producerThread2.Start();
        producerThread3.Start();

        consumerThread1.Start();
        consumerThread2.Start();

        producerThread1.Join();
        producerThread2.Join();
        producerThread3.Join();

        consumerThread1.Join();
        consumerThread2.Join();

        Console.WriteLine("Program ended with exit code: 0");
    }
}