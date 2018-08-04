using System;
class Program
{
    static void Main()
    {
        ArrayList<int> nums = new ArrayList<int>();
        nums.Add(1);
        nums.Add(10);
        nums.Add(200);
        nums.Add(56);
        nums.Add(63);

        nums.RemoveAt(0);
        nums.RemoveAt(0);
        nums.RemoveAt(0);
    }
}

