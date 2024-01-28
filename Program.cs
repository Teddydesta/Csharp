// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Ajara!");

string firstName= "Tewodros";
string lastName = "Desta";
string name = "my first name is    " + firstName + "and     " + "    my father name is:" + lastName;
//string interpolation in c#
Console.WriteLine($"My first name is    {firstName}      and   my father name is {lastName}");

//string concatination
 Console.WriteLine();

//trim()
// string name1= "     Tewodros     ";
Console.WriteLine(name.Trim()); 

//search string and replace
Console.WriteLine(name.Replace("Tewodros", "Teddy"));
