
String [] Arr = new []
{"hello", "2" ,"word","-))","1"};

void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");

    }
    System.Console.Write("]");
}



string [] SearchArray (string []arr)
{    
    string [] arry = new string [arr.Length];
    for(int i=0; i<arr.Length;i++)
    {
       if(arr[i].Length <= 3)
       {
       arry[i]= arr[i];
       }
    }
    return arry;
}
PrintArray( Arr);
SearchArray(Arr);
string [] Myarr = SearchArray(Arr);
Console.WriteLine();
PrintArray(Myarr);