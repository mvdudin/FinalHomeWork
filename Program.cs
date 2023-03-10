// Забираем из исходного строкового массива элементы длинна которых не более 3-х символов

string[] ArrayFilter(string[] pArray)
{
    int vCount = 0;
    string vTemp;
    for (int i = 0; i < pArray.Length; i++)
    {
        if (pArray[i].Length < 4)
        {
            vTemp = pArray[vCount];
            pArray[vCount] = pArray[i];
            pArray[i] = vTemp;
            vCount++;
        }
    }

    string[] vResult = new string[vCount];
    for (int i = 0; i < vCount; i++)
    {
        vResult[i] = pArray[i];
    }
    return vResult;
}

void PrintArray(string[] pArray)
{
    string vResult = string.Join(',', pArray);
    Console.WriteLine(vResult);
}

Console.Clear();
string[] vArray = new string[5] { "Hello", "word", "2", "you", ";-)" };
Console.Write("Исходный массив: ");
PrintArray(vArray);
Console.Write("Итоговый массив: ");
PrintArray(ArrayFilter(vArray));
