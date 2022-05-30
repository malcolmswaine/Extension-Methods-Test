// See https://aka.ms/new-console-template for more information
using ATEA_Test.Infrastructure;
using ATEA_Test.Models;

Console.WriteLine("Please enter a string");

var left = Console.ReadLine();

Console.WriteLine("Please enter another string");

var right = Console.ReadLine();

// sanitize
left = left ?? String.Empty;
right = right ?? String.Empty;

var concatenated = left.AppendString(right);

Console.WriteLine($"Concatenated, those strings are '{concatenated}'");

// Save it
using (Context context = new Context())
{
    var s = new ConcatenatedString() { Data = concatenated };
    context.ConcatenatedStrings.Add(s);
    context.SaveChanges();
}