```C#
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int[] result = ProductExceptSelf(arr);

        foreach (int val in result)
        {
            Console.WriteLine(val);
        }
    }

    static int[] ProductExceptSelf(int[] nums)
    {
        int length = nums.Length;
        int[] answer = new int[length];

        answer[0] = 1;
        for (int i = 1; i < length; i++)
        {
            answer[i] = nums[i - 1] * answer[i - 1];
        }

        int R = 1;
        for (int i = length - 1; i >= 0; i--)
        {
            answer[i] = answer[i] * R;
            R *= nums[i];
        }

        return answer;
    }
}
```