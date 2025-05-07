
int[] nums = new int [10];

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = i + 1;
}

int sum  = 0;
for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];
}
Console.WriteLine("The sum is " + sum);

float avg = (float)sum/nums.Length;
Console.WriteLine("The average is " + avg);

Random rand = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = rand.Next(100);
}

foreach (var item in nums)
{
    Console.WriteLine(item);
}

int max  = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
}
Console.WriteLine("The max is " + max);

int min = nums[0];
for (int i = 0; i < nums.Length; i++)
{
    if (nums[i] < min)
    {
        min = nums[i];
    }
}
Console.WriteLine("The min is " + min);