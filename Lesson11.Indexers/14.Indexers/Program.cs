DerivedClass instance = new DerivedClass();
BaseClass instance1 = instance;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine(instance1[i]);
}