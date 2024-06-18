using System;
using System.Diagnostics;


public class UUIDExample
{
    public static void Main()
    {
        // Medir o tempo de geração do UUID
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Guid uuid = Guid.NewGuid();
        stopwatch.Stop();
        TimeSpan uuidTime = stopwatch.Elapsed;

        Console.WriteLine("UUID: " + uuid.ToString());
        Console.WriteLine("Tempo para gerar UUID: " + uuidTime.TotalMilliseconds + " ms");

        // Medir o tempo de geração do ULID
        stopwatch.Reset();
        stopwatch.Start();
        Ulid ulid = Ulid.NewUlid();
        stopwatch.Stop();
        TimeSpan ulidTime = stopwatch.Elapsed;

        Console.WriteLine("ULID: " + ulid.ToString());
        Console.WriteLine("Tempo para gerar ULID: " + ulidTime.TotalMilliseconds + " ms");


        /*
        Console Results:

        UUID: 2dfcf7af-5507-4db6-a046-beca235cb554
        Tempo para gerar UUID: 1.064 ms

        ULID: 01J0PV7ZZ7FFM12SSPPRFP2E0W
        Tempo para gerar ULID: 4.4684 ms
        */
    }
}
