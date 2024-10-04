
int[] og = new int[10];

Random rand = new Random();

for (int i = 0; i < og.Length; i++)
{
    og[i] = rand.Next(10)+1;
}

int[] copy = new int[og.Length];

for (int i = 0;i < copy.Length; i++)
{
    copy[i] = og[i];
}

PrintNumbers(og);
PrintNumbers(copy);

static void PrintNumbers(int[] nums)
{
    Console.Write("[");
    for (int i = 0; i < nums.Length; ++i)
    {
        if (i < nums.Length - 1)
        {
            Console.Write(nums[i] + ", ");
        }
        else
        {
            Console.Write(nums[i]);
        }
    }
    Console.Write("]\n");
}