
/*******************************************************************
* Name: James Schmidt
* Date:12/3/23
* Assignment: CIS317 Week 5 GP – Concurrency
*
* Consumer class used to use (or consume) items that the producer
* places in the buffer.
*/
public class Consumer
{
private BlockingBuffer SharedLocation;
private Random Generator = new Random();
public Consumer(BlockingBuffer sharedLocation)
{
SharedLocation = sharedLocation;
}
public async Task Run()
{
int sum = 0;
for (int count = 1; count <= 10; count++)
{
//Sleep for a random time up to 4 seconds
await Task.Delay(Generator.Next(4000));
sum += SharedLocation.BlockingGet();
}
Console.WriteLine(
"\nConsumer read values totaling {0}\nTerminating Consumer\n",
sum);
}
}