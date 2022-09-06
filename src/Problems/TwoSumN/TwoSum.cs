namespace Problems.TwoSumN
{
    public class TwoSum
    {
        public static int[] BruteForce(int[] input, int target)
        {
            var find = new int[2];

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (input[i] + input[j] == target)
                    {
                        find[0] = i;
                        find[1] = j;
                        break;
                    }
                }
            }

            return find;
        }

        public static int[] HashMap(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            var pairFound = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    pairFound[0] = map[nums[i]];
                    pairFound[1] = i;
                }
                else
                {
                    map[target - nums[i]] = i;
                }
            }

            map.ToList().ForEach(x => Console.WriteLine(x.Key));

            return pairFound;
        }
    }
}