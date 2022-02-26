void FillArray( int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length)
    {
        collection[index]= new Random().Next(1,10);
        index++;
    }
}
void PrintArray( int[] collect)
{
    int index = 0;
    int len = collect.Length;
    while (index<len)
    {
        Console.Write(collect[index]+" ");
        index++;
    }
}
void FindIndex( int[] ArrayForFind, int NumberForFind)
{
    int lengthFI= ArrayForFind.Length;
    int indexFI=0;
    int position=-1;
    while (indexFI<lengthFI)
    {
        if (ArrayForFind[indexFI]==NumberForFind)
        {
            position=indexFI;
            Console.WriteLine("This number is on "+position+" position.");
            break;
        }
        indexFI++;
    }
    if (position == -1) Console.WriteLine("There is no number you are lookin for :(");
}
int[] array = new int[10];
Console.Clear();
Console.WriteLine("Enter number to looking for.");
int LFnumber = Convert.ToInt32(Console.ReadLine()); 
FillArray(array);
PrintArray(array);
Console.WriteLine();
FindIndex(array, LFnumber);
