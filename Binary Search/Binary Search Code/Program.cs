// int[] num = new int[5] { 2, 5, 9, 11, 34 };
int[] num = { 2, 5, 9, 11, 34 };
int n = num.Length;
int low = 0, high = n - 1;
int target = 35;
bool isTarget = false;
int mid = 0;

while (low <= high)
{
    mid = (low + high) / 2;
    if (num[mid] == target)
    {
        isTarget = true;
        break;
    }
    if (num[mid] < target)
    {
        low = mid + 1;
    }
    else
    {
        high = mid - 1;
    }
}
if (isTarget)
{
    Console.WriteLine($"{target} index of - {mid}");
}
else
{
    System.Console.WriteLine("Not Fount !!");
}

Console.ReadLine();