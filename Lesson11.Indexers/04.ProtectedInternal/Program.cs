Console.WriteLine("\nDone!");

Person instance = new Person();
//əgər sadəcə protected olsaydı, onda görsənməyəcəkdi
string name = instance.Name;

class Person
{
    //protected və internal access modifier-lərin funksionallığını özündə birləşdirir.
    //bu acess modifier ilə olan üzvlər cari assably-də və ya digər assambly-də olan bu klası inherit edən klaslarda görsənir. 
    protected internal string Name { get; set; }
}