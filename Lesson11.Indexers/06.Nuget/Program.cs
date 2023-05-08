#region Usings
using Bogus;
using System.Text;
#endregion

Console.OutputEncoding = Encoding.UTF8;

Faker faker = new Faker("az");
IPerson[] people = new Person[100];

for (int i = 0; i < people.Length; i++)
    people[i] = new Person(i + 1, faker.Name.FirstName(), faker.Name.LastName(), faker.Random.Number(18, 80));

for (int i = 0; i < people.Length; i++)
    Console.WriteLine(people[i]);

Console.WriteLine("\nDone!");

interface IPerson
{
    int Id { set; }
    string Name { set; }
    string Surname { set; }
    int Age { set; }
}

class Person : IPerson
{
    public int Id { private get; set; }
    public string Name { private get; set; }
    public string Surname { private get; set; }
    public int Age { private get; set; }

    public Person(int id, string name, string surname, int age)
    {
        Id = id;
        Name = name;
        Surname = surname;
        Age = age;
    }

    public override string ToString()
    {
        return $"{Id} {Name} {Surname} {Age}";
    }
}