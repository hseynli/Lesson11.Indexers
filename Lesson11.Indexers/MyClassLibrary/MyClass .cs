public class MyClass
{
    internal string InternalPropery { get; set; }
    public string PublicPropery { get; set; }

    private MyClass() { }

    public MyClass(string publicPropery)
    {
        PublicPropery = publicPropery;
    }

    public MyClass(string publicPropery, string internalPropery)
    {
        PublicPropery = publicPropery;
        InternalPropery = internalPropery;
    }

    public string GetInternalValue()
    {
        return InternalPropery;
    }

    public string GetPublicValue()
    {
        return PublicPropery;
    }
}