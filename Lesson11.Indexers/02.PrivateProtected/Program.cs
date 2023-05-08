Console.WriteLine("\nDone!");

class A 
{
    //Ancaq bu klasda və ya A klasını inherit edən və eyni assambly-da olan klasda görsənəcək
    private protected string Name { get; set; }
}

class B : A
{
    public void ShowValue() => Console.WriteLine(Name);
}