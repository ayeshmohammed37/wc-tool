// Take the prompt from user
Console.Write(">");
string prompt = Console.ReadLine();

// extract details of prompt
var command = prompt.Split(' ')[0];
var option = prompt.Split(' ')[1];
var path = prompt.Split(' ')[2];

if (option == "-c")
{
    Console.WriteLine($"{GetFileBytes(path)} {path}");
}



static long GetFileBytes(string path)
{
    FileInfo fi = new FileInfo(path);
    long size = fi.Length;

    return size;
}