
/*******************************************************************
* Name: James Schmidt
* Date:12/3/23
* Assignment: CIS317 Week 5 GP – Concurrency
*
* Main application class.
*/
public class AsyncDemo
{
static async Task Main(string[] args)
{
Console.WriteLine("\nJames Schmidt, Week 5 Concurrrency GP\n");
BlockingBuffer sharedLocation = new BlockingBuffer();
Task producer = new Producer(sharedLocation).Run();
Task consumer = new Consumer(sharedLocation).Run();
await producer;
await consumer;
}
}
