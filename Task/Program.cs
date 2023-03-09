
int array_length = EnterNumber("Enter a number of elements in your array");
string[] setOfElements = new string[array_length];
string[] resultSet = new string[0]; 

void FillArr(string[] set_elems)
{
    for (int i = 0; i < array_length; i++)
    {
        Console.WriteLine("Enter an element to be placed in the array: ");
        set_elems[i] = Console.ReadLine();
    }
}

void CheckArray(string[] set_elems)
{
    for (int i = 0; i < array_length; i++)
    {
        if (set_elems[i].Length > 2) 
        {
            // resultSet[i] = set_elems[i];
            resultSet = resultSet.Append(set_elems[i]).ToArray();
        }
        // resultSet = resultSet.Where(x => !string.IsNullOrEmpty(x)).ToArray();
    }
}

void PrintArray(string[] set_elems)
{
    if (set_elems.Length > 0)
    {
        Console.Write("[");
        for (int j = 0; j < set_elems.Length - 1; j++)
        {
            Console.Write($"\"{set_elems[j]}\", ");
        }
        Console.Write($"\"{set_elems[set_elems.Length - 1]}\"]");
    }
    else Console.WriteLine("[]");
}

int EnterNumber(string text) 
{
    Console.WriteLine($"{text}: ");
    int result;
    while (true)
    { 
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            return result;

        System.Console.WriteLine($"Error. {text}: ");
    }
    return 0;
}

FillArr(setOfElements);
Console.WriteLine("Your array is the following:");
PrintArray(setOfElements);
Console.WriteLine();
Console.WriteLine("The resulting array with elements of 3 and more symbols is: ");
CheckArray(setOfElements);
PrintArray(resultSet);




