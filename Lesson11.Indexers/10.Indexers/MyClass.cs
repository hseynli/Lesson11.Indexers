class MyClass
{
    private string[] array = new string[5];

    // İndeksator. 
    public string this[int index]
    {
        get    // Aksessor.
        {
            if (index >= 0 && index < array.Length)
                return array[index];
            else
                return "Array-dan kənara müracirət!";
        }
        set    // Mutator.
        {
            if (index >= 0 && index < array.Length)
                array[index] = value;
            else
                Console.WriteLine("Array-dan kənara müracirət!");
        }
    }
}