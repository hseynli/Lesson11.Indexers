Console.OutputEncoding = System.Text.Encoding.UTF8;

MyClass my = new MyClass();

for (int i = 0; i < 6; i++)
{
    my[i] = string.Format("string {0}", i);
}

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(my[i]);
}