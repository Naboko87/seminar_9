// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ex_68");

int mm = 2;
int nn = 3;


int akkerman(int m, int n){
    if (n == 0)
        return m + 1;
    else
      if (m == 0)
        return akkerman(n - 1, 1);
    else
        return akkerman(n - 1, akkerman(n, m - 1));
}
    
    Console.WriteLine(akkerman(mm, nn));


