Console.OutputEncoding = System.Text.Encoding.UTF8;

Dictionary dictionary = new Dictionary();

Console.WriteLine(dictionary["kitab"]);
Console.WriteLine(dictionary["ev"]);
Console.WriteLine(dictionary["qələm"]);
Console.WriteLine(dictionary["masa"]);
Console.WriteLine(dictionary["karandaş"]);
Console.WriteLine(dictionary["alma"]);
Console.WriteLine(dictionary["günəş"]);

Console.WriteLine(new string('-', 20));

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(dictionary[i]);
}