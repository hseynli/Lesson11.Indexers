PrintUpper(null);
PrintIfIsNotNull("Test");
CheckDataType(12.5);

Console.WriteLine(new string('-', 80));

string? text = null;
string name = text ?? "Tom";  // Tom
Console.WriteLine(name);      // Tom

Console.WriteLine(new string('-', 80));

//Analogue
string? text2 = null;
text2 ??= "Sam";
Console.WriteLine(text2);    // Sam

void PrintUpper(string? text)
{
    if (text is null) return;
    Console.WriteLine(text.ToUpper());
}

void PrintIfIsNotNull(string? text)
{
    if (text is not null)
        Console.WriteLine(text.ToUpper());
}

void CheckDataType(object obj)
{
    if (obj is int)
        Console.WriteLine("int");
    else if (obj is string)
        Console.WriteLine("string");
    else if (obj is decimal)
        Console.WriteLine("decimal");
    else if (obj is double)
        Console.WriteLine("double");
    else
        Console.WriteLine("NULL");
}