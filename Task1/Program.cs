string [] Array (int size)
{
    string [] array = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        string s = Console.ReadLine();
        array[i] = s;    
    }
    return array;
}