using static System.Console;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Carissia Reyes");
Console.WriteLine("Version: {0}", Environment.Version.ToString());
string text = System.IO.File.ReadAllText("text.txt");
Console.WriteLine(text);                                       

Console.WriteLine("Hello, Carissia ");
Console.WriteLine("Version: {0}", Environment.Version.ToString());
string[] names; // can reference any size array of strings

// allocating memory for four strings in an array
names = new string[4];

// storing items at index positions
names[0] = "Betty";
names[1] = "Bob";
names[2] = "Tim";
names[3] = "Ben";

string[] names2 = new[] { "Betty", "Bob", "Tim", "Ben" };

// looping through the names
for (int i = 0; i < names2.Length; i++)
{
  // output the item at index position i
  WriteLine(names2[i]);
}

string[,] grid1 = new[,] // two dimensions
{
  { "Amy", "Bill", "Gemma", "Delta" },
  { "Anne", "Ben", "Charles", "Daniel" },
  { "Aurora", "Bear", "Cat", "Dog" }
};

WriteLine($"Lower bound of the first dimension is: {grid1.GetLowerBound(0)}");
WriteLine($"Upper bound of the first dimension is: {grid1.GetUpperBound(0)}");
WriteLine($"Lower bound of the second dimension is: {grid1.GetLowerBound(1)}");
WriteLine($"Upper bound of the second dimension is: {grid1.GetUpperBound(1)}");

for (int row = 0; row <= grid1.GetUpperBound(0); row++)
{
  for (int col = 0; col <= grid1.GetUpperBound(1); col++)
  {
    WriteLine($"Row {row}, Column {col}: {grid1[row, col]}");
  }
}

// alternative syntax
string[,] grid2 = new string[3,4]; // allocate memory
grid2[0, 0] = "Alpha"; // assign string values
// and so on
grid2[2, 3] = "Dog";

string[][] jagged = new[] // array of string arrays
{
  new[] { "Amy", "Bill", "Gemma" },
  new[] { "Anne", "Ben", "Charles", "Daniel" },
  new[] { "Aurora", "Bear" }
};

WriteLine("Upper bound of array of arrays is: {0}",
  jagged.GetUpperBound(0));

for (int array = 0; array <= jagged.GetUpperBound(0); array++)
{
  WriteLine("Upper bound of array {0} is: {1}",
    arg0: array,
    arg1: jagged[array].GetUpperBound(0));
}

for (int row = 0; row <= jagged.GetUpperBound(0); row++)
{
  for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
  {
    WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
  }
}

// Pattern matching with arrays

int[] sequentialNumbers = new int[] { 2, 4, 5, 7, 8, 9, 10, 13, 44, 60 };
int[] oneTwoNumbers = new int[] { 2, 3 };
int[] oneTwoTenNumbers = new int[] { 4, 6, 7 };
int[] oneTwoThreeTenNumbers = new int[] { 5, 7, 9, 11 };
int[] primeNumbers = new int[] { 13, 17, 5, 7, 11, 13, 17, 21, 23, 29 };
int[] fibonacciNumbers = new int[] { 0, 2, 2, 3, 3, 5, 6, 12, 12, 34, 55, 89 };
int[] emptyNumbers = new int[] { };
int[] threeNumbers = new int[] { 1, 3, 9 };
int[] sixNumbers = new int[] { 7, 9, 3, 4, 8, 10 };

WriteLine($"{nameof(sequentialNumbers)}: {CheckSwitch(sequentialNumbers)}");
WriteLine($"{nameof(oneTwoNumbers)}: {CheckSwitch(oneTwoNumbers)}");
WriteLine($"{nameof(oneTwoTenNumbers)}: {CheckSwitch(oneTwoTenNumbers)}");
WriteLine($"{nameof(oneTwoThreeTenNumbers)}: {CheckSwitch(oneTwoThreeTenNumbers)}");
WriteLine($"{nameof(primeNumbers)}: {CheckSwitch(primeNumbers)}");
WriteLine($"{nameof(fibonacciNumbers)}: {CheckSwitch(fibonacciNumbers)}");
WriteLine($"{nameof(emptyNumbers)}: {CheckSwitch(emptyNumbers)}");
WriteLine($"{nameof(threeNumbers)}: {CheckSwitch(threeNumbers)}");
WriteLine($"{nameof(sixNumbers)}: {CheckSwitch(sixNumbers)}");

static string CheckSwitch(int[] values) => values switch
{
  [] => "Empty array",
  [1, 2, _, 10] => "Contains 1, 2, any single number, 10.",
  [1, 2, .., 10] => "Contains 1, 2, any range including empty, 10.",
  [1, 2] => "Contains 1 then 2.",
  [int item1, int item2, int item3] => 
    $"Contains {item1} then {item2} then {item3}.",
  [0, _] => "Starts with 0, then one other number.",
  [0, ..] => "Starts with 0, then any range of numbers.",
  [2, .. int[] others] => $"Starts with 2, then {others.Length} more numbers.",
  [..] => "Any items in any order.",
};