PrintWebSite(new Person());
PrintWebSite3(new Person() { Company = new Company() { WebSite = "hhh.com" } });


void PrintWebSite(Person person)
{
    if (person != null)
    {
        if (person.Company != null)
        {
            if (person.Company.WebSite != null)
            {
                Console.WriteLine(person.Company.WebSite.ToUpper());
            }
        }
    }
}

//OR
void PrintWebSite2(Person person)
{
    if (person != null && person.Company != null && person.Company.WebSite != null)
    {
        Console.WriteLine(person.Company.WebSite.ToUpper());
    }
}

//Elegant style
void PrintWebSite3(Person person)
{
    Console.WriteLine(person?.Company?.WebSite?.ToUpper());
}

class Person
{
    public Company Company { get; set; }
}
class Company
{
    public string WebSite { get; set; }
}