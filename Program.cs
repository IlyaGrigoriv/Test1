
String [] Arr = new []
{"hello", "2" ,"word","-))"};

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");

    }
    System.Console.Write("]");
}

PrintArray( Arr);

