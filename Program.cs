// 1. program that takes the user's name as input and prints a greeting message.
Console.WriteLine("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine(name);

// 2. Print first N even numbers entered by the user.
Console.WriteLine("Enter a number to print first N even numbers: ");
int number = int.Parse(Console.ReadLine());
for(int i =1;i<number; i++)
{
    if (number%i==0)
    {
        Console.WriteLine(i);
    }
}

// 3. program to calculate the factorial of a number entered by the user. 
number = int.Parse(Console.ReadLine());
int fact = 1;
if (number >= 1)
{
    for (int i = 1; i < number; i++)
    {
        fact = fact * i;
    }
}
Console.WriteLine(fact);

// 4. reverse the string
Console.WriteLine("Enter a string to print its reverse.");
string str = Console.ReadLine();
string reverse = "";
for(int i=str.Length-1; i>=0; i--)
{
    reverse = reverse + str[i];
}
Console.WriteLine("The reverse of the String is: "+reverse);

// 5. program to calculate the sum of all even numbers between 1 and 100. 

int sum = 0;
for(int i=1; i<=100; i=i+2)
{
    sum = sum + i;
}

// or 
sum = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        sum = sum + i;
    }
}
Console.WriteLine("Sum of fist 100 even numbers");

// 6. print the fibonacci series
Console.WriteLine("Enter a number to display the fibonacci series.");
number = int.Parse(Console.ReadLine());
int a = 0, b = 1;
Console.Write(a+" "+b);
for(int i = 2; i <= number; i++)
{
    int next = a + b;
    Console.Write(" "+next);
    //swap a ->b and b->next
    a = b;
    b = next;
}
