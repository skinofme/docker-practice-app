using System.Diagnostics;

var stopWatch = new Stopwatch();
stopWatch.Start();

var hosted = Environment.GetEnvironmentVariable("HOSTED") ?? "Local"; // HOSTED variable can be changed on environment
var configuration = args.Length > 0 ? args[0] : "Development";


Console.WriteLine($"Runing app from {hosted}...{Environment.NewLine}");
Console.WriteLine($"Configuration: {configuration}");
Console.WriteLine($"Date: {DateTime.Now.ToLongDateString()}");
Console.WriteLine($"Time: {DateTime.Now.ToLongTimeString()}");

Console.WriteLine($"{Environment.NewLine}Executing completed successfully.");

stopWatch.Stop();
if(configuration.ToUpper().Equals("DEVELOPMENT") || configuration.ToUpper().Equals("TEST")) 
	Console.WriteLine($"Execution time: {stopWatch.ElapsedMilliseconds / 100.00}s");