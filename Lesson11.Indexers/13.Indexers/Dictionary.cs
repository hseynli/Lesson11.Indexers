class Dictionary
{
    private string[] key = new string[5];
    private string[] value = new string[5];

    public Dictionary()
    {
        key[0] = "kitab"; value[0] = "book";
        key[1] = "qələm"; value[1] = "pen";
        key[2] = "günəş"; value[2] = "sun";
        key[3] = "alma"; value[3] = "apple";
        key[4] = "masa"; value[4] = "table";
    }

    public string this[string index]
    {
        get
        {
            for (int i = 0; i < key.Length; i++)
                if (key[i] == index)
                    return key[i] + " - " + value[i];

            return string.Format("{0} - bu sözün tərcüməsi yoxdur.", index);
        }
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < key.Length)
                return key[index] + " - " + value[index];
            else
                return "Massivdən kənara müraciət.";
        }
    }
}