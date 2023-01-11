Console.Clear();

void FillArray(string[] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
arr[i] = Console.ReadLine();
}
}

void PrintArray(string[] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
// System.Console.Write($"[ {arr[i]} ] ");
System.Console.Write('[' + (arr[i]) + ']');
}
System.Console.WriteLine();
}

void LessThenThree(string[] arr)
{
int maxlenght = 3;
for (int i = 0; i < arr.GetLength(0); i++)
{
if (arr[i].Length > maxlenght) arr[i] = null;
}
}

System.Console.WriteLine("How much elements of array you wohn to input? :");
int numbers = int.Parse(Console.ReadLine());
System.Console.WriteLine($"Input {numbers} any elements you like :");

string[] array = new string[numbers];

FillArray(array);
System.Console.WriteLine("Your array is : ");
PrintArray(array);
LessThenThree(array);
System.Console.Write("Your array with elements less or equal three symbols is :");
System.Console.WriteLine();
PrintArray(array);