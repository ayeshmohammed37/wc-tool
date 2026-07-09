// Take the prompt from user
Console.Write(">");
var prompt = Console.ReadLine().Split(' ');

if (prompt.Length == 2)
{
    string file = prompt[1];
    Console.WriteLine($"{GetFileLines(file)} {GetFileWords(file)} {GetFileBytes(file)} {file}");
    return;
}
// extract details of prompt
var command = prompt[0];
var option = prompt[1];
var path = prompt[2];

if (option == "-c")
{
    Console.WriteLine($"{GetFileBytes(path)} {path}");
}


if (option == "-l")
{
    Console.WriteLine($"{GetFileLines(path)} {path}");
}

if (option == "-w")
{
    Console.WriteLine($"{GetFileWords(path)} {path}");
}

if (option == "-m")
{
    Console.WriteLine($"{GetFileChars(path)} {path}");
}


static long GetFileBytes(string path)
{
    FileInfo fi = new FileInfo(path);
    long size = fi.Length;

    return size;
}

static long GetFileLines(string path)
{
    StreamReader sr = new StreamReader(path);
    long counter = 0;
    while (sr.ReadLine() != null)
    {
        counter++;
    }

    return counter;
}

static long GetFileWords(string path)
{
    long wordCount = 0;

    foreach (string line in File.ReadLines(path))
    {
        bool inWord = false;

        foreach (char c in line)
        {
            if (char.IsWhiteSpace(c))
            {
                inWord = false;
            }
            else if (!inWord)
            {
                wordCount++;
                inWord = true;
            }
        }
    }

    return wordCount;
}

static long GetFileChars(string path)
{
    // long charCount = 0;
    // foreach (string line in File.ReadLines(path))
    // {
    //     charCount += line.Length + 1;
    //     // foreach (char c in line)
    //     // {
    //     //     if (!(char.IsWhiteSpace(c)))
    //     //     {
    //     //         charCount++;
    //     //     }
    //     // }
    // }

    // return charCount;

    long charCount = 0;
    using (StreamReader sr = new StreamReader(path))
    {
        int i = default;
        while((i = sr.Read()) != -1)
        {
            charCount++;
        }
    }
    return charCount + 1;
}