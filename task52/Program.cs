// Console.WriteLine("введите m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array2d = new int[m,n];

for (int i =0; i< m; i++)
{
    string[] text = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);
    for (int j  = 0; j < n; j++)
    
    {
        array2d[i,j] = Convert.ToInt32(text[j]);
        Console.Write(array2d[i,j] + " ");
}   
    }  
Console.WriteLine();

double sum = 0;

for (int j=0; j<n; j++)
{
    for (int i=0; i<m; i++)
    {
        sum = sum + array2d[i,j];
    }
}
Console.Write($"{ sum / array2d.GetLength(0)} ");