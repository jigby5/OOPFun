// Enter a quote

using OOPFun;

string quote = "";

WordTools wt = new WordTools();

Console.WriteLine("Please enter a quote to analyze: ");

quote = Console.ReadLine();

Console.WriteLine($"Number of words: {wt.WordCounter(quote)}");
Console.WriteLine($"Number of characters: {wt.CharacterCounter(quote)}");
wt.AlphabetCounter(quote);

Console.WriteLine("This is a change!");