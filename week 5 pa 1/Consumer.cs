
    // James Schmidt
    // 12/8/23
    // Assignment: CIS317 Performance Assessment Concurrency Multiple Producers & Consumers
    // Description: Consumer class with multiple producers and consumers support
class Consumer
{
    private string name;
    private int sleepTime;
    private int startConsuming;
    private int stopConsuming;
    private BlockingBuffer buffer;


    public Consumer(string name, int sleepTime, int startConsuming, int stopConsuming, BlockingBuffer buffer)
    {
        this.name = name;
        this.sleepTime = sleepTime;
        this.startConsuming = startConsuming;
        this.stopConsuming = stopConsuming;
        this.buffer = buffer;
    }

    public void Run()
    {
        int sum = 0;
        for (int i = startConsuming; i <= stopConsuming; i++)
        {
            Thread.Sleep(sleepTime * 1000);
            int value = buffer.BlockingGet(name);
            sum += value;
        }
        Console.WriteLine($"Consumer {name} read values totaling {sum}");
        Console.WriteLine($"Terminating Consumer");
    }
}
