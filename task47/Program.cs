Console.WriteLine("введите m и n");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] array2d = new double[m,n];
Console.WriteLine("введите числа через;");
for (int i = 0; i< m; i++)
{
    string text = Console.ReadLine();
    string[] array = text.Split(";"); 
    for (int j =0; j<n; j++)
    {
        array2d[i,j] = Convert.ToDouble(array[j]);
        Console.Write(array2d[i,j] + " ");
    }
}  
    
