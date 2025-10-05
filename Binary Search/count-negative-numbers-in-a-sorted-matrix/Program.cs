int[][] num = [[4, 3, 2, -1], [3, 2, 1, -1], [1, 1, -1, -2], [-1, -1, -2, -3]];

int count = 0;
int i, j;

int n = num.Length;
int m = num[0].Length;

for (i = 0; i < n; i++)
{
    for (j = 0; j < m; j++)
    {
        if (0 > num[i][j])
        {
            count++;
        }
    }
}
System.Console.WriteLine("Negative number is : " + count);
