String  name;
String Motive;
int Age;

Console.WriteLine("Enter Your FullName ");
name = Console.ReadLine();
Console.WriteLine("Describe your motive in life");
Motive = Console.ReadLine();
Console.WriteLine("Enter your Age: ");
Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your Named is {0}  ", name);
Console.WriteLine("Your Motive in Life is {0}",Motive);
Console.WriteLine("And you are {0} years old", Age);
