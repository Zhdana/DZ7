Console.WriteLine("введите m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m,n];
Random random = new Random();
for(int i =0; i< m; i++)
{
    for(int j =0; j<n; j++)
    {
        array2d[i,j]= random.Next(-10,10);
        Console.Write(array2d[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("введите c");
int c = Convert.ToInt32(Console.ReadLine());

bool Index(int[,] array, int number)
{   

    for(int i =0; i< m; i++)
     {
         for(int j =0; j<n; j++)
        {if (number == array[i,j])
        Console.WriteLine(string.Join(",", i,j)); 
               
        } 
     }
    return true;
}
bool result = Index(array2d, c);
if (result == true)
Console.WriteLine("нашли все совпадения!");
else
Console.WriteLine("совпадений нет!");