class DerivedClass : BaseClass
{
    private string[] derivedArray = null;

    // Kontruktor.
    public DerivedClass()
    {
        derivedArray = new string[6];
        derivedArray[0] = "Zero!";
        derivedArray[1] = "One!";
        derivedArray[2] = "Two!";
        derivedArray[3] = "Three!";
        derivedArray[4] = "Four!";
        derivedArray[5] = "Five!";
    }

    // Override olunmuş indeksator.
    public override string this[int index]
    {
        get { return base[index] + " - " + derivedArray[index]; }
    }
}