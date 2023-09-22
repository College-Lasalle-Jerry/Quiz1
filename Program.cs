//// 1. program that takes the user's name as input and prints a greeting message.
//Console.WriteLine("Enter your name: ");
//string name = Console.ReadLine();

//Console.WriteLine(name);

//// 2. Print first N even numbers entered by the user.
//Console.WriteLine("Enter a number to print first N even numbers: ");
//int number = int.Parse(Console.ReadLine());
//for(int i =1;i<number; i++)
//{
//    if (number%2==0)
//    {
//        Console.WriteLine(i);
//    }
//}

//// 3. program to calculate the factorial of a number entered by the user. 
//Console.WriteLine("Factorial Number");
//number = int.Parse(Console.ReadLine());
//int fact = 1;
//if (number >= 1)
//{
//    for (int i = 1; i <= number; i++)
//    {
//        fact = fact * i;
//    }
//}
//Console.WriteLine(fact);

//// 4. reverse the string
//Console.WriteLine("Enter a string to print its reverse.");
//string str = Console.ReadLine();
//string reverse = "";
//for(int i=str.Length-1; i>=0; i--)
//{
//    reverse = reverse + str[i];
//}
//Console.WriteLine("The reverse of the String is: "+reverse);

//// 5. program to calculate the sum of all even numbers between 1 and 100. 

//int sum = 0;
//for(int i=1; i<=100; i=i+2)
//{
//    sum = sum + i;
//}

//// or 
//sum = 0;
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum = sum + i;
//    }
//}
//Console.WriteLine("Sum of fist 100 even numbers"+ sum);

//// 6. print the fibonacci series
//Console.WriteLine("Enter a number to display the fibonacci series.");
//number = int.Parse(Console.ReadLine());
//int a = 0, b = 1;
//Console.Write(a+" "+b);
//for(int i = 2; i <= number; i++)
//{
//    int next = a + b;
//    Console.Write(" "+next);
//    //swap a ->b and b->next
//    a = b;
//    b = next;
//}





// Pattern 1
Console.WriteLine("Pattern 1");
for (int i = 0; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//// Pattern 2
Console.WriteLine("Pattern 2");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

//// Pattern 3
Console.WriteLine("Pattern 3");
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(i);
    }
    Console.WriteLine();
}


//// Pattern 4
Console.WriteLine("Pattern 4");
for (int i = 1; i <= 5; i++)
{
    for (int j = i; j >= 1; j--) // Reverse, to get the pattern
    {
        Console.Write(j);
    }
    Console.WriteLine();
}

//// Pattern 5
Console.WriteLine("Pattern 5");
for (int i = 1; i <= 5; i++)
{
    // 2 for loops
    // the space
    for (int j = 1; j <= 5 - i; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}

//// Pattern 6
Console.WriteLine("Pattern 6");
int rows = 4;
int counter = 1;

for (int i = 1; i <= rows; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write(counter + " ");
        counter++;
    }
    Console.WriteLine(); // to change the cursor
}

// Pattern 7
Console.WriteLine("Pattern 7");
char currentChar = 'E';
rows = 5;

for(int i=1;i<=rows; i++)
{
    for(int j = 1;j<=i; j++)
    {
        Console.Write(currentChar);
        currentChar++;
    }
    Console.WriteLine(); // to change the curor
    currentChar = (char)('E' - i); // explicitily typecasting.
}

// Pattern 8
Console.WriteLine("Pattern 8");
char ch = 'A';
for(int i = 1; i <= 5; i++)
{
    for(int j = 1; j <= i; j++)
    {
        Console.Write(ch);
    }
    Console.WriteLine();
    ch++;
}
