
    // James Schmidt
    // 12/8/23
    // Assignment: CIS317 Performance Assessment Concurrency Multiple Producers & Consumers
    // Description: Consumer class with multiple producers and consumers support
using System;
using System.Collections.Concurrent;
using System.Threading;

class BlockingBuffer
{
    private BlockingCollection<int> buffer;

    public BlockingBuffer(int size)
    {
        buffer = new BlockingCollection<int>(size);
    }

    public void BlockingPut(int value, string name)
    {
        buffer.Add(value);
        Console.WriteLine($"Producer {name} writes {value}");
        Console.WriteLine($"Buffer cells occupied: {buffer.Count}");
    }

    public int BlockingGet(string name)
    {
        int value = buffer.Take();
        Console.WriteLine($"Consumer {name} reads {value}");
        Console.WriteLine($"Buffer cells occupied: {buffer.Count}");
        return value;
    }
}