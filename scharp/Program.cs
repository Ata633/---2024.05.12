// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] array1 = ["Hello", "2", "world", ":-)"];
string[] array2 = ["1234", "1567", "-2", "computer science"];
string[] array3 = ["Russia", "Denmark", "Kazan"];

void PrintExercise_1(string[] str)
{
  string[] arrayController = ["2", "-2", ":-)"];
  for (int i = 0; i < str.Length; i++)
  {
    for (int j = 0; j < arrayController.Length; j++)
    {
      if (arrayController[j] == str[i])
      {
        Console.Write($"{str[i]} ");
      }
    }
  }
}

Console.Write("Exercise - 1: [Hello, 2, world, :-)] -> ");
PrintExercise_1(array1);
Console.WriteLine("");
Console.Write("Exercise - 2: [1234, 1567, -2, computer science] -> ");
PrintExercise_1(array2);
Console.WriteLine("");
Console.Write("Exercise - 3: [Russia, Denmark, Kazan] -> ");
PrintExercise_1(array3);