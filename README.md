# stopwatch-elapsed-scales
Extension methods package for Stopwatch contain scales not present on framework as nano and micro

# Usage example:

```c
using StopwatchElapsedScales;

var sw = Stopwatch.StartNew();
Thread.Sleep(100);
sw.Stop();

Console.WriteLine("Micro: " + sw.ElapsedMicroSeconds());
Console.WriteLine("Nano : " + sw.ElapsedNanoSeconds());
Console.WriteLine("Pico : " + sw.ElapsedPicoSeconds());
```  
  
# Output:

	Micro: 100674
	Nano : 100673612
	Pico : 100673612305
