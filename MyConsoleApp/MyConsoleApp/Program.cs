var hosted = Environment.GetEnvironmentVariable("HOSTED") ?? "Local"; // HOSTED variable can be changed on environment

Console.WriteLine($"Runing app from {hosted}...");
Console.WriteLine($"Date: {DateTime.Now.ToLongDateString()}");
Console.WriteLine($"Time: {DateTime.Now.ToLongTimeString()}");
Console.WriteLine("Executing completed successfully.");