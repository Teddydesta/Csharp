void Fundamentals(){
Console.WriteLine("Hello, Ajara!");

string firstName= "Tewodros";
string lastName = "Desta";
string name = "my first name is    " + firstName + "   and     " + "  my father name is: " + lastName;

//string interpolation in c#
Console.WriteLine($"My first name is    {firstName}      and   my father name is {lastName}");

//string concatination
 Console.WriteLine();

//trim()
string name1= "     Tewodros     ";
Console.WriteLine(name.Trim()); 

//search string and replace string
Console.WriteLine(name.Replace("Tewodros", "Teddy"));


//find for string in the code
bool myName= name.Contains("Tewodros");
Console.WriteLine(myName);

//to upper
Console.WriteLine(name.ToUpper());
//length
Console.WriteLine(name.Length);
}

//
// Numbers in C#

// workingWithNumber();

void workingWithNumber(){
int a= 2100000000; 
int b= 2100000000;
int c =  a + b;
Console.WriteLine(c);


long d= 2100000000; 
long e= 2100000000;
long f =  d + e;
Console.WriteLine(f);


int g= 2100000000; 
int h= 2100000000;
long i =  checked(g + h);
Console.WriteLine(i);

}
// OrderPrecedence();
void OrderPrecedence(){
    int a = 10;
    int b = 12;
    int c =  2;
    int d =  a + b * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    
}

