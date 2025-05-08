Console.WriteLine("#1");
//#1 Write a C# code snippet using a for loop to print only the even numbers from 2 to 20, each on a new line.
for (int i = 2; i <= 20; i += 2)
{
    Console.WriteLine(i);
}

//////////
Console.WriteLine(" ");
//////////

Console.WriteLine("#2");
//#2 Write a C# code snippet that uses a for loop to iterate through the following string array in reverse order and print each element: string[] words = {"apple", "banana", "cherry"};
string[] words = { "apple", "banana", "cherry" };
for (int i = words.Length - 1; i >= 0; i--)
{
    Console.WriteLine(words[i]);
}

//////////
Console.WriteLine(" ");
//////////

Console.WriteLine("#3");
//#3 Write a C# code snippet that uses a for loop to calculate the product of all the elements in the following double array: double[] values = {2.5, 1.5, 3.0}; Print the final product.
double[] values = { 2.5, 1.5, 3.0 };
double product = 1.0;
for (int i = 0; i < values.Length; i++)
{
    product *= values[i];
}

//////////
Console.WriteLine(" ");
//////////

Console.WriteLine("#4");
//#4 Write a C# code snippet that uses a for loop to print the following pattern to the console:
//*
//**
//***
//****
//*****
int triangleHeight = 5;
for (int i = 1; i <= triangleHeight; i++)
{
    Console.WriteLine(new string('*', i));
}

//////////
Console.WriteLine(" ");
//////////

Console.WriteLine("#5");
//#5 Given the integer array int[] data = {10, -5, 8, 0, 15, -2};, write a C# code snippet using a for loop to print only the positive numbers from the array, each on a new line.
int[] data = { 10, -5, 8, 0, 15, -2 };
for (int i = 0; i < data.Length; i++)
{
    if (data[i] > 0)
    {
        Console.WriteLine(data[i]);
    }
}
