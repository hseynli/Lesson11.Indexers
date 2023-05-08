class BaseClass
{
    private string[] baseArray = null;

    // Konstruktor.
    public BaseClass()
    {
        baseArray = new string[6];
        baseArray[0] = "Sıfır";
        baseArray[1] = "Bir";
        baseArray[2] = "İki";
        baseArray[3] = "Üç";
        baseArray[4] = "Dörd";
        baseArray[5] = "Beş";
    }

    // Virtual indeksator.
    public virtual string this[int index]
    {
        get { return baseArray[index]; }
    }
}