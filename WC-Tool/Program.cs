// Take the prompt from user
Console.Write(">");
string prompt = Console.ReadLine();

// extract details of prompt
var command = prompt.Split(' ')[0];
var option = prompt.Split(' ')[1];
var path = prompt.Split(' ')[2];

