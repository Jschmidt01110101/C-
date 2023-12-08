
/*******************************************************************
* Name: James Schmidt
* Date:12/3/23
* Assignment: CIS317 Week 5 GP – Concurrency
*
* BlockingBuffer class that acts as the warehouse where the producer
* stores items produced and the consumer retrieves (or reads) items
* to consume.
*/
using System.Collections.Concurrent;
public class BlockingBuffer
{
private BlockingCollection<int> BColl;
public BlockingBuffer()
{
BColl = new BlockingCollection<int>(10);
}
public void BlockingPut(int value)
{
BColl.Add(value);
Console.WriteLine("Producer writes {0}\tBuffer cells occupied: {1}",
value, BColl.Count);
}
// return value from buffer
public int BlockingGet()
{
int readValue = BColl.Take();
Console.WriteLine("Consumer reads {0}\tBuffer cells occupied: {1}",
readValue, BColl.Count);
return readValue;
}
}