// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ex_64!");
Console.WriteLine("Write start number");
int start = Convert.ToInt32(Console.ReadLine());
int finish = 1;

string recursion(int number, int b){
   
    if ( number <= b) return recursion(number+1, b) + number;
    else
    return String.Empty;
}



Console.WriteLine();

Console.WriteLine(recursion(finish, start));