

// 1. open the file for reading
StreamReader myFile = new StreamReader("test.txt");

// 2. Read the first line
string line = myFile?.ReadLine() ?? "null";

// 3. print the line
Console.WriteLine(line);

// 4. close the file
myFile?.Close();