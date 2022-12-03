
Console.Clear();
String[] array = { "hello", "2", "world", ":-)" };

PrintArrayResult(array);

int GetNewArrayLength(String[] arr)
{
    int j = 0;
    foreach (var it in arr)
    {
        if (it.Length <= 3)
        {
            j++;
        }
    }
    return j;
}

void PrintArrayResult(String[] ar)
{
    int i = 0;
    String[] arRes = new String[GetNewArrayLength(array)];
    foreach (var item in ar)
    {
        if (item.Length <= 3)
        {
            arRes[i] = item;
            i++;
        }
    }
    Console.WriteLine($"[\"{String.Join("\", \"", ar)}\"] -> [\"{String.Join("\", \"", arRes)}\"]");
}