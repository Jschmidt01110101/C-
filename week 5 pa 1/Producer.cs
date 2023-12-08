
    // James Schmidt
    // 12/8/23
    // Assignment: CIS317 Performance Assessment Concurrency Multiple Producers & Consumers
    // Description: Consumer class with multiple producers and consumers support
class Producer
{
    private string name;
    private int sleepTime;
    private int startProducing;
    private int stopProducing;
    private BlockingBuffer buffer;

    public Producer(string name, int sleepTime, int startProducing, int stopProducing, BlockingBuffer buffer)
    {
        this.name = name;
        this.sleepTime = sleepTime;
        this.startProducing = startProducing;
        this.stopProducing = stopProducing;
        this.buffer = buffer;
    }

    public void Run()
    {
        for (int i = startProducing; i <= stopProducing; i++)
        {
            Thread.Sleep(sleepTime * 1000);
            buffer.BlockingPut(i, name);
        }
        Console.WriteLine($"Producer {name} done producing");
    }
}