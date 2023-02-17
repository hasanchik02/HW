string [] Array (int size)
{
    string [] array = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        string s = Console.ReadLine();
        if (s != "")
        {
            if (s.Length <= 3) array[i] = s;
            else array[i] = "-"; 
        }
        else
        {
            array[i] = "-";
        }
    }
    return array;
}